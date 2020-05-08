using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Tray
{
    public partial class SequenceDevelopingTray : SQEX.Ebony.Framework.Sequence.Tray.SequenceScopedTray
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startDebugPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startReplayPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valuePins_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceDevelopingTray();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Tray.SequenceDevelopingTray", 0, Black.Sequence.Tray.SequenceDevelopingTray.ObjectType, Construct, properties, 0, 568);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Tray.SequenceDevelopingTray", base.GetFieldProperties(), -1688579127, -284018473);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("nodes_", 61650911, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Sequence.SequenceNode* >", 184, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("startDebugPin_.pinName_", 3094527705, "Base.String", 272, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startDebugPin_.name_", 2311543780, "Base.String", 288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startDebugPin_.connections_", 1236191130, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 304, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("startDebugPin_.delayType_", 2726126024, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 336, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startDebugPin_.delayTime_", 1077542531, "float", 340, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startDebugPin_.delayMaxTime_", 3376540411, "float", 344, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startReplayPin_.pinName_", 3686321191, "Base.String", 368, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startReplayPin_.name_", 749624850, "Base.String", 384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startReplayPin_.connections_", 4199644032, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 400, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("startReplayPin_.delayType_", 2911686230, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 432, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startReplayPin_.delayTime_", 1528133217, "float", 436, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startReplayPin_.delayMaxTime_", 2732157949, "float", 440, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valuePins_.pinName_", 2438460654, "Base.String", 464, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valuePins_.name_", 1567497065, "Base.String", 480, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valuePins_.connections_", 3582612441, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 496, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("valuePins_.pinValueType_", 1692545376, "Base.String", 528, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("startDebugPin_", 1286317534, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 264, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startReplayPin_", 4178776488, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 360, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valuePins_", 2792121211, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 456, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceDevelopingTray();
        }
		
    }
}