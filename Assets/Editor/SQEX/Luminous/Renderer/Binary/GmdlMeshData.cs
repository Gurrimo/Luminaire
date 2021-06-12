using System.Collections.Generic;

namespace SQEX.Luminous.Renderer.Binary
{
    public enum VertexLayoutType
    {
        NULL = 0x0,
        Skinning_4Bones = 0x1,
        Skinning_8Bones = 0x2,
        NTB2 = 0x4,
        Skinning_1Bones = 0x8,
        Skinning_6Bones = 0x10,
        BoneIndices16 = 0x20,
        Skinning_Any = 0x1B,
    }

    public class GmdlMeshData
    {
        public uint Flags { get; set; }
        public int DrawPriorityOffset { get; set; }
        public float LodNear { get; set; }
        public float LodFar { get; set; }
        public float LodFade { get; set; }
        public VertexLayoutType VertexLayoutType { get; set; }
        public uint PartsId { get; set; }
        public uint BreakableBoneIndex { get; set; }
        public sbyte LowLodShadowCascadeNo { get; set; }
        public IList<GmdlMeshPartsData> GmdlMeshPartsDatas { get; } = new List<GmdlMeshPartsData>();
    }
}
