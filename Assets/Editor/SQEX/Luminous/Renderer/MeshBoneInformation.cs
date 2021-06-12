using System.Collections.Generic;
using System.Diagnostics;

namespace SQEX.Luminous.Renderer
{
    public class MeshBoneInformation
    {
        [DebuggerDisplay("{Name}")]
        public class Bone
        {
            public string Name { get; }
            public uint LodIndex { get; }
            public uint UniqueIndex { get; }

            public Bone(string name, uint lodIndex, uint uniqueIndex)
            {
                this.Name = name;
                this.LodIndex = lodIndex;
                this.UniqueIndex = uniqueIndex;
            }
        }

        public IList<Bone> Bones { get; } = new List<Bone>();
        public IDictionary<uint, uint> BoneLut { get; } = new Dictionary<uint, uint>();
    }
}
