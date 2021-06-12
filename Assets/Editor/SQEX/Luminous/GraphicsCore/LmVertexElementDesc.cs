using SQEX.Luminous.GraphicsLoad;
using System.Diagnostics;

namespace SQEX.Luminous.GraphicsCore
{
    public enum LmEVertexElementFormat
    {
        Disable = 0x0,
        XYZW32_Float = 0x1,
        XYZW32_UintN = 0x2,
        XYZW32_Uint = 0x3,
        XYZW32_SintN = 0x4,
        XYZW32_Sint = 0x5,
        XYZW16_Float = 0x6,
        XYZW16_UintN = 0x7,
        XYZW16_Uint = 0x8,
        XYZW16_SintN = 0x9,
        XYZW16_Sint = 0xA,
        XYZW8_Float = 0xB,
        XYZW8_UintN = 0xC,
        XYZW8_Uint = 0xD,
        XYZW8_SintN = 0xE,
        XYZW8_Sint = 0xF,
        XYZ32_Float = 0x10,
        XYZ32_UintN = 0x11,
        XYZ32_Uint = 0x12,
        XYZ32_SintN = 0x13,
        XYZ32_Sint = 0x14,
        XY32_Float = 0x15,
        XY32_UintN = 0x16,
        XY32_Uint = 0x17,
        XY32_SintN = 0x18,
        XY32_Sint = 0x19,
        XY16_Float = 0x1A,
        XY16_UintN = 0x1B,
        XY16_Uint = 0x1C,
        XY16_SintN = 0x1D,
        XY16_Sint = 0x1E,
        X32_Float = 0x1F,
        X32_UintN = 0x20,
        X32_Uint = 0x21,
        X32_SintN = 0x22,
        X32_Sint = 0x23,
        X16_Float = 0x24,
        X16_UintN = 0x25,
        X16_Uint = 0x26,
        X16_SintN = 0x27,
        X16_Sint = 0x28,
        X8_Float = 0x29,
        X8_UintN = 0x2A,
        X8_Uint = 0x2B,
        X8_SintN = 0x2C,
        X8_Sint = 0x2D,
        Num = 0x2E,
    }

    [DebuggerDisplay("{Semantic}")]
    public class LmVertexElementDesc
    {
        public uint Offset { get; }
        public string Semantic { get; }
        public LmEVertexElementFormat Format { get; }

        /// <summary>
        /// Maps LmEVertexElementFormat to VertexType
        /// </summary>
        private static readonly byte[] LmToBlackVertexType =
        {
            12,   1,  12,  12,  12,  12,   2,   4,   9,   0,
            12,  12,   3,   6,  10,  12,   1,  12,  12,  12,
            12,   1,  12,  12,  12,  12,   2,  12,   9,   0,
            4,   1,  12,  12,  12,  12,   2,  12,   9,   0,
            4,  12,   3,   6,  10,  12
        };

        /// <summary>
        /// Maps LmEVertexElementFormat to vertex size3
        /// </summary>
        private static readonly uint[] LmToBlackVertexComponentCount =
        {
            0u,
            4u,
            0u,
            0u,
            0u,
            0u,
            4u,
            4u,
            4u,
            4u,
            0u,
            0u,
            4u,
            4u,
            4u,
            0u,
            3u,
            0u,
            0u,
            0u,
            0u,
            2u,
            0u,
            0u,
            0u,
            0u,
            2u,
            0u,
            2u,
            2u,
            2u,
            1u,
            0u,
            0u,
            0u,
            0u,
            1u,
            0u,
            1u,
            1u,
            1u,
            0u,
            1u,
            1u,
            0u,
            0u,
            429065506u,
            4u,
            77171364u,
            0u,
            0u,
            9u,
            77171396u,
            120u,
            0u,
            1u,
            429065506u,
            2u,
            77171580u,
            0u,
            0u,
            4u,
            77171596u,
            32u,
            0u,
            1u,
            429065506u,
            2u,
            77171664u,
            0u,
            0u,
            5u,
            77171680u,
            32u,
            0u,
            1u,
            429065506u,
            2u,
            77171748u,
            0u,
            0u,
            4u,
            77171764u,
            32u,
            0u,
            1u,
            429065506u,
            1u,
            74407332u,
            0u,
            0u,
            3u,
            77172504u,
            32u,
            0u,
            1u,
            429065506u,
            0u,
            0u,
            0u,
            0u,
            1u,
            77172584u,
            32u,
            0u,
            5u,
            429065506u,
            5u,
            75694096u,
            0u,
            0u,
            11u,
            77172624u,
            32u,
            0u,
            1u
        };

        private LmVertexElementDesc(uint offset, string semantic, LmEVertexElementFormat format)
        {
            this.Offset = offset;
            this.Semantic = semantic;
            this.Format = format;
        }

        public static LmVertexElementDesc Unpack(LmMsgPck msg)
        {
            var offset = msg.ReadUint();
            var semantic = msg.ReadString();
            var format = (LmEVertexElementFormat)msg.ReadUint();
            return new LmVertexElementDesc(offset, semantic, format);
        }

        public static byte FormatToVertexType(LmEVertexElementFormat format)
        {
            var formatAsIndex = (int)format;
            return LmToBlackVertexType[formatAsIndex];
        }

        public static uint FormatToVertexComponentCount(LmEVertexElementFormat format)
        {
            var formatAsIndex = (int)format;
            return LmToBlackVertexComponentCount[formatAsIndex];
        }

        public static byte GetUsageFromSemantic(string semanticName)
        {
            switch(semanticName)
            {
                case "POSITION0":
                    return 0;
                case "NORMAL4FACTORS0":
                    return 24;
                case "NORMAL2FACTORS0":
                    return 25;
                case "NORMAL0":
                    return 2;
                case "TANGENT0":
                    return 16;
                case "BINORMAL0":
                    return 17;
                case "TANGENT1":
                    return 20;
                case "BINORMAL1":
                    return 21;
                case "COLOR0":
                    return 3;
                case "COLOR1":
                    return 4;
                case "COLOR2":
                    return 22;
                case "COLOR3":
                    return 23;
                case "FOGCOORD0":
                    return 5;
                case "PSIZE0":
                    return 6;
                case "BLENDWEIGHT0":
                    return 1;
                case "BLENDWEIGHT1":
                    return 18;
                case "BLENDINDICES0":
                    return 7;
                case "BLENDINDICES1":
                    return 19;
                case "TEXCOORD0":
                    return 8;
                case "TEXCOORD1":
                    return 9;
                case "TEXCOORD2":
                    return 2;
                case "TEXCOORD3":
                    return 11;
                case "TEXCOORD4":
                    return 12;
                case "TEXCOORD5":
                    return 13;
                case "TEXCOORD6":
                    return 14;
                case "TEXCOORD7":
                    return 15;
                default:
                    Debug.Fail($"Unrecognized semantic {semanticName}");
                    return 0;
            }
        }
    }
}
