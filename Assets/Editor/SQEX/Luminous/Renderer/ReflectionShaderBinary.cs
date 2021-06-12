using System.Diagnostics;

namespace SQEX.Luminous.Renderer
{
    [DebuggerDisplay("{Path}")]
    public class ReflectionShaderBinary
    {
        public ReflectionShaderBinary(ulong resourceFileHash, ulong path)
        {
            ResourceFileHash = resourceFileHash;
            PathOffset = path;
        }

        public ulong ResourceFileHash { get; }
        public string Path { get; set; }
        public ulong PathOffset { get; }
    }
}
