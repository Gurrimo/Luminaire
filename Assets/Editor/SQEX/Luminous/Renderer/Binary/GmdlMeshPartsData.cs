using SQEX.Luminous.GraphicsLoad;

namespace SQEX.Luminous.Renderer.Binary
{
    public class GmdlMeshPartsData
    {
        public int PartsId { get; }
        public int StartIndex { get; }
        public int IndexCount { get; }

        public GmdlMeshPartsData(int partsId, int startIndex, int indexCount)
        {
            this.PartsId = partsId;
            this.StartIndex = startIndex;
            this.IndexCount = indexCount;
        }

        public static GmdlMeshPartsData Unpack(LmMsgPck msg)
        {
            var partsId = msg.ReadInt();
            var startIndex = msg.ReadInt();
            var indexCount = msg.ReadInt();

            return new GmdlMeshPartsData(partsId, startIndex, indexCount);
        }
    }
}
