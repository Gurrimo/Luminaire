using System;
using System.Collections.Generic;
using System.Linq;

namespace SQEX.Luminous.RenderInterface.D3D11
{
    public class IndexBufferImp : BufferImp
    {
        public IndexBufferDesc Description { get; }

        public IndexBufferImp(int[] buffer, IndexBufferDesc description) : base(buffer)
        {
            this.Description = description;
        }
    }
}
