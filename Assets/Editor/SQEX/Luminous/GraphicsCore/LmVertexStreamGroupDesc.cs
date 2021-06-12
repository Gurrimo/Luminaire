using SQEX.Luminous.GraphicsLoad;
using System.Collections.Generic;

namespace SQEX.Luminous.GraphicsCore
{
    public class LmVertexStreamGroupDesc
    {
        public IList<LmVertexStreamDesc> VtxStreamDescs { get; } = new List<LmVertexStreamDesc>();

        public static LmVertexStreamGroupDesc Unpack(LmMsgPck msg)
        {
            var result = new LmVertexStreamGroupDesc();
            var count = msg.ReadUint();
            for(var _ = 0; _ < count; _++)
            {
                var desc = LmVertexStreamDesc.Unpack(msg);
                result.VtxStreamDescs.Add(desc);
            }

            return result;
        }
    }
}
