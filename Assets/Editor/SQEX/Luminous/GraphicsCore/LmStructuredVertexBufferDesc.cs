using SQEX.Luminous.GraphicsLoad;
using System;
using System.Collections.Generic;

namespace SQEX.Luminous.GraphicsCore
{
    public class LmStructuredVertexBufferDesc
    {
        public uint Stride { get; }
        public uint StartOffset { get; }
        public IList<LmVertexElementDesc> VtxElementDescs { get; } = new List<LmVertexElementDesc>();

        private LmStructuredVertexBufferDesc(uint stride, uint startOffset)
        {
            this.Stride = stride;
            this.StartOffset = startOffset;
        }

        public static LmStructuredVertexBufferDesc Unpack(LmMsgPck msg)
        {
            var stride = msg.ReadUint();
            var startOffset = msg.ReadUint();
            var result = new LmStructuredVertexBufferDesc(stride, startOffset);

            var elementCount = msg.ReadUint();
            for(var _ = 0; _ < elementCount; _++)
            {
                var desc = LmVertexElementDesc.Unpack(msg);
                result.VtxElementDescs.Add(desc);
            }

            return result;
        }
    }
}
