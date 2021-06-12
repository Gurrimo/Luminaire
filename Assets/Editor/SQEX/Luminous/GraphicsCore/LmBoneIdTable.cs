using SQEX.Luminous.GraphicsLoad;
using System.Collections.Generic;

namespace SQEX.Luminous.GraphicsCore
{
    public class LmBoneIdTable
    {
        public IList<uint> BoneIds { get; } = new List<uint>();

        public static LmBoneIdTable Unpack(LmMsgPck msg)
        {
            var result = new LmBoneIdTable();      
            var boneIdCount = msg.ReadUint();
            for(var _ = 0; _ < boneIdCount; _++)
            {
                var boneId = msg.Read();
                if (boneId is byte x)
                {
                    result.BoneIds.Add(x);
                }
                else if (boneId is ushort y)
                {
                    result.BoneIds.Add(y);
                }
                else
                {
                    result.BoneIds.Add((uint)boneId);
                }
            }

            return result;
        }
    }
}
