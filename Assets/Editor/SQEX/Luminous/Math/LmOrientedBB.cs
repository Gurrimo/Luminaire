using SQEX.Luminous.GraphicsLoad;

namespace SQEX.Luminous.Math
{
    public class LmOrientedBB : ILmAABB
    {
        public LmVector3 Center { get; }
        public LmVector3 XHalfExtent { get; }
        public LmVector3 YHalfExtent { get; }
        public LmVector3 ZHalfExtent { get; }

        public LmOrientedBB(LmVector3 center, LmVector3 xHalfExtent, LmVector3 yHalfExtent, LmVector3 zHalfExtent)
        {
            this.Center = center;
            this.XHalfExtent = xHalfExtent;
            this.YHalfExtent = yHalfExtent;
            this.ZHalfExtent = zHalfExtent;
        }

        public static LmOrientedBB Unpack(LmMsgPck msg)
        {
            var center = LmVector3.Unpack(msg);
            var xHalfExtent = LmVector3.Unpack(msg);
            var yHalfExtent = LmVector3.Unpack(msg);
            var zHalfExtent = LmVector3.Unpack(msg);

            return new LmOrientedBB(center, xHalfExtent, yHalfExtent, zHalfExtent);
        }
    }
}
