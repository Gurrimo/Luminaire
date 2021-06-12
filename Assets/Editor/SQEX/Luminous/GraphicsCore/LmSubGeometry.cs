using SQEX.Luminous.GraphicsLoad;
using SQEX.Luminous.Math;

namespace SQEX.Luminous.GraphicsCore
{
    public class LmSubGeometry
    {
        public LmAABB AABB { get; }
        uint StartIdx { get; }
        uint PrimCount { get; }
        uint ClusterIdxBitFlag { get; }
        uint DrawOrder { get; }

        public LmSubGeometry(LmAABB aabb, uint startIdx, uint primCount, uint clusterIdxBitFlag, uint drawOrder)
        {
            this.AABB = aabb;
            this.StartIdx = startIdx;
            this.PrimCount = primCount;
            this.ClusterIdxBitFlag = clusterIdxBitFlag;
            this.DrawOrder = drawOrder;
        }

        public static LmSubGeometry Unpack(LmMsgPck msg)
        {
            var aabb = LmAABB.Unpack(msg);
            var startIdx = msg.ReadUint();
            var primCount = msg.ReadUint();
            var clusterIdxBitFlag = msg.ReadUint();
            var drawOrder = msg.ReadUint();

            return new LmSubGeometry(aabb, startIdx, primCount, clusterIdxBitFlag, drawOrder);
        }
    }
}
