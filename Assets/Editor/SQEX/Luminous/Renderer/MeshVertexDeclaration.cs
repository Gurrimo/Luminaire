using SQEX.Luminous.RenderInterface;
using System.Collections.Generic;

namespace SQEX.Luminous.Renderer
{
    public class MeshVertexDeclaration
    {
        public class StreamInfo
        {
            public VertexBuffer Buffer { get; }
            public byte InstancingFlag { get; }
            public byte StreamNo { get; }
            public uint Stride { get; set; }

            public StreamInfo(VertexBuffer buffer, byte instancingFlag, byte streamNo, uint stride)
            {
                this.Buffer = buffer;
                this.InstancingFlag = instancingFlag;
                this.StreamNo = streamNo;
                this.Stride = stride;
            }
        }

        public IList<VertexElement> VertexElementInfos { get; } = new List<VertexElement>();
        public IList<StreamInfo> StreamInfos { get; } = new List<StreamInfo>();
        public int MaxStreamIndex { get; private set; } = -1;

        public void AddVertexElement(VertexElement element, VertexBuffer stream)
        {
            this.VertexElementInfos.Add(element);

            if (this.StreamInfos.Count == 0)
            {
                var size = 0u;
                switch (element.Type)
                {
                    case 0:
                    case 2:
                    case 4:
                    case 8:
                    case 9:
                    case 0xB:
                        size = 2;
                        break;
                    case 1:
                    case 5:
                        size = 4;
                        break;
                    case 3:
                    case 6:
                    case 7:
                    case 0xA:
                        size = 1;
                        break;
                }

                var streamInfo = new StreamInfo(stream, element.InstancingFlag, element.Stream, size * element.Size);
                this.StreamInfos.Add(streamInfo);
            }
            else
            {
                var lastStreamInfo = this.StreamInfos[this.StreamInfos.Count - 1];
                var size = 0;
                switch (element.Type)
                {
                    case 0:
                    case 2:
                    case 4:
                    case 8:
                    case 9:
                    case 0xB:
                        lastStreamInfo.Stride += (uint)(2 * element.Size);
                        break;
                    case 1:
                    case 5:
                        size = 4;
                        goto LABEL_14;
                    case 3:
                    case 6:
                    case 7:
                    case 0xA:
                        lastStreamInfo.Stride += element.Size;
                        break;
                    default:
                        LABEL_14:
                        lastStreamInfo.Stride += (uint)(size * element.Size);
                        break;
                }
            }

            var maxStreamIndex = element.Stream;
            if (maxStreamIndex > this.MaxStreamIndex)
            {
                this.MaxStreamIndex = maxStreamIndex;
            }
        }
    }
}
