using SQEX.Luminous.GraphicsLoad;
using System.Collections.Generic;
using System.Diagnostics;
using static SQEX.Luminous.GraphicsLoad.LmMsgPck;

namespace SQEX.Luminous.GraphicsCore
{
    public class LmBoneTable
    {
        public IList<LmBoneInfo> BoneInfos { get; } = new List<LmBoneInfo>();

        public static LmBoneTable Unpack(LmMsgPck msg)
        {
            // i_shaderInfo is seemingly always empty
            var instanceNameFormat = msg.ReadByte();
            Debug.Assert((byte)instanceNameFormat == (byte)LmPackFormat.FixStrStart);

            var shaderClassFormat = msg.ReadByte();
            Debug.Assert((byte)shaderClassFormat == (byte)LmPackFormat.FixStrStart);

            var shaderSamplerDescFormat = msg.ReadByte();
            Debug.Assert((byte)shaderSamplerDescFormat == (byte)LmPackFormat.FixArrayStart);

            var shaderParametersListFormat = msg.ReadByte();
            Debug.Assert((byte)shaderParametersListFormat == (byte)LmPackFormat.FixArrayStart);

            var childClassesFormat = msg.ReadByte();
            Debug.Assert((byte)childClassesFormat == (byte)LmPackFormat.FixArrayStart);

            var result = new LmBoneTable();
            var boneCount = msg.ReadUint();
            for(var _ = 0; _ < boneCount; _++)
            {
                var boneInfo = LmBoneInfo.Unpack(msg);
                result.BoneInfos.Add(boneInfo);
            }

            return result;
        }
    }
}
