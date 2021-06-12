using SQEX.Luminous.GraphicsLoad;

namespace SQEX.Luminous.Math
{
    public class LmMatrix
    {
        public LmVector3 Row0 { get; }
        public LmVector3 Row1 { get; }
        public LmVector3 Row2 { get; }
        public LmVector3 Row3 { get; }

        public LmMatrix(LmVector3 row0, LmVector3 row1, LmVector3 row2, LmVector3 row3)
        {
            this.Row0 = row0;
            this.Row1 = row1;
            this.Row2 = row2;
            this.Row3 = row3;
        }

        public static LmMatrix Unpack(LmMsgPck msg)
        {
            var row0 = LmVector3.Unpack(msg);
            var row1 = LmVector3.Unpack(msg);
            var row2 = LmVector3.Unpack(msg);
            var row3 = LmVector3.Unpack(msg);

            return new LmMatrix(row0, row1, row2, row3);
        }

    }
}
