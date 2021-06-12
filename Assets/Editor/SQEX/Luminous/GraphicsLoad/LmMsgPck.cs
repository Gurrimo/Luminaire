using System;
using System.Diagnostics;
using System.Text;

namespace SQEX.Luminous.GraphicsLoad
{
    public class LmMsgPck
    {
        private byte[] ReadData { get; }
        private int ReadDataSize { get; }
        private int Position { get; set; }
        public LmGfxBinUnpackContext UserData { get; }

        public uint Version => UserData.Header.Version;

        public enum LmPackFormat
        {
            PositiveFixIntStart = 0x0,
            PositiveFixIntEnd = 0x7F,
            FixMapStart = 0x80,
            FixMapEnd = 0x8F,
            FixArrayStart = 0x90,
            FixArrayEnd = 0x9F,
            FixStrStart = 0xA0,
            FixStrEnd = 0xBF,
            Nil = 0xC0,
            NeverUsed = 0xC1,
            False = 0xC2,
            True = 0xC3,
            Bin8 = 0xC4,
            Bin16 = 0xC5,
            Bin32 = 0xC6,
            Ext8 = 0xC7,
            Ext16 = 0xC8,
            Ext32 = 0xC9,
            Float32 = 0xCA,
            Float64 = 0xCB,
            Uint8 = 0xCC,
            Uint16 = 0xCD,
            Uint32 = 0xCE,
            Uint64 = 0xCF,
            Int8 = 0xD0,
            Int16 = 0xD1,
            Int32 = 0xD2,
            Int64 = 0xD3,
            FixExt1 = 0xD4,
            FixExt2 = 0xD5,
            FixExt4 = 0xD6,
            FixExt8 = 0xD7,
            FixExt16 = 0xD8,
            Str8 = 0xD9,
            Str16 = 0xDA,
            Str32 = 0xDB,
            Array16 = 0xDC,
            Array32 = 0xDD,
            Map16 = 0xDE,
            Map32 = 0xDF,
            NegativeFixIntStart = 0xE0,
            NegativeFixIntEnd = 0xFF,
        }

        public LmMsgPck(byte[] readData, LmGfxBinUnpackContext userData)
        {
            this.ReadData = readData;
            this.ReadDataSize = readData.Length;
            this.UserData = userData;
        }

        public void Rewind()
        {
            this.Position = 0;
        }

        public bool UnpackBlob(out byte[] data, out uint size)
        {
            if (UnpackNil())
            {
                data = null;
                size = 0;
                return true;
            }
            else if (UnpackBin8(LmPackFormat.Bin8, out data, out size))
            {
                return true;
            }
            else if (UnpackBin16(LmPackFormat.Bin16, out data, out size))
            {
                return true;
            }
            else
            {
                return UnpackString(LmPackFormat.Bin32, out data, out size);
            }
        }

        private bool UnpackBin8(LmPackFormat format, out byte[] data, out uint size)
        {
            if (this.ReadData[this.Position] != (byte)format)
            {
                data = default;
                size = 0;
                return false;
            }

            this.Position++;
            size = this.ReadData[this.Position];
            this.Position++;

            data = new byte[(int)size];
            Array.Copy(this.ReadData, this.Position, data, 0, (int)size);
            this.Position += (int)size;

            return true;
        }

        private bool UnpackBin16(LmPackFormat format, out byte[] data, out uint size)
        {
            if (this.ReadData[this.Position] != (byte)format)
            {
                data = default;
                size = 0;
                return false;
            }

            this.Position++;
            size = BitConverter.ToUInt16(this.ReadData, this.Position);
            this.Position += 2;

            data = new byte[(int)size];
            Array.Copy(this.ReadData, this.Position, data, 0, (int)size);
            this.Position += (int)size;

            return true;
        }

        private bool UnpackString(LmPackFormat format, out byte[] data, out uint size)
        {
            if (this.ReadData[this.Position] != (byte)format)
            {
                data = default;
                size = 0;
                return false;
            }

            this.Position++;
            size = BitConverter.ToUInt32(this.ReadData, this.Position);
            this.Position += 4;

            data = new byte[(int)size];
            Array.Copy(this.ReadData, this.Position, data, 0, (int)size);
            this.Position += (int)size;

            return true;
        }

        public bool UnpackFloat32(out float value)
        {
            if (this.ReadData[this.Position] != (byte)LmPackFormat.Float32)
            {
                value = default;
                return false;
            }

            this.Position++;
            value = BitConverter.ToSingle(this.ReadData, this.Position);
            this.Position += sizeof(float);

            return true;
        }

        public bool UnpackUInt64(out ulong value)
        {
            if (this.UnpackUInt16(out ushort ushortValue))
            {
                value = ushortValue;
                return true;
            }

            if (this.ReadData[this.Position] != (byte)LmPackFormat.Uint32)
            {
                return UnpackPrimitiveUInt64(LmPackFormat.Uint64, out value);
            }

            this.Position++;
            value = BitConverter.ToUInt32(this.ReadData, this.Position);
            this.Position += 4;
            return true;
        }

