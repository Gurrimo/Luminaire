namespace SQEX.Luminous.Renderer
{
    public class ReflectionShaderProgram
    {
        public ReflectionShaderProgram(ushort lowKey, ushort highKey, ushort csBinaryIndex, ushort vsBinaryIndex, ushort hsBinaryIndex, ushort dsBinaryIndex, ushort gsBinaryIndex, ushort psBinaryIndex)
        {
            LowKey = lowKey;
            HighKey = highKey;
            CsBinaryIndex = csBinaryIndex;
            VsBinaryIndex = vsBinaryIndex;
            HsBinaryIndex = hsBinaryIndex;
            DsBinaryIndex = dsBinaryIndex;
            GsBinaryIndex = gsBinaryIndex;
            PsBinaryIndex = psBinaryIndex;
        }

        public ushort LowKey { get; }
        public ushort HighKey { get; }
        public ushort CsBinaryIndex { get; }
        public ushort VsBinaryIndex { get; }
        public ushort HsBinaryIndex { get; }
        public ushort DsBinaryIndex { get; }
        public ushort GsBinaryIndex { get; }
        public ushort PsBinaryIndex { get; }
    }
}
