using SQEX.Luminous.GraphicsLoad;
using System.Collections.Generic;

namespace SQEX.Luminous.GraphicsCore
{
    public class LmNodeTable
    {
        public IList<LmNodeInfo> NodeInfos { get; } = new List<LmNodeInfo>();

        public static LmNodeTable Unpack(LmMsgPck msg)
        {
            var result = new LmNodeTable();

            var nodeCount = msg.ReadUint();
            for(var _ = 0; _ < nodeCount; _++)
            {
                var nodeInfo = LmNodeInfo.Unpack(msg);
                result.NodeInfos.Add(nodeInfo);
            }

            return result;
        }
    }
}
