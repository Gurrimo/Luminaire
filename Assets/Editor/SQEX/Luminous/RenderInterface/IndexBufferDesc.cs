using SQEX.Luminous.GraphicsCore;

namespace SQEX.Luminous.RenderInterface
{
    public class IndexBufferDesc
    {
        public uint Size { get; }
        public LmEIndexType Type { get; }

        public IndexBufferDesc(uint size, LmEIndexType type)
        {
            this.Size = size;
            this.Type = type;
        }
    }
}
