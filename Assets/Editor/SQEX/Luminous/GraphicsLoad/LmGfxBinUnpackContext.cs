namespace SQEX.Luminous.GraphicsLoad
{
    public class LmGfxBinUnpackContext
    {
        public LmGfxBin_V1 Header { get; } = new LmGfxBin_V1();
        public byte[] GpuBuffer { get; set; }
        public LmDependencyTable DependencyTable { get; } = new LmDependencyTable();
    }
}
