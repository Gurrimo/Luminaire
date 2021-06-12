using System;

namespace SQEX.Luminous.RenderInterface
{
    public class Color4B
    {
        public Color4B(uint bits)
        {
            Bits = bits;
        }

        public uint Bits { get; }
    }

    public class SamplerState
    {
        public SamplerState(float mipmapLodBias, Color4B borderColor, sbyte wrapS, sbyte wrapT, sbyte wrapR, float minLod, float maxLod, sbyte maxAniso, sbyte minFilter, sbyte magFilter, sbyte mipFilter, sbyte textureFlag)
        {
            MipmapLodBias = mipmapLodBias;
            BorderColor = borderColor ?? throw new ArgumentNullException(nameof(borderColor));
            WrapS = wrapS;
            WrapT = wrapT;
            WrapR = wrapR;
            MinLod = minLod;
            MaxLod = maxLod;
            MaxAniso = maxAniso;
            MinFilter = minFilter;
            MagFilter = magFilter;
            MipFilter = mipFilter;
            TextureFlag = textureFlag;
        }

        public float MipmapLodBias { get; }
        public Color4B BorderColor { get; }
        public sbyte WrapS { get; }
        public sbyte WrapT { get; }
        public sbyte WrapR { get; }
        public float MinLod { get; }
        public float MaxLod { get; }
        public sbyte MaxAniso { get; }
        public sbyte MinFilter { get; }
        public sbyte MagFilter { get; }
        public sbyte MipFilter { get; }
        public sbyte TextureFlag { get; }
    }
}
