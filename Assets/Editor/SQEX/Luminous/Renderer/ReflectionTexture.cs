using System.Diagnostics;

namespace SQEX.Luminous.Renderer
{
    [DebuggerDisplay("{Name}")]
    public class ReflectionTexture
    {
        public ReflectionTexture(ulong resourceFileHash, ulong name, ulong shaderGenName, ulong path, uint hashName, uint hashShaderGenName, uint hashPath, uint flags, sbyte highTextureStreamingLevels)
        {
            ResourceFileHash = resourceFileHash;
            NameOffset = name;
            ShaderGenNameOffset = shaderGenName;
            PathOffset = path;
            HashName = hashName;
            HashShaderGenName = hashShaderGenName;
            HashPath = hashPath;
            Flags = flags;
            HighTextureStreamingLevels = highTextureStreamingLevels;
        }

        public ulong ResourceFileHash { get; }
        public string Name { get; set; }
        public ulong NameOffset { get; }
        public string ShaderGenName { get; set; }
        public ulong ShaderGenNameOffset { get; }
        public string Path { get; set; }
        public ulong PathOffset { get; }
        public uint HashName { get; }
        public uint HashShaderGenName { get; }
        public uint HashPath { get; }
        public uint Flags { get; }
        public sbyte HighTextureStreamingLevels { get; }
    }
}
