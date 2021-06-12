using SQEX.Ebony.Std;
using SQEX.Luminous.RenderInterface.D3D11;

namespace SQEX.Luminous.RenderInterface
{
    public class GRC
    {
        public void OnInitializeNative()
        {
            var coreData = new D3D11CoreData();
            var adapter = coreData.Adapters.GetPrimaryAdapter();

            var device = new SharpDX.Direct3D11.Device(adapter, SharpDX.Direct3D11.DeviceCreationFlags.None, SharpDX.Direct3D.FeatureLevel.Level_11_1);
        }
    }
}
