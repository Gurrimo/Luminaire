using SQEX.Luminous.GraphicsLoad;

namespace SQEX.Luminous.Math
{
    public class LmAABB : ILmAABB
    {
        public LmVector3 Min { get; }
        public LmVector3 Max { get; }

        public LmAABB(LmVector3 min, LmVector3 max)
        {
            this.Min = min;
            this.Max = max;
        }

        public static LmAABB Unpack(LmMsgPck msg)
        {
            var min = LmVector3.Unpack(msg);
            var max = LmVector3.Unpack(msg);
            return new LmAABB(min, max);
        }
    }
}
