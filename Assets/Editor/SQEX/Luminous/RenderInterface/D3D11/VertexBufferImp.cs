using System.Collections.Generic;

namespace SQEX.Luminous.RenderInterface.D3D11
{
    public class VertexBufferImp : BufferImp
    {
        public VertexBufferDesc Description { get; }

        public VertexBufferImp(int[] buffer, VertexBufferDesc description) : base(buffer)
        {
            this.Description = description;
        }
    }
}