        public bool UnpackUInt32(out uint value)
        {
            if (this.UnpackUInt16(out ushort ushortValue))
            {
                value = (uint)ushortValue;
                return true;
            }

            return UnpackContainerUInt32(LmPackFormat.Uint32, out value);
        }

        public bool UnpackUInt16(out ushort value)
        {
            var val = this.ReadData[this.Position];
            if (this.ReadData[this.Position] > (byte)LmPackFormat.PositiveFixIntEnd)
            {
                if (UnpackPrimitiveUInt8(LmPackFormat.Uint8, out byte byteValue))
                {
                    value = (ushort)byteValue;
                    return true;
                }
                else
                {
                    return UnpackContainerUInt16(LmPackFormat.Uint16, out value);
                }
            }
            else
            {
                value = this.ReadData[this.Position];
                this.Position++;
                return true;
            }
        }


        public bool UnpackInt8(out sbyte value)
        {
            if (this.UnpackNegativeFixNum(out value))
            {
                return true;
            }

            if (this.ReadData[this.Position] > (byte)LmPackFormat.PositiveFixIntEnd)
            {
                return UnpackPrimitiveInt8(LmPackFormat.Int8, out value);
            }

            value = unchecked((sbyte)this.ReadData[this.Position]);
            this.Position++;
            return true;
        }

        private bool UnpackContainerUInt32(LmPackFormat format, out uint value)
        {
            if (this.ReadData[this.Position] != (byte)format)
            {
                value = default;
                return false;
            }

            this.Position++;
            value = BitConverter.ToUInt32(this.ReadData, this.Position);
            this.Position += sizeof(uint);

            return true;
        }

        private bool UnpackContainerUInt16(LmPackFormat format, out ushort value)
        {
            if (this.ReadData[this.Position] != (byte)format)
            {
                value = default;
                return false;
            }

            this.Position++;
            value = BitConverter.ToUInt16(this.ReadData, this.Position);
            this.Position += sizeof(ushort);

            return true;
        }

        private bool UnpackPrimitiveUInt64(LmPackFormat format, out ulong value)
        {
            if (this.ReadData[this.Position] != (byte)format)
            {
                value = default;
                return false;
            }

            this.Position++;
            value = BitConverter.ToUInt64(this.ReadData, this.Position);
            this.Position += 8;

            return true;
        }

        private bool UnpackPrimitiveUInt8(LmPackFormat format, out byte value)
        {
            if (this.ReadData[this.Position] != (byte)format)
            {
                value = default;
                return false;
            }

            this.Position++;
            value = this.ReadData[this.Position];
            this.Position++;

            return true;
        }

        private bool UnpackPrimitiveInt8(LmPackFormat format, out sbyte value)
        {
            if (this.ReadData[this.Position] != (byte)format)
            {
                value = default;
                return false;
            }

            this.Position++;
            value = unchecked((sbyte)this.ReadData[this.Position]);
            this.Position++;

            return true;
        }

        private bool UnpackNegativeFixNum(out sbyte value)
        {
            if (this.ReadData[this.Position] < (byte)LmPackFormat.NegativeFixIntStart)
            {
                value = default;
                return false;
            }

            value = unchecked((sbyte)this.ReadData[this.Position]);
            this.Position++;

            return true;
        }
               
        private bool UnpackNil()
        {
            if (this.ReadData[this.Position] != (byte)LmPackFormat.Nil)
            {
                return false;
            }

            this.Position++;
            return true;
        }


        public object Read()
        {
            object result = 0;
            var val = this.ReadData[this.Position];

            int size = 1;
            switch((LmPackFormat)(val))
            {
                case LmPackFormat.Uint64:
                    result = BitConverter.ToUInt64(this.ReadData, this.Position + 1);
                    size += sizeof(ulong);
                    break;
                case LmPackFormat.Uint32:
                    result = BitConverter.ToUInt32(this.ReadData, this.Position + 1);
                    size += sizeof(uint);
                    break;
                case LmPackFormat.Uint16:
                    result = BitConverter.ToUInt16(this.ReadData, this.Position + 1);
                    size += sizeof(ushort);
                    break;
                case LmPackFormat.Uint8:
                    result = this.ReadData[this.Position + 1];
                    size += sizeof(byte);
                    break;
                case LmPackFormat.Float32:
                    result = BitConverter.ToSingle(this.ReadData, this.Position + 1);
                    size += sizeof(float);
                    break;
                case LmPackFormat.Map16:
                case LmPackFormat.Array16:
                    result = BitConverter.ToUInt16(this.ReadData, this.Position + 1);
                    size += sizeof(ushort);
                    break;
                case LmPackFormat.True:
                    result = true;
                    break;
                case LmPackFormat.False:
                    result = false;
                    break;
                default:
                    result = val;
                    if (((byte)result & 0xF0) >> 4 == 9)
                    {
                        result = (byte)result & 0xF;
                    }

                    break;
            }

            this.Position += size;
            return result;
        }

        public uint ReadUint()
        {
            var rawValue = this.Read();
            if (rawValue is uint)
            {
                return (uint)rawValue;
            }
            else if (rawValue is int)
            {
                return (uint)(int)rawValue;
            }
            else if (rawValue is ushort)
            {
                return (uint)(ushort)rawValue;
            }
            else if (rawValue is short)
            {
                return (uint)(short)rawValue;
            }
            else if (rawValue is byte)
            {
                return (uint)(byte)rawValue;
            }

            return (uint)rawValue;
        }

        public int ReadInt()
        {
            var rawValue = this.Read();
            if (rawValue is int)
            {
                return (int)rawValue;
            }
            else if (rawValue is uint)
            {
                return (int)(uint)rawValue;
            }
            else if (rawValue is short)
            {
                return (short)rawValue;
            }
            else if (rawValue is ushort)
            {
                return (short)(ushort)rawValue;
            }
            else if (rawValue is byte)
            {
                return (short)(byte)rawValue;
            }

            return (short)rawValue;
        }

        public ushort ReadUInt16()
        {
            var rawValue = this.Read();
            if (rawValue is short)
            {
                return (ushort)rawValue;
            }
            else if (rawValue is ushort)
            {
                return (ushort)rawValue;
            }
            else if (rawValue is byte)
            {
                return (ushort)(byte)rawValue;
            }

            return (ushort)rawValue;
        }

        public ulong ReadUint64()
        {
            var rawValue = this.Read();
            if (rawValue is ulong x)
            {
                return x;
            }
            else if (rawValue is long x2)
            {
                return (uint)x2;
            }

            return (ulong)rawValue;
        }

        public bool ReadBool()
        {
            var rawValue = this.Read();
            return (bool)rawValue;
        }

        public float ReadFloat()
        {
            var rawValue = this.Read();
            return (float)rawValue;
        }

        public uint ReadMapCount()
        {
            var rawValue = this.ReadByte();
            uint result = rawValue & 111u;

            var size = 0;
            if (rawValue == (byte)LmPackFormat.Map16)
            {
                result = (uint)BitConverter.ToUInt16(this.ReadData, this.Position);
                size += sizeof(ushort);
            }
            else if (rawValue == (byte)LmPackFormat.Map32)
            {
                result = BitConverter.ToUInt32(this.ReadData, this.Position);
                size += sizeof(uint);
            }

            this.Position += size;
            return result;
        }

        public bool UnpackArraySize(out int size)
        {
            var format = this.ReadByte();
            if (format == (byte)LmPackFormat.Array16)
            {
                size = BitConverter.ToUInt16(this.ReadData, this.Position);
                this.Position += sizeof(ushort);
                return true;
            }
            else if (format == (byte)LmPackFormat.Array32)
            {
                size = (int)BitConverter.ToUInt32(this.ReadData, this.Position);
                this.Position += sizeof(uint);
                return true;
            }

            size = format & 111;
            return true;
        }

        public string ReadString()
        {
            var format = this.ReadData[this.Position];
            var length = (int)format;
            if (format < 0xA0 || format > 0xBf)
            {
                if ((LmPackFormat)format == LmPackFormat.Str8)
                {
                    this.Position++;
                    length = this.ReadData[this.Position];
                    this.Position++;
                }
                else if ((LmPackFormat)format == LmPackFormat.Str16)
                {
                    this.Position++;
                    length = this.ReadData[this.Position];
                    this.Position++;
                }
                else if ((LmPackFormat)format == LmPackFormat.Str32)
                {
                    this.Position++;
                    length = this.ReadData[this.Position];
                    this.Position++;
                }
            }
            else
            {
                length = format & 95;
                this.Position++;
            }

            //var length = this.ReadData[this.Position] & 95;
            if (length == 0)
            {
                //this.Position++;
                return string.Empty;
            }

            var result = Encoding.ASCII.GetString(this.ReadData, this.Position, length - 1);

            this.Position += length;
            return result;
        }

        public string ReadStr8()
        {
            var pathFormat = (LmPackFormat)(byte)this.Read();
            Debug.Assert(pathFormat == LmPackFormat.Str8);
            var length = this.ReadData[this.Position];
            var result = Encoding.ASCII.GetString(this.ReadData, this.Position + 1, length - 1);

            this.Position += length + 1;
            return result;
        }

        public byte ReadByte()
        {
            var result = this.ReadData[this.Position];
            this.Position++;
            return result;
        }

        public void Skip(int bytes)
        {
            this.Position += bytes;
        }
    }
}
