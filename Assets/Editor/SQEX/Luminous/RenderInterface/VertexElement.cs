using System;
using System.Diagnostics;

namespace SQEX.Luminous.RenderInterface
{
    [DebuggerDisplay("{SemanticName}")]
    public class VertexElement
    {
        public byte Stream { get; }
        public byte Type { get; }
        public byte Usage { get; }
        public byte InstancingFlag { get; }
        public ushort Offset { get; }
        public ushort Size { get; }
        public string SemanticName { get; }
        public uint SemanticIndex { get; }
        
        public VertexElement(byte stream, byte type, byte usage, byte instancingFlag, ushort offset, ushort size, string semanticName, uint semanticIndex)
        {
            this.Stream = stream;
            this.Type = type;
            this.Usage = usage;
            this.InstancingFlag = instancingFlag;
            this.Offset = offset;
            this.Size = size;
            this.SemanticName = semanticName;
            this.SemanticIndex = semanticIndex;
        }
    }
}
