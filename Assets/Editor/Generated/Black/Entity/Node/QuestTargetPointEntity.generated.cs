using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class QuestTargetPointEntity : Black.Entity.Node.PointNodeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint destinationEntryId_;
		public int markerOffsetPixel_;
		public uint groupNumberId_;
		public int markerType_;
		public float radius_;
		public uint questId_;
		public uint questEntryId_;
		public uint mapId_;
		public string memo_= string.Empty;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new QuestTargetPointEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.QuestTargetPointEntity", 0, Black.Entity.Node.QuestTargetPointEntity.ObjectType, Construct, properties, 0, 368);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Entity.Node.QuestTargetPointEntity", base.GetFieldProperties(), -1696469695, 1476568926);
            
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entitySearchLabelId_", 3840219358, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("jointId_", 3429568351, "SQEX.Ebony.Std.Fixid", 256, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("destinationEntryId_", 597928265, "SQEX.Ebony.Std.Fixid", 304, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("markerOffsetPixel_", 3106531449, "int32_t", 308, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupNumberId_", 1781596949, "SQEX.Ebony.Std.Fixid", 312, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("markerType_", 517034512, "Black.Actor.DESTINATION_MARKER", 316, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("radius_", 2286360452, "float", 320, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("questId_", 3545666453, "SQEX.Ebony.Std.Fixid", 324, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("questEntryId_", 1381400299, "SQEX.Ebony.Std.Fixid", 328, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("mapId_", 1232238433, "SQEX.Ebony.Std.Fixid", 332, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("memo_", 3571411732, "Ebony.Base.String", 336, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new QuestTargetPointEntity();
        }
		
    }
}