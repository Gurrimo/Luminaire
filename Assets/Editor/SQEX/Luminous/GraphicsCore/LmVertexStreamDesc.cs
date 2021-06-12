using SQEX.Luminous.GraphicsLoad;
using System;

namespace SQEX.Luminous.GraphicsCore
{
    public enum LmEVertexStreamSlot
    {
        Slot_0 = 0x0,
        Slot_1 = 0x1,
        Slot_2 = 0x2,
        Slot_3 = 0x3,
        Slot_Num = 0x4,
    }

    public enum LmEVertexStreamType
    {
        Vertex = 0x0,
        Instance = 0x1,
        Index = 0x2,
        Patch = 0x3,
        Num = 0x4,
        Dummy = 0xFF,
    }

    public class LmVertexStreamDesc
    {
        public LmEVertexStreamSlot Slot { get; }
        public LmEVertexStreamType Type { get; }

        public LmStructuredVertexBufferDesc StructuredVBDesc { get; }

        private LmVertexStreamDesc(LmEVertexStreamSlot slot, LmEVertexStreamType type, LmStructuredVertexBufferDesc structuredVertexBufferDesc)
        {
            this.Slot = slot;
            this.Type = type;
            this.StructuredVBDesc = structuredVertexBufferDesc;
        }

        public static LmVertexStreamDesc Unpack(LmMsgPck msg)
        {
            var slot = (LmEVertexStreamSlot)msg.ReadUint();
            var type = (LmEVertexStreamType)msg.ReadUint();
            var desc = LmStructuredVertexBufferDesc.Unpack(msg);

            return new LmVertexStreamDesc(slot, type, desc);
        }
    }
}
