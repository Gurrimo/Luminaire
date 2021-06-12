using SQEX.Luminous.GraphicsLoad;
using System.Diagnostics;

namespace SQEX.Luminous.GraphicsCore
{
    [DebuggerDisplay("{BoneName}")]
    public class LmBoneInfo
    {
        public string BoneName { get; }
        public uint LodBoneIdx { get; }
        public uint UniqueBoneIdx { get; }

        public LmBoneInfo(string boneName, uint lodBoneIdx, uint uniqueBoneIdx)
        {
            this.BoneName = boneName;
            this.LodBoneIdx = lodBoneIdx;
            this.UniqueBoneIdx = uniqueBoneIdx;
        }

        public static LmBoneInfo Unpack(LmMsgPck msg)
        {
            var name = msg.ReadString();
            var id = msg.Read();

            uint unboxedId;
            if (id is ushort x)
            {
                unboxedId = x;
            }
            else
            {
                unboxedId = (uint)id;
            }

            if (msg.Version < 20160407)
            {
                return new LmBoneInfo(name, unboxedId, 0xFFFFu);
            }
            else
            {
                return new LmBoneInfo(name, unboxedId, unboxedId >> 16);
            }
        }
    }
}
