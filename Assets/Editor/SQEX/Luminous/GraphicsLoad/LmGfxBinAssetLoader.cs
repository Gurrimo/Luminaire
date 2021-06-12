using SQEX.Luminous.GraphicsCore;
using SQEX.Luminous.Math;
using SQEX.Luminous.Renderer;
using SQEX.Luminous.Renderer.Binary;
using System.Collections.Generic;

namespace SQEX.Luminous.GraphicsLoad
{
    public class LmGfxBinAssetLoader
    {
        public void BuildDependencyTable(LmGfxBinUnpackContext unpackContext, LmMsgPck selfData, IDictionary<string, byte[]> dependencies)
        {
            selfData.Rewind();
            unpackContext.Header.Load(selfData, dependencies);
        }

        public static ModelResourceNode Convert(LmMsgPck msg)
        {
            var aabb = LmAABB.Unpack(msg);
            var boneTable = LmBoneTable.Unpack(msg);

            var i = 0u;
            var modelResourceNode = new ModelResourceNode();
            foreach(var boneInfo in boneTable.BoneInfos)
            {
                modelResourceNode.MeshBoneInformation.Bones.Add(new MeshBoneInformation.Bone(boneInfo.BoneName, boneInfo.LodBoneIdx, boneInfo.UniqueBoneIdx));
                // FIXME modelResourceNode.MeshBoneInformation.BoneLut.Add(boneInfo.UniqueBoneIdx, i);
                i++;
            }

            modelResourceNode.NodeTable = LmNodeTable.Unpack(msg);
            if (msg.Version >= 20141113)
            {
                var assetHash = (ulong)msg.Read();
                // TODO msg.UserData.GpuBuffer = msg.UserData.DependencyTable.Get(assetHash);
            }

            var meshContainerCount = (int)msg.Read();
            for(var _ = 0; _ < meshContainerCount; _++)
            {
                var meshContainer = MeshContainer.Convert(msg);
                modelResourceNode.MeshContainers.Add(meshContainer);
            }

            if (msg.Version >= 20140623)
            {
                var unknown = msg.ReadBool();
                modelResourceNode.Name = msg.ReadString();
            }

            if (msg.Version >= 20140722 && msg.Version < 20140929)
            {
                var hasPsdData = msg.ReadBool();
                var psdDataHash = msg.ReadUint64();
            }

            if (msg.Version < 20140815)
            {
                return modelResourceNode;
            }

            var gmdlPartsDatasCount = msg.ReadUint();
            for(var _ = 0; _ < gmdlPartsDatasCount; _++)
            {
                var gmdlPartsData = GmdlPartsData.Unpack(msg);
                modelResourceNode.GmdlPartsDatas.Add(gmdlPartsData);
            }

            return modelResourceNode;
        }
    }
}
