using System;
using System.Collections.Generic;
using System.Linq;

namespace SQEX.Luminous.RenderInterface.D3D11
{
    public class BufferImp
    {
        public int[] Buffer { get; }

        public BufferImp(int[] buffer)
        {
            this.Buffer = buffer;
        }
    }
}
