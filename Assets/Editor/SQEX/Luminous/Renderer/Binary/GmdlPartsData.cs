using SQEX.Luminous.GraphicsLoad;
using System.Diagnostics;

namespace SQEX.Luminous.Renderer.Binary
{
    [DebuggerDisplay("{Name}")]
    public class GmdlPartsData
    {
        public string Name { get; }
        public uint Id { get; }
        public bool Flags { get; }

        private GmdlPartsData(string name, uint id, bool flags)
        {
            this.Name = name;
            this.Id = id;
            this.Flags = flags;
        }

        public static GmdlPartsData Unpack(LmMsgPck msg)
        {
            var name = msg.ReadString();
            var id = msg.ReadUint();
            var str = msg.ReadString();
            var flag = msg.ReadBool();

            return new GmdlPartsData(name, id, flag);
        }
    }
}
