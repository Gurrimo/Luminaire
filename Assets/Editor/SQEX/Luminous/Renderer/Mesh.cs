using SQEX.Ebony.Std;
using SQEX.Luminous.GraphicsCore;
using SQEX.Luminous.GraphicsLoad;
using SQEX.Luminous.Renderer.Binary;
using SQEX.Luminous.RenderInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace SQEX.Luminous.Renderer
{
    [DebuggerDisplay("{Name}")]
    public class Mesh
    {
        public GmdlMeshData GmdlMeshData { get; private set; }
        public LmGeometry GmdlGeometry { get; }
        public string Name { get; }
        public uint VertexCount { get; private set; }
        public uint TriangleCount { get; private set; }
        public uint TotalTriangleCount { get; private set; }
        public MeshVertexDeclaration MainStreamSet { get; private set; }
        public IList<VertexBuffer> VertexBuffers { get; } = new List<VertexBuffer>();
        public IndexBuffer IndexBuffer { get; private set; }
        public uint BoneInstanceCount { get; private set; }

        public IDictionary<string, IList> VertexElementArrays { get; } = new Dictionary<string, IList>();

        public Mesh(string name, LmGeometry gmdlGeometry)
        {
            this.Name = name;
            this.GmdlGeometry = gmdlGeometry;
        }

        public static Mesh Convert(LmMsgPck msg)
        {
            var name = msg.ReadString();
            var u0 = msg.ReadByte();
            var boneIdTable = LmBoneIdTable.Unpack(msg);
            var vertexLayoutType = (VertexLayoutType)msg.ReadInt();
            var geometry = LmGeometry.Unpack(msg);

            var mesh = new Mesh(name, geometry);
            mesh.Setup(geometry);

            // TODO get Material
            var defaultMaterialHash = msg.ReadUint64();

            var gmdlMeshData = new GmdlMeshData();
            mesh.GmdlMeshData = gmdlMeshData;

            if (msg.Version >= 20140623)
            {
                gmdlMeshData.DrawPriorityOffset = msg.ReadInt();
                if (msg.ReadBool())
                {
                    gmdlMeshData.Flags |= 1;
                }

                if (msg.ReadBool())
                {
                    gmdlMeshData.Flags |= 2;
                }

                gmdlMeshData.LodNear = msg.ReadFloat();
                gmdlMeshData.LodFar = msg.ReadFloat();
                gmdlMeshData.LodFade = msg.ReadFloat();

                if (gmdlMeshData.LodNear < gmdlMeshData.LodFar && (gmdlMeshData.LodNear > 0.0 || gmdlMeshData.LodFar < 3.4028235e38))
                {
                    gmdlMeshData.Flags |= 4u;
                }

                if (gmdlMeshData.LodFade > 0.0)
                {
                    gmdlMeshData.Flags |= 0x100u;
                }
            }

            if (msg.Version >= 20140814)
            {
                msg.ReadBool();
            }

            if (msg.Version >= 20141112 && msg.ReadBool())
            {
                gmdlMeshData.Flags |= 0x10u;
            }

            if (msg.Version >= 20140815)
            {
                gmdlMeshData.PartsId = msg.ReadUint();
            }

            if (msg.Version >= 20141115)
            {
                var gmdlMeshPartsDataCount = msg.ReadInt();
                for (var _ = 0; _ < gmdlMeshPartsDataCount; _++)
                {
                    var gmdlMeshPartData = GmdlMeshPartsData.Unpack(msg);
                    gmdlMeshData.GmdlMeshPartsDatas.Add(gmdlMeshPartData);
                }
            }

            if (msg.Version >= 20150413 && msg.ReadBool())
            {
                gmdlMeshData.Flags |= 0x20u;
            }

            if (msg.Version >= 20150430)
            {
                var flag = msg.ReadUint();
                if (msg.Version < 20151217)
                {
                    gmdlMeshData.Flags |= 0x200u;
                    if (boneIdTable.BoneIds.Count == 0)
                    {
                        gmdlMeshData.Flags |= 0x400u;
                    }
                }

                gmdlMeshData.Flags |= flag;
            }

            if (msg.Version >= 20150512 && msg.ReadBool())
            {
                gmdlMeshData.Flags |= 0x80u;
            }

            if (msg.Version < 20160420)
            {
                gmdlMeshData.BreakableBoneIndex = 0xFFFFFFFF;
                gmdlMeshData.LowLodShadowCascadeNo = 2;
            }
            else
            {
                gmdlMeshData.BreakableBoneIndex = msg.ReadUint();
                gmdlMeshData.LowLodShadowCascadeNo = (sbyte)msg.ReadUint();
            }

            gmdlMeshData.VertexLayoutType = vertexLayoutType;
            if ((gmdlMeshData.Flags & 0x80000) != 0)
            {
                var unk0 = msg.ReadBool();
                var unk1 = msg.ReadUint();
                var unk2 = msg.ReadUint();
            }

            // TODO SetupMeshLod

            return mesh;
        }

        private void Setup(LmGeometry geometry)
        {
            // Create index buffer
            var indexBufferDescription = new IndexBufferDesc(geometry.IdxBufferSize, geometry.IdxType);
            this.IndexBuffer = new IndexBuffer(geometry.IdxBuffer, indexBufferDescription);

            // Create vertex buffers
            this.VertexCount = geometry.VtxNum;
            this.TotalTriangleCount = geometry.IdxNum / 3;
            this.TriangleCount = this.VertexCount;

            var meshVertexDeclaration = new MeshVertexDeclaration();
            var readFunctions = MakeReadFunctions();
            for (byte i = 0; i < geometry.VtxStreamGroupDesc.VtxStreamDescs.Count; i++)
            {
                var vtxStreamDesc = geometry.VtxStreamGroupDesc.VtxStreamDescs[i];
                var structuredVBDesc = vtxStreamDesc.StructuredVBDesc;
                var vtxBufferDesc = new VertexBufferDesc(structuredVBDesc.Stride * this.VertexCount);

                // Ugly hack
                var vtxBuffer = new VertexBuffer(null, vtxBufferDesc); // new VertexBuffer(new ArraySegment<byte>(geometry.VtxBuffer, (int)structuredVBDesc.StartOffset, (int)vtxBufferDesc.Size), vtxBufferDesc);
                this.VertexBuffers.Add(vtxBuffer);

                if (i >= 8)
                {
                    DefaultPrintFunction.Write("i<EBONY_COUNTOF(this->bufferStrides)");
                }

                // Add vertex elements
                foreach(var vtxElementDesc in structuredVBDesc.VtxElementDescs)
                {
                    var usage = LmVertexElementDesc.GetUsageFromSemantic(vtxElementDesc.Semantic);
                    var size = LmVertexElementDesc.FormatToVertexComponentCount(vtxElementDesc.Format);
                    var type = LmVertexElementDesc.FormatToVertexType(vtxElementDesc.Format);
                    var vertexElement = new VertexElement(i, type, usage, 0, (ushort)vtxElementDesc.Offset, (ushort)size, vtxElementDesc.Semantic, 0);

                    meshVertexDeclaration.AddVertexElement(vertexElement, vtxBuffer);
                }

                // Parse vertex buffer
                //var vertexElementArrays = new Dictionary<string, IList>();
                foreach (var vtxElementDesc in structuredVBDesc.VtxElementDescs)
                {
                    var values = CreateVertexElementArray(vtxElementDesc.Format);
                    VertexElementArrays.Add(vtxElementDesc.Semantic, values);
                }

                var vertexBufferPosition = (int)structuredVBDesc.StartOffset;
                for (var j = 0; j < vtxBufferDesc.Size / structuredVBDesc.Stride; j++)
                {
                    foreach (var vtxElementDesc in structuredVBDesc.VtxElementDescs)
                    {
                        var readFunction = readFunctions[vtxElementDesc.Format];
                        var size = LmVertexElementDesc.FormatToVertexComponentCount(vtxElementDesc.Format);
                        for(var _ = 0; _ < size; _++)
                        {
                            var value = readFunction(geometry.VtxBuffer, vertexBufferPosition, out int componentSize);
                            VertexElementArrays[vtxElementDesc.Semantic].Add(value);
                            vertexBufferPosition += componentSize;
                        }
                    }
                }

                this.MainStreamSet = meshVertexDeclaration;
                this.BoneInstanceCount = geometry.InstanceNum;

                if (this.BoneInstanceCount != 0)
                {
                    // TODO instance buffer
                }
            }
        }

        private delegate object ReadVertexElementComponent(byte[] buffer, int bufferOffset, out int size);

        private static Dictionary<LmEVertexElementFormat, ReadVertexElementComponent> MakeReadFunctions()
        {
            var result = new Dictionary<LmEVertexElementFormat, ReadVertexElementComponent>
            {
                { LmEVertexElementFormat.X8_Uint, ReadUInt8 },
                { LmEVertexElementFormat.XYZW8_Uint, ReadUInt8 },
                { LmEVertexElementFormat.X8_Sint, ReadInt8 },
                { LmEVertexElementFormat.XYZW8_Sint, ReadInt8 },

                { LmEVertexElementFormat.X8_UintN, ReadUIntN8 },
                { LmEVertexElementFormat.XYZW8_UintN, ReadUIntN8 },
                { LmEVertexElementFormat.X8_SintN, ReadIntN8 },
                { LmEVertexElementFormat.XYZW8_SintN, ReadIntN8 },

                { LmEVertexElementFormat.X16_Sint, ReadInt16 },
                { LmEVertexElementFormat.XY16_Sint, ReadInt16 },
                { LmEVertexElementFormat.XYZW16_Sint, ReadInt16 },

                { LmEVertexElementFormat.X16_Uint, ReadUInt16 },
                { LmEVertexElementFormat.XY16_Uint, ReadUInt16 },
                { LmEVertexElementFormat.XYZW16_Uint, ReadUInt16 },

                { LmEVertexElementFormat.X16_SintN, ReadIntN16 },
                { LmEVertexElementFormat.XY16_SintN, ReadIntN16 },
                { LmEVertexElementFormat.XYZW16_SintN, ReadIntN16 },

                { LmEVertexElementFormat.X16_UintN, ReadUIntN16 },
                { LmEVertexElementFormat.XY16_UintN, ReadUIntN16 },
                { LmEVertexElementFormat.XYZW16_UintN, ReadUIntN16 },

                { LmEVertexElementFormat.X32_Sint, ReadInt32 },
                { LmEVertexElementFormat.XY32_Sint, ReadInt32 },
                { LmEVertexElementFormat.XYZ32_Sint, ReadInt32 },
                { LmEVertexElementFormat.XYZW32_Sint, ReadInt32 },

                { LmEVertexElementFormat.X32_Uint, ReadUInt32 },
                { LmEVertexElementFormat.XY32_Uint, ReadUInt32 },
                { LmEVertexElementFormat.XYZ32_Uint, ReadUInt32 },
                { LmEVertexElementFormat.XYZW32_Uint, ReadUInt32 },

                { LmEVertexElementFormat.X32_SintN, ReadIntN32 },
                { LmEVertexElementFormat.XY32_SintN, ReadIntN32 },
                { LmEVertexElementFormat.XYZ32_SintN, ReadIntN32 },
                { LmEVertexElementFormat.XYZW32_SintN, ReadIntN32 },

                { LmEVertexElementFormat.X32_UintN, ReadUIntN32 },
                { LmEVertexElementFormat.XY32_UintN, ReadUIntN32 },
                { LmEVertexElementFormat.XYZ32_UintN, ReadUIntN32 },
                { LmEVertexElementFormat.XYZW32_UintN, ReadUIntN32 },

                { LmEVertexElementFormat.X16_Float, ReadFloat16 },
                { LmEVertexElementFormat.XY16_Float, ReadFloat16 },
                { LmEVertexElementFormat.XYZW16_Float, ReadFloat16 },

                { LmEVertexElementFormat.X32_Float, ReadFloat32 },
                { LmEVertexElementFormat.XY32_Float, ReadFloat32 },
                { LmEVertexElementFormat.XYZ32_Float, ReadFloat32 },
                { LmEVertexElementFormat.XYZW32_Float, ReadFloat32 },
            };
            return result;
        }

        private static object ReadFloat32(byte[] buffer, int bufferOffset, out int size)
        {
            var value = BitConverter.ToSingle(buffer, bufferOffset);
            size = sizeof(float);
            return value;
        }

        private static object ReadFloat16(byte[] buffer, int bufferOffset, out int size)
        {
            var value = (float)Half.ToHalf(buffer, bufferOffset);
            size = 2;
            return value;
        }

        private static object ReadUIntN32(byte[] buffer, int bufferOffset, out int size)
        {
            var value = BitConverter.ToInt32(buffer, bufferOffset);
            size = sizeof(uint);
            return value;
        }

        private static object ReadInt32(byte[] buffer, int bufferOffset, out int size)
        {
            var value = BitConverter.ToUInt32(buffer, bufferOffset);
            size = sizeof(uint);
            return value;
        }

        private static object ReadIntN32(byte[] buffer, int bufferOffset, out int size)
        {
            var value = BitConverter.ToInt32(buffer, bufferOffset);
            size = sizeof(uint);
            return value;
        }

        private static object ReadUInt32(byte[] buffer, int bufferOffset, out int size)
        {
            var value = BitConverter.ToUInt32(buffer, bufferOffset);
            size = sizeof(uint);
            return value;
        }

        private static object ReadUInt16(byte[] buffer, int bufferOffset, out int size)
        {
            var value = BitConverter.ToUInt16(buffer, bufferOffset);
            size = sizeof(ushort);
            return value;
        }

        private static object ReadUIntN16(byte[] buffer, int bufferOffset, out int size)
        {
            var value = BitConverter.ToUInt16(buffer, bufferOffset);
            size = sizeof(ushort);
            return value;
        }

        private static object ReadInt16(byte[] buffer, int bufferOffset, out int size)
        {
            var value = BitConverter.ToInt16(buffer, bufferOffset);
            size = sizeof(ushort);
            return value;
        }

        private static object ReadIntN16(byte[] buffer, int bufferOffset, out int size)
        {
            var value = BitConverter.ToInt16(buffer, bufferOffset);
            size = sizeof(ushort);
            return value;
        }

        private static object ReadUInt8(byte[] buffer, int bufferOffset, out int size)
        {
            var value = buffer[bufferOffset];
            size = sizeof(byte);
            return value;
        }

        private static object ReadUIntN8(byte[] buffer, int bufferOffset, out int size)
        {
            var value = buffer[bufferOffset];
            size = sizeof(byte);
            return value;
        }

        private static object ReadInt8(byte[] buffer, int bufferOffset, out int size)
        {
            var value = unchecked((sbyte)buffer[bufferOffset]);
            size = sizeof(byte);
            return value;
        }

        private static object ReadIntN8(byte[] buffer, int bufferOffset, out int size)
        {
            var value = unchecked((sbyte)buffer[bufferOffset]);
            size = sizeof(byte);
            return value;
        }

        private static IList CreateVertexElementArray(LmEVertexElementFormat format)
        {
            switch (format)
            {
                case LmEVertexElementFormat.Disable:
                    Debug.Fail("Unrecognized vertex element format");
                    return null;
                case LmEVertexElementFormat.XYZW32_Float:
                    return new List<float>();
                case LmEVertexElementFormat.XYZW32_UintN:
                    return new List<uint>();
                case LmEVertexElementFormat.XYZW32_Uint:
                    return new List<uint>();
                case LmEVertexElementFormat.XYZW32_SintN:
                    return new List<int>();
                case LmEVertexElementFormat.XYZW32_Sint:
                    return new List<int>();
                case LmEVertexElementFormat.XYZW16_Float:
                    return new List<float>();
                case LmEVertexElementFormat.XYZW16_UintN:
                    return new List<ushort>();
                case LmEVertexElementFormat.XYZW16_Uint:
                    return new List<ushort>();
                case LmEVertexElementFormat.XYZW16_SintN:
                    return new List<short>();
                case LmEVertexElementFormat.XYZW16_Sint:
                    return new List<short>();
                case LmEVertexElementFormat.XYZW8_Float:
                    return new List<float>();
                case LmEVertexElementFormat.XYZW8_UintN:
                    return new List<byte>();
                case LmEVertexElementFormat.XYZW8_Uint:
                    return new List<byte>();
                case LmEVertexElementFormat.XYZW8_SintN:
                    return new List<sbyte>();
                case LmEVertexElementFormat.XYZW8_Sint:
                    return new List<sbyte>();
                case LmEVertexElementFormat.XYZ32_Float:
                    return new List<float>();
                case LmEVertexElementFormat.XYZ32_UintN:
                    return new List<uint>();
                case LmEVertexElementFormat.XYZ32_Uint:
                    return new List<uint>();
                case LmEVertexElementFormat.XYZ32_SintN:
                    return new List<int>();
                case LmEVertexElementFormat.XYZ32_Sint:
                    return new List<int>();
                case LmEVertexElementFormat.XY32_Float:
                    return new List<float>();
                case LmEVertexElementFormat.XY32_UintN:
                    return new List<uint>();
                case LmEVertexElementFormat.XY32_Uint:
                    return new List<uint>();
                case LmEVertexElementFormat.XY32_SintN:
                    return new List<int>();
                case LmEVertexElementFormat.XY32_Sint:
                    return new List<int>();
                case LmEVertexElementFormat.XY16_Float:
                    return new List<float>();
                case LmEVertexElementFormat.XY16_UintN:
                    return new List<ushort>();
                case LmEVertexElementFormat.XY16_Uint:
                    return new List<ushort>();
                case LmEVertexElementFormat.XY16_SintN:
                    return new List<short>();
                case LmEVertexElementFormat.XY16_Sint:
                    return new List<short>();
                case LmEVertexElementFormat.X32_Float:
                    return new List<float>();
                case LmEVertexElementFormat.X32_UintN:
                    return new List<uint>();
                case LmEVertexElementFormat.X32_Uint:
                    return new List<uint>();
                case LmEVertexElementFormat.X32_SintN:
                    return new List<int>();
                case LmEVertexElementFormat.X32_Sint:
                    return new List<int>();
                case LmEVertexElementFormat.X16_Float:
                    return new List<float>();
                case LmEVertexElementFormat.X16_UintN:
                    return new List<ushort>();
                case LmEVertexElementFormat.X16_Uint:
                    return new List<ushort>();
                case LmEVertexElementFormat.X16_SintN:
                    return new List<short>();
                case LmEVertexElementFormat.X16_Sint:
                    return new List<short>();
                case LmEVertexElementFormat.X8_Float:
                    return new List<float>();
                case LmEVertexElementFormat.X8_UintN:
                    return new List<byte>();
                case LmEVertexElementFormat.X8_Uint:
                    return new List<byte>();
                case LmEVertexElementFormat.X8_SintN:
                    return new List<sbyte>();
                case LmEVertexElementFormat.X8_Sint:
                    return new List<sbyte>();
                case LmEVertexElementFormat.Num:
                    Debug.Fail("Unsupported vertex element format");
                    return null;
                default:
                    return null;
            }
        }
    }
}
