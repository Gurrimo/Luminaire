using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerActorCreateSyncEvent : Black.Sequence.MultiPlayer.SequenceMultiPlayerSyncEventBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueUniqueId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueAreaId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueGroupId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueUniqueId_;
		public uint uniqueFilterId_;
		public bool ignoreSamePeerId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerActorCreateSyncEvent();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerActorCreateSyncEvent", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerActorCreateSyncEvent.ObjectType, Construct, properties, 0, 776);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerActorCreateSyncEvent", base.GetFieldProperties(), -63061391, 1307896552);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("wakeUp_", 1545670293, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("wakeUp_.pinName_", 3985577540, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("wakeUp_.name_", 228058719, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("wakeUp_.connections_", 4265741839, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("wakeUp_.delayType_", 3004831161, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 248, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("wakeUp_.delayTime_", 4159864830, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("wakeUp_.delayMaxTime_", 906834708, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("options_", 1990430094, "Black.Sequence.MultiPlayer.SequenceMultiPlayerSyncEventBase.sendOption", 272, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("forCreateOnlyFixid_", 1127113041, "SQEX.Ebony.Std.Fixid", 276, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isOutputLog_", 3733482875, "bool", 280, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inValueUniqueId_.pinName_", 1282060221, "Base.String", 304, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inValueUniqueId_.name_", 3494385608, "Base.String", 320, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inValueUniqueId_.connections_", 1226887686, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 336, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("inValueUniqueId_.pinValueType_", 4100749325, "Base.String", 368, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueActor_.pinName_", 2543979617, "Base.String", 392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueActor_.name_", 4062846236, "Base.String", 408, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueActor_.connections_", 622063362, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 424, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outValueActor_.pinValueType_", 2474144625, "Base.String", 456, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueAreaId_.pinName_", 2139003948, "Base.String", 480, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueAreaId_.name_", 730773143, "Base.String", 496, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueAreaId_.connections_", 3410690423, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 512, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outValueAreaId_.pinValueType_", 2649104538, "Base.String", 544, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueGroupId_.pinName_", 495353754, "Base.String", 568, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueGroupId_.name_", 4013835365, "Base.String", 584, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueGroupId_.connections_", 1207153149, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 600, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outValueGroupId_.pinValueType_", 2210109164, "Base.String", 632, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueUniqueId_.pinName_", 1407558046, "Base.String", 656, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueUniqueId_.name_", 2444014169, "Base.String", 672, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValueUniqueId_.connections_", 461414057, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 688, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outValueUniqueId_.pinValueType_", 2771478288, "Base.String", 720, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("inValueUniqueId_", 220492394, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 296, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueActor_", 2821532918, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 384, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueAreaId_", 3697629069, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 472, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueGroupId_", 1792074959, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 560, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueUniqueId_", 1254290315, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 648, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("uniqueFilterId_", 1611340006, "SQEX.Ebony.Std.Fixid", 736, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("ignoreSamePeerId_", 262364817, "bool", 740, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceMultiPlayerActorCreateSyncEvent();
        }
		
    }
}