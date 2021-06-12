using SQEX.Luminous.Renderer;
using System.Collections.Generic;

namespace SQEX.Luminous.GraphicsLoad
{
    public class LmGfxBinMaterialAssetLoader : LmGfxBinAssetLoader
    {
        public MaterialGmtl Initialize(LmGfxBinUnpackContext unpackContext, LmMsgPck selfData, IDictionary<string, byte[]> dependencies)
        {
            this.BuildDependencyTable(unpackContext, selfData, dependencies);
            return MaterialGmtl.Unpack(selfData);
        }
    }
}
