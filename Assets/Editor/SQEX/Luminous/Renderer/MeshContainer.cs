using SQEX.Luminous.GraphicsLoad;
using System.Collections.Generic;
using System.Diagnostics;

namespace SQEX.Luminous.Renderer
{
    [DebuggerDisplay("{Name}")]
    public class MeshContainer
    {
        public string Name { get; }
        public IList<Mesh> Meshes { get; } = new List<Mesh>();

        public MeshContainer(string name)
        {
            this.Name = name;
        }

        public static MeshContainer Convert(LmMsgPck pck)
        {
            var name = pck.ReadString();
            var result = new MeshContainer(name);

            var clusterCount = pck.Read();
            Debug.Assert((int)clusterCount == 1);

            // Where are these stored? Seemingly nowhere?
            var clusterName = pck.ReadString();

            var meshCount = pck.ReadUint();
            for(var _ = 0; _ < meshCount; _++)
            {
                var mesh = Mesh.Convert(pck);
                result.Meshes.Add(mesh);
            }

            // TODO Setup
            return result;
        }
    }
}
