using SQEX.Luminous.GraphicsLoad;
using SQEX.Luminous.Math;
using System.Diagnostics;

namespace SQEX.Luminous.GraphicsCore
{
    [DebuggerDisplay("{Name}")]
    public class LmNodeInfo
    {
        public LmMatrix Matrix { get; }
        public string Name { get; }

        public LmNodeInfo(LmMatrix matrix, string name)
        {
            this.Matrix = matrix;
            this.Name = name;
        }

        public static LmNodeInfo Unpack(LmMsgPck msg)
        {
            var matrix = LmMatrix.Unpack(msg);
            var name = msg.ReadString();

            return new LmNodeInfo(matrix, name);
        }
    }
}
