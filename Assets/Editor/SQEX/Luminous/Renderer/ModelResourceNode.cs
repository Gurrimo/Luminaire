using SQEX.Luminous.GraphicsCore;
using SQEX.Luminous.Renderer.Binary;
using System.Collections.Generic;
using System.Diagnostics;

namespace SQEX.Luminous.Renderer
{
    [DebuggerDisplay("{Name}")]
    public class ModelResourceNode
    {
        public string Name { get; set; }
        public MeshBoneInformation MeshBoneInformation { get; } = new MeshBoneInformation();
        public IList<GmdlPartsData> GmdlPartsDatas { get; } = new List<GmdlPartsData>();
        public IList<MeshContainer> MeshContainers { get; } = new List<MeshContainer>();
        public LmNodeTable NodeTable { get; set; }
    }
}
