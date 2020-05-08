using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class TriggerEntityMenuSelect : Black.Entity.Node.TriggerEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint titleMessageId_;
		public int userNumber0_;
		public int userNumber1_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TriggerEntityMenuSelect();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.TriggerEntityMenuSelect", 0, Black.Entity.Node.TriggerEntityMenuSelect.ObjectType, Construct, properties, 0, 496);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.TriggerEntityMenuSelect", base.GetFieldProperties(), -710780406, -1870404225);
            
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entitySearchLabelId_", 3840219358, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("jointId_", 3429568351, "SQEX.Ebony.Std.Fixid", 256, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("eventId_", 548562519, "SQEX.Ebony.Std.Fixid", 288, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("eventString_", 3649127407, "Ebony.Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("triggerType_", 1915532364, "Black.Actor.Node.ActorNodeTriggerBase.TriggerType", 312, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("touchTarget_", 2447709882, "Black.Actor.Node.ActorNodeTrigger.TouchTarget", 316, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("characterSelectID_", 4004084206, "Black.Entity.Node.TriggerEntityBase.CharacterSelectID", 320, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("CharaParamIDList", 2063779448, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem* >", 328, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddIndirectlyProperty(new Property("touchStatus_", 1525396607, "Black.Actor.Node.ActorNodeTriggerBase.TouchStatus", 344, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("touchStatus2_", 2553285, "Black.Actor.Node.ActorNodeTriggerBase.TouchStatus", 348, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("touchStatus3_", 1076467996, "Black.Actor.Node.ActorNodeTriggerBase.TouchStatus", 352, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("touchStatus4_", 3539023, "Black.Actor.Node.ActorNodeTriggerBase.TouchStatus", 356, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("scaling_", 3325430311, "Luminous.Math.VectorA", 368, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("radius_", 2286360452, "float", 384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("height_", 2527956647, "float", 388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("depth_", 1210636015, "float", 392, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("width_", 2754776768, "float", 396, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("count_", 2113926193, "int", 400, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enableTrigger_", 1936258923, "bool", 404, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("color_", 3572781317, "Luminous.RenderInterface.Color", 416, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkInSameScene_", 2455832991, "bool", 432, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("scaleTriggerWithParent_", 586178736, "bool", 433, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("eventType_", 1538691464, "Black.Actor.Node.ActorNodeTrigger.EventIDType", 448, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("groupName_", 1077907880, "Ebony.Base.String", 456, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isNoCheckFirst_", 3173671949, "bool", 472, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isNoCheckAtUCOff_", 1689466785, "bool", 473, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isSetEventModeAtTouch_", 253457879, "bool", 474, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("touchKind_", 3257180047, "Black.Actor.Node.ActorNodeTrigger.TouchKind", 476, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("titleMessageId_", 1829287686, "Fixid", 480, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("userNumber0_", 3950007686, "uint32_t", 484, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("userNumber1_", 3949860591, "uint32_t", 488, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new TriggerEntityMenuSelect();
        }
		
    }
}