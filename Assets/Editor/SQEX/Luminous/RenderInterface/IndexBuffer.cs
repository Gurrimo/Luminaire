using SQEX.Luminous.RenderInterface.D3D11;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SQEX.Luminous.RenderInterface
{
    public class IndexBuffer : IndexBufferImp
    {
        public IndexBuffer(int[] buffer, IndexBufferDesc description) : base(buffer, description)
        {
        }
    }
}
