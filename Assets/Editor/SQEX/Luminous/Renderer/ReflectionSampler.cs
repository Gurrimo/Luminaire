using System.Diagnostics;

namespace SQEX.Luminous.Renderer
{
    [DebuggerDisplay("{Name}")]
    public class ReflectionSampler
    {
        public ReflectionSampler(ulong name, ulong shaderGenName, uint hashName, uint hashShaderGenName, uint flags)
        {
            NameOffset = name;
            ShaderGenNameOffset = shaderGenName;
            HashName = hashName;
            HashShaderGenName = hashShaderGenName;
            Flags = flags;
        }

        public string Name { get; set; }
        public ulong NameOffset { get; }
        public string ShaderGenName { get; set; }
        public ulong ShaderGenNameOffset { get; }
        public uint HashName { get; }
        public uint HashShaderGenName { get; }
        public uint Flags { get; }
    }
}
