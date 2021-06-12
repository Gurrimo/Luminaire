using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SQEX.Luminous.Renderer
{
    [DebuggerDisplay("{MaterialName}")]
    public class ReflectionMaterial
    {
        public string MaterialName { get; set; }
        public ulong MaterialNameOffset { get; set; }
        public IList<ReflectionUniform> Uniforms { get; } = new List<ReflectionUniform>();
        public IList<ReflectionUniformBuffer> UniformBuffers { get; } = new List<ReflectionUniformBuffer>();
        public IList<ReflectionTexture> Textures { get; } = new List<ReflectionTexture>();
        public IList<ReflectionSampler> Samplers { get; } = new List<ReflectionSampler>();
        public IList<ReflectionShaderBinary> ShaderBinaries { get; } = new List<ReflectionShaderBinary>();
        public IList<ReflectionShaderProgram> ShaderPrograms { get; } = new List<ReflectionShaderProgram>();
        public ushort MatUniformCount { get; set; }
        public ushort MatBufferCount { get; set; }
        public ushort MatTextureCount { get; set; }
        public ushort MatSamplerCount { get; set; }
        public ushort TotalUniformCount { get; set; }
        public ushort TotalBufferCount { get; set; }
        public ushort TotalTextureCount { get; set; }
        public ushort TotalSamplerCount { get; set; }
        public ushort ShaderBinaryCount { get; set; }
        public ushort ShaderProgramCount { get; set; }
        [JsonIgnore]
        public byte[] GpuData { get; set; }
        [JsonIgnore]
        public byte[] StringBuffer { get; set; }
        public uint GpuDataSize { get; set; }
        public uint StringBufferSize { get; set; }
        public uint HashMaterialName { get; set; }
        public uint BlendType { get; set; }
        public float BlendFactor { get; set; }
        public bool HairNoDither { get; set; }
        public uint RenderStateBits { get; set; }
        public ushort SkinVsMaxBoneCount { get; set; }
        public ushort BrdfType { get; set; }
        public string HighTexturePackAssetId { get; set; }
        public ulong HighTexturePackAssetIdOffset { get; set; }

        public string GetStringFromBuffer(int offset)
        {
            var sb = new StringBuilder();

            for (var c = (char)this.StringBuffer[offset]; c != 0;)
            {
                sb.Append(c);
                offset++;
                c = (char)this.StringBuffer[offset];
            }

            return sb.ToString();
        }
    }
}
