using System.Diagnostics;

namespace SQEX.Luminous.Renderer
{
    [DebuggerDisplay("{Name}")]
    public class ReflectionUniformBuffer
    {
        public ReflectionUniformBuffer(ulong name, ulong shaderGenName, uint hashName, uint hashShaderGenName, uint gpuOffset, ushort size, ushort uniformCount, uint flags)
        {
            NameOffset = name;
            ShaderGenNameOffset = shaderGenName;
            HashName = hashName;
            HashShaderGenName = hashShaderGenName;
            GpuOffset = gpuOffset;
            Size = size;
            UniformCount = uniformCount;
            Flags = flags;
        }

        public string Name { get; set; }
        public ulong NameOffset { get; }
        public string ShaderGenName { get; set; }
        public ulong ShaderGenNameOffset { get; }
        public uint HashName { get; }
        public uint HashShaderGenName { get; }
        public uint GpuOffset { get; }
        public ushort Size { get; }
        public ushort UniformCount { get; }
        public uint Flags { get; }
    }
}
