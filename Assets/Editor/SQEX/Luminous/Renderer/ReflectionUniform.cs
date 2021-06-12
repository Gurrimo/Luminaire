using System.Diagnostics;

namespace SQEX.Luminous.Renderer
{
    [DebuggerDisplay("{Name}")]
    public class ReflectionUniform
    {
        public ReflectionUniform(ulong name, ulong shaderGenName, uint hashName, uint hashShaderGenName, ushort offset, ushort size, ushort bufferIndex, ushort type, uint flags)
        {
            NameOffset = name;
            ShaderGenNameOffset = shaderGenName;
            HashName = hashName;
            HashShaderGenName = hashShaderGenName;
            Offset = offset;
            Size = size;
            BufferIndex = bufferIndex;
            Type = type;
            Flags = flags;
        }

        public string Name { get; set; }
        public ulong NameOffset { get; }
        public string ShaderGenName { get; set; }
        public ulong ShaderGenNameOffset { get; }
        public uint HashName { get; }
        public uint HashShaderGenName { get; }
        public ushort Offset { get; }
        public ushort Size { get; }
        public ushort BufferIndex { get; }
        public ushort Type { get; }
        public uint Flags { get; }
    }
}
