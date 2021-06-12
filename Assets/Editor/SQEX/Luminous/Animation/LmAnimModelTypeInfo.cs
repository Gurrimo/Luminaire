using System;
using System.Diagnostics;

namespace SQEX.Luminous.Animation
{
    public class LmAnimModelTypeInfo
    {
        public int Size { get; }
        public float Version { get; }
        public uint BindPoseOffset { get; }
        public uint NumCustomUserDatum { get; }
        //SQEX::Luminous::Animation::LmSCustomUserDataIndexNode* m_customUserDataIndex;
        //SQEX::Luminous::Animation::LmSInstanceData* m_pDefaultInstanceDataFileBin;
        //SQEX::Luminous::Animation::LmAnimHashMap<unsigned int, SQEX::Luminous::Animation::LmSTransitionParams>* m_pTransitions;
        //SQEX::Luminous::Animation::LmSTransitionParams* m_defaultTransition;
        public uint NumTransitions { get; }
        public uint NumInstanceDataTypes { get; }
        public uint TotalInstanceDataSize { get; }
        public int[] InstanceDataOffsets { get; } = new int [11];
        public int ActiveInstances { get; } = -1;
        //SQEX::Luminous::Animation::LmPoseSpec m_poseSpec;

        public static LmAnimModelTypeInfo Load(byte[] animBuffer, bool initPools)
        {
            var size = BitConverter.ToInt32(animBuffer, 0);
            var version = BitConverter.ToSingle(animBuffer, 4);
            Debug.Assert(version >= 0.62f);

            var bindPoseOffset = BitConverter.ToUInt32(animBuffer, 8);
            var numCustomUserDatum = BitConverter.ToUInt32(animBuffer, 12);

            var customUserDataIndexOffset = BitConverter.ToUInt64(animBuffer, 16);
            var defaultInstanceDataFileBinOffset = BitConverter.ToUInt64(animBuffer, 24);
            var transitionsOffset = BitConverter.ToUInt64(animBuffer, 32);
            Debug.Assert(transitionsOffset != 0);

            var defaultTransitionOffset = BitConverter.ToUInt64(animBuffer, 40);
            var numTransitions = BitConverter.ToUInt32(animBuffer, 48);

            for (var i = 1u; i < numTransitions; i++)
            {

            }

            // TODO
            return null;
        }
    }
}
