using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.System
{
    public partial class SequenceActionResetScoreNOX : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin pinOut_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionResetScoreNOX();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.System.SequenceActionResetScoreNOX", 0, Black.Sequence.Action.System.SequenceActionResetScoreNOX.ObjectType, Construct, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.System.SequenceActionResetScoreNOX", base.GetFieldProperties(), 177973336, -584606730);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinIn_.pinName_", 2526891923, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinIn_.name_", 4217509502, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinIn_.connections_", 2452413796, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pinIn_.delayType_", 687492618, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 248, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinIn_.delayTime_", 1681906397, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinIn_.delayMaxTime_", 3182105257, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinOut_.pinName_", 3987307508, "Base.String", 280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinOut_.name_", 1989875983, "Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinOut_.connections_", 1949367711, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 312, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pinOut_.delayType_", 1110488073, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 344, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinOut_.delayTime_", 3181206670, "float", 348, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pinOut_.delayMaxTime_", 939163492, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("pinIn_", 343869980, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinOut_", 3329024485, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionResetScoreNOX();
        }
		
    }
}