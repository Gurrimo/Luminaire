using SQEX.Luminous.GraphicsLoad;
using SQEX.Luminous.RenderInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQEX.Luminous.Renderer
{
    public class MaterialGmtl : Material
    {
        public ReflectionMaterial Reflection { get; private set; }
        public IList<SamplerState> Samplers { get; } = new List<SamplerState>();

        public static MaterialGmtl Unpack(LmMsgPck msg)
        {
            var reflectionMaterial = new ReflectionMaterial();

            msg.UnpackUInt64(out ulong materialName);

            msg.UnpackUInt16(out ushort matUniformCount);
            msg.UnpackUInt16(out ushort matBufferCount);
            msg.UnpackUInt16(out ushort matTextureCount);
            msg.UnpackUInt16(out ushort matSamplerCount);
            msg.UnpackUInt16(out ushort totalUniformCount);
            msg.UnpackUInt16(out ushort totalBufferCount);
            msg.UnpackUInt16(out ushort totalTextureCount);

            msg.UnpackUInt16(out ushort totalSamplerCount);
            msg.UnpackUInt16(out ushort shaderBinaryCount);
            msg.UnpackUInt16(out ushort shaderProgramCount);

            msg.UnpackUInt32(out uint gpuDataSize);
            msg.UnpackUInt32(out uint stringBufferSize);
            msg.UnpackUInt32(out uint hashMaterialName);
            msg.UnpackUInt32(out uint blendType);

            msg.UnpackFloat32(out float blendFactor);

            msg.UnpackUInt32(out uint renderStateBits);
            msg.UnpackUInt16(out ushort skinVsMaxBoneCount);
            msg.UnpackUInt16(out ushort brdfType);

            reflectionMaterial.MaterialNameOffset = materialName;
            reflectionMaterial.MatUniformCount = matUniformCount;
            reflectionMaterial.MatBufferCount = matBufferCount;
            reflectionMaterial.MatTextureCount = matTextureCount;
            reflectionMaterial.MatSamplerCount = matSamplerCount;
            reflectionMaterial.TotalUniformCount = totalUniformCount;
            reflectionMaterial.TotalBufferCount = totalBufferCount;
            reflectionMaterial.TotalTextureCount = totalTextureCount;
            reflectionMaterial.TotalSamplerCount = totalSamplerCount;
            reflectionMaterial.ShaderBinaryCount = shaderBinaryCount;
            reflectionMaterial.ShaderProgramCount = shaderProgramCount;
            reflectionMaterial.GpuDataSize = gpuDataSize;
            reflectionMaterial.StringBufferSize = stringBufferSize;
            reflectionMaterial.HashMaterialName = hashMaterialName;
            reflectionMaterial.BlendType = blendType;
            reflectionMaterial.BlendFactor = blendFactor;
            reflectionMaterial.RenderStateBits = renderStateBits;
            reflectionMaterial.SkinVsMaxBoneCount = skinVsMaxBoneCount;
            reflectionMaterial.BrdfType = brdfType;

            if (msg.Version >= 20150403)
            {
                msg.UnpackUInt16(out ushort highTexturePackAssetId);
                reflectionMaterial.HighTexturePackAssetIdOffset = highTexturePackAssetId;
            }

            for (var _ = 0; _ < totalUniformCount; _++)
            {
                msg.UnpackUInt64(out ulong name);
                msg.UnpackUInt64(out ulong shaderGenName);
                msg.UnpackUInt32(out uint hashName);
                msg.UnpackUInt32(out uint hashShaderGenName);
                msg.UnpackUInt16(out ushort offset);
                msg.UnpackUInt16(out ushort size);
                msg.UnpackUInt16(out ushort bufferIndex);
                msg.UnpackUInt16(out ushort type);
                msg.UnpackUInt32(out uint flags);

                reflectionMaterial.Uniforms.Add(new ReflectionUniform(name, shaderGenName, hashName, hashShaderGenName, offset, size, bufferIndex, type, flags));
            }

            for (var _ = 0; _ < totalBufferCount; _++)
            {
                msg.UnpackUInt64(out ulong name);
                msg.UnpackUInt64(out ulong shaderGenName);
                msg.UnpackUInt64(out ulong u1);
                msg.UnpackUInt32(out uint hashName);
                msg.UnpackUInt32(out uint hashShaderGenName);
                msg.UnpackUInt32(out uint u2);
                msg.UnpackUInt32(out uint gpuOffset);
                msg.UnpackUInt16(out ushort size);
                msg.UnpackUInt16(out ushort uniformCount);
                msg.UnpackUInt32(out uint flags);

                reflectionMaterial.UniformBuffers.Add(new ReflectionUniformBuffer(name, shaderGenName, hashName, hashShaderGenName, gpuOffset, size, uniformCount, flags));
            }

            for (var _ = 0; _ < totalTextureCount; _++)
            {
                msg.UnpackUInt64(out ulong resourceFileHash);
                msg.UnpackUInt64(out ulong name);
                msg.UnpackUInt64(out ulong shaderGenName);
                msg.UnpackUInt64(out ulong u1);
                msg.UnpackUInt64(out ulong path);
                msg.UnpackUInt32(out uint hashName);
                msg.UnpackUInt32(out uint hashShaderGenName);
                msg.UnpackUInt32(out uint u2);
                msg.UnpackUInt32(out uint hashPath);
                msg.UnpackUInt32(out uint flags);

                sbyte highTextureStreamingLevels = -1;
                if (msg.Version > 20150508)
                {
                    msg.UnpackInt8(out highTextureStreamingLevels);
                }

                reflectionMaterial.Textures.Add(new ReflectionTexture(resourceFileHash, name, shaderGenName, path, hashName, hashShaderGenName, hashPath, flags, highTextureStreamingLevels));
            }

            var material = new MaterialGmtl();
            material.Reflection = reflectionMaterial;
            for (var _ = 0; _ < totalSamplerCount; _++)
            {
                msg.UnpackUInt64(out ulong reflectionSamplerName);
                msg.UnpackUInt64(out ulong reflectionSamplerShaderGenName);
                msg.UnpackUInt64(out ulong u1); // reflectionSamplerHashName?
                msg.UnpackInt8(out sbyte samplerStateMagFilter);

                msg.UnpackInt8(out sbyte samplerStateMinFilter);
                msg.UnpackInt8(out sbyte samplerStateMipFilter);
                msg.UnpackInt8(out sbyte samplerStateWrapS);
                msg.UnpackInt8(out sbyte samplerStateWrapT);
                msg.UnpackInt8(out sbyte samplerStateWrapR);

                msg.UnpackFloat32(out float mipmapLodBias);
                msg.UnpackInt8(out sbyte maxAniso);

                msg.UnpackInt8(out sbyte u2);
                msg.UnpackInt8(out sbyte u3);
                msg.UnpackInt8(out sbyte u4);

                // BorderColor shenanigans
                msg.UnpackFloat32(out float ur);
                msg.UnpackFloat32(out float ug);
                msg.UnpackFloat32(out float ub);
                msg.UnpackFloat32(out float ua);

                msg.UnpackUInt16(out ushort minLod);
                msg.UnpackUInt16(out ushort maxLod);

                msg.UnpackUInt32(out uint reflectionSamplerFlags);

                // TODO a bunch of bit twiddling for borderColor

                var minLodBytes = BitConverter.GetBytes(minLod);
                var minLoadFloat = Half.ToHalf(minLodBytes, 0);

                var maxLodBytes = BitConverter.GetBytes(maxLod);
                var maxLoadFloat = Half.ToHalf(maxLodBytes, 0);

                reflectionMaterial.Samplers.Add(new ReflectionSampler(reflectionSamplerName, reflectionSamplerShaderGenName, 0, 0, reflectionSamplerFlags));
                material.Samplers.Add(new SamplerState(mipmapLodBias, new Color4B(0xFFFFFFFF), samplerStateWrapS, samplerStateWrapT, samplerStateWrapR, minLoadFloat, maxLoadFloat, maxAniso, samplerStateMinFilter, samplerStateMagFilter, samplerStateMipFilter, 0));
            }

            for (var _ = 0; _ < shaderBinaryCount; _++)
            {
                msg.UnpackUInt64(out ulong resourceFileHash);
                msg.UnpackUInt64(out ulong path);

                reflectionMaterial.ShaderBinaries.Add(new ReflectionShaderBinary(resourceFileHash, path));
            }

            for (var _ = 0; _ < shaderProgramCount; _++)
            {
                msg.UnpackUInt16(out ushort lowKey);
                msg.UnpackUInt16(out ushort highKey);
                msg.UnpackUInt16(out ushort csBinaryIndex);
                msg.UnpackUInt16(out ushort vsBinaryIndex);
                msg.UnpackUInt16(out ushort hsBinaryIndex);
                msg.UnpackUInt16(out ushort dsBinaryIndex);
                msg.UnpackUInt16(out ushort gsBinaryIndex);
                msg.UnpackUInt16(out ushort psBinaryIndex);

                reflectionMaterial.ShaderPrograms.Add(new ReflectionShaderProgram(lowKey, highKey, csBinaryIndex, vsBinaryIndex, hsBinaryIndex, dsBinaryIndex, gsBinaryIndex, psBinaryIndex));
            }

            if (gpuDataSize > 0)
            {
                msg.UnpackBlob(out byte[] gpuData, out gpuDataSize);
                reflectionMaterial.GpuData = gpuData;
            }

            if (stringBufferSize > 0)
            {
                msg.UnpackBlob(out byte[] stringBuffer, out stringBufferSize);
                reflectionMaterial.StringBuffer = stringBuffer;
            }

            // Read strings
            reflectionMaterial.MaterialName = reflectionMaterial.GetStringFromBuffer((int)reflectionMaterial.MaterialNameOffset);

            foreach (var reflectionUniform in reflectionMaterial.Uniforms)
            {
                reflectionUniform.Name = reflectionMaterial.GetStringFromBuffer((int)reflectionUniform.NameOffset);
                reflectionUniform.ShaderGenName = reflectionMaterial.GetStringFromBuffer((int)reflectionUniform.ShaderGenNameOffset);
            }

            foreach (var uniformBuffer in reflectionMaterial.UniformBuffers)
            {
                uniformBuffer.Name = reflectionMaterial.GetStringFromBuffer((int)uniformBuffer.NameOffset);
                uniformBuffer.ShaderGenName = reflectionMaterial.GetStringFromBuffer((int)uniformBuffer.ShaderGenNameOffset);
            }

            foreach (var texture in reflectionMaterial.Textures)
            {
                texture.Name = reflectionMaterial.GetStringFromBuffer((int)texture.NameOffset);
                texture.ShaderGenName = reflectionMaterial.GetStringFromBuffer((int)texture.ShaderGenNameOffset);
                texture.Path = reflectionMaterial.GetStringFromBuffer((int)texture.PathOffset);
            }

            foreach (var sampler in reflectionMaterial.Samplers)
            {
                sampler.Name = reflectionMaterial.GetStringFromBuffer((int)sampler.NameOffset);
                sampler.ShaderGenName = reflectionMaterial.GetStringFromBuffer((int)sampler.ShaderGenNameOffset);
            }

            foreach (var shaderBinary in reflectionMaterial.ShaderBinaries)
            {
                shaderBinary.Path = reflectionMaterial.GetStringFromBuffer((int)shaderBinary.PathOffset);
            }

            if (reflectionMaterial.HighTexturePackAssetIdOffset != 0)
            {
                reflectionMaterial.HighTexturePackAssetId = reflectionMaterial.GetStringFromBuffer((int)reflectionMaterial.HighTexturePackAssetIdOffset);
            }

            return material;
        }
    }
}
