using System.Collections.Generic;

namespace SQEX.Luminous.GraphicsLoad
{
    public class LmDependencyTable
    {
        private IDictionary<ulong, byte[]> hashTable = new Dictionary<ulong, byte[]>();

        public void Put(ulong assetHash, byte[] asset)
        {
            this.hashTable.Add(assetHash, asset);
        }

        public byte[] Get(ulong assetHash)
        {
            return this.hashTable[assetHash];
        }
    }
}
