using SQEX.Luminous.GraphicsLoad;

namespace SQEX.Luminous.Math
{
    public class LmVector3
    {
        public float X { get; }
        public float Y { get; }
        public float Z { get; }

        public LmVector3(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static LmVector3 Unpack(LmMsgPck msg)
        {
            var x = msg.ReadFloat();
            var y = msg.ReadFloat();
            var z = msg.ReadFloat();
            return new LmVector3(x, y, z);
        }
    }
}
