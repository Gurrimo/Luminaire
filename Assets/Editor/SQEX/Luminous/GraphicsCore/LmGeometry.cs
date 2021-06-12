using SQEX.Luminous.GraphicsLoad;
using SQEX.Luminous.Math;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SQEX.Luminous.GraphicsCore
{
    public enum LmEPrimitiveType
    {
          PrimitiveTypePointList = 0x0,
          PrimitiveTypeLineList = 0x1,
          PrimitiveTypeLineStrip = 0x2,
          PrimitiveTypeTriangleList = 0x3,
          PrimitiveTypeTriangleStrip = 0x4,
          PrimitiveTypeLineListADJ = 0x5,
          PrimitiveTypeLineStripADJ = 0x6,
          PrimitiveTypeTriangleListADJ = 0x7,
          PrimitiveTypeTriangleStripADJ = 0x8,
          PrimitiveType1_ControlPointPatchList = 0x9,
          PrimitiveType2_ControlPointPatchList = 0xA,
          PrimitiveType3_ControlPointPatchList = 0xB,
          PrimitiveType4_ControlPointPatchList = 0xC,
          PrimitiveType5_ControlPointPatchList = 0xD,
          PrimitiveType6_ControlPointPatchList = 0xE,
          PrimitiveType7_ControlPointPatchList = 0xF,
          PrimitiveType8_ControlPointPatchList = 0x10,
          PrimitiveType9_ControlPointPatchList = 0x11,
          PrimitiveType10_ControlPointPatchList = 0x12,
          PrimitiveType11_ControlPointPatchList = 0x13,
          PrimitiveType12_ControlPointPatchList = 0x14,
          PrimitiveType13_ControlPointPatchList = 0x15,
          PrimitiveType14_ControlPointPatchList = 0x16,
          PrimitiveType15_ControlPointPatchList = 0x17,
          PrimitiveType16_ControlPointPatchList = 0x18,
          PrimitiveType17_ControlPointPatchList = 0x19,
          PrimitiveType18_ControlPointPatchList = 0x1A,
          PrimitiveType19_ControlPointPatchList = 0x1B,
          PrimitiveType20_ControlPointPatchList = 0x1C,
          PrimitiveType21_ControlPointPatchList = 0x1D,
          PrimitiveType22_ControlPointPatchList = 0x1E,
          PrimitiveType23_ControlPointPatchList = 0x1F,
          PrimitiveType24_ControlPointPatchList = 0x20,
          PrimitiveType25_ControlPointPatchList = 0x21,
          PrimitiveType26_ControlPointPatchList = 0x22,
          PrimitiveType27_ControlPointPatchList = 0x23,
          PrimitiveType28_ControlPointPatchList = 0x24,
          PrimitiveType29_ControlPointPatchList = 0x25,
          PrimitiveType30_ControlPointPatchList = 0x26,
          PrimitiveType31_ControlPointPatchList = 0x27,
          PrimitiveType32_ControlPointPatchList = 0x28,
          PrimitiveTypeNum = 0x29,
    }

    public enum LmEIndexType
    {
        IndexType16 = 0x0,
        IndexType32 = 0x1,
        IndexTypeNum = 0x2,
    }

    public class LmGeometry
    {
        public LmAABB AABB { get; private set; }
        public LmOrientedBB OBB { get; private set; }
        public LmEPrimitiveType PrimType { get; private set; }
        public uint IdxNum { get; private set; }
        public LmEIndexType IdxType { get; private set; }
        public int[] IdxBuffer { get; private set; }
        public uint IdxBufferSize { get; private set; }
        public uint VtxNum { get; private set; }
        public LmVertexStreamGroupDesc VtxStreamGroupDesc { get; private set; }
        public byte[] VtxBuffer { get; private set; }
        public uint VtxBufferSize { get; private set; }
        public uint InstanceNum { get; private set; }
        public IReadOnlyList<byte> InstanceBuffer { get; private set; }
        public IList<LmSubGeometry> SubGeometries { get; } = new List<LmSubGeometry>();
        public static LmGeometry Unpack(LmMsgPck msg)
        {
            // Probably an unnecessary isOBB check
            var bValue1 = msg.Read();
            var geometry = new LmGeometry
            {
                AABB = LmAABB.Unpack(msg)
            };

            if (msg.Version >= 20160705)
            {
                var isOBB = (bool)msg.Read();
                Debug.Assert(isOBB);

                geometry.OBB = LmOrientedBB.Unpack(msg);
            }

            geometry.PrimType = (LmEPrimitiveType)msg.ReadByte();
            geometry.IdxNum = msg.ReadUint();
            geometry.IdxType = (LmEIndexType)msg.ReadByte();

            if (msg.Version < 20141113)
            {
                Debug.Fail("Unsupported version");
            }

            var idxBufferOffset = msg.ReadUint();
            geometry.IdxBufferSize = msg.ReadUint();
            geometry.IdxBuffer = new int[geometry.IdxNum];

            for(var i = 0; i < geometry.IdxNum; i++)
            {
                if (geometry.IdxType == LmEIndexType.IndexType32)
                {
                    geometry.IdxBuffer[i] = BitConverter.ToInt32(msg.UserData.GpuBuffer, (int)idxBufferOffset + (4 * i));
                }
                else if (geometry.IdxType == LmEIndexType.IndexType16)
                {
                    geometry.IdxBuffer[i] = BitConverter.ToInt16(msg.UserData.GpuBuffer, (int)idxBufferOffset + (2 * i));
                }
                else
                {
                    Debug.Fail("Unsupported index type");
                }
            }

            geometry.VtxNum = msg.ReadUint();
            geometry.VtxStreamGroupDesc = LmVertexStreamGroupDesc.Unpack(msg);

            var vtxBufferOffset = msg.ReadUint();
            geometry.VtxBufferSize = msg.ReadUint();

            geometry.VtxBuffer = new byte[geometry.VtxBufferSize];
            Array.Copy(msg.UserData.GpuBuffer, (int)vtxBufferOffset, geometry.VtxBuffer, 0, (int)geometry.VtxBufferSize);

            if (msg.Version < 20150413)
            {
                geometry.InstanceNum = 0;
            }
            else
            {
                geometry.InstanceNum = msg.ReadUint();
                //var instanceNumOffset = msg.ReadUint();
                //var unknown = (float)msg.Read();
                //geometry.InstanceBuffer = new ArraySegment<byte>(msg.UserData.GpuBuffer, (int)instanceNumOffset, (int)unknown);
            }

            // TODO subgeometries
            var subgeometryCount = msg.ReadUint();
            for(var _ = 0; _ < subgeometryCount; _++)
            {
                geometry.SubGeometries.Add(LmSubGeometry.Unpack(msg));
            }

            return geometry;
        }
    }
}
