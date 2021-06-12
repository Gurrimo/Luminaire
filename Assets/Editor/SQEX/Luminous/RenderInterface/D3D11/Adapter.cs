using SharpDX.DXGI;
using System;
using System.Collections.Generic;

namespace SQEX.Luminous.RenderInterface.D3D11
{
    public class Adapter
    {
        private Factory1 Factory { get; set; }
        private Adapter1 PrimaryAdapter { get; set; }

        public Adapter1 GetPrimaryAdapter()
        {
            if (this.PrimaryAdapter != null)
            {
                return this.PrimaryAdapter;
            }

            var adapters = this.GetAdapters();
            if (adapters.Count > 0)
            {
                this.PrimaryAdapter = adapters[0];
            }

            return this.PrimaryAdapter;
        }

        private IList<Adapter1> GetAdapters()
        {
            var factory = this.GetFactory();
            return factory.Adapters1;
        }

        private Factory1 GetFactory()
        {
            if (this.Factory != null)
            {
                return this.Factory;
            }

            this.Factory = new Factory1();
            return this.Factory;
        }
    }
}
