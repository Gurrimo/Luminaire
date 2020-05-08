using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSuppressionAreaEntity : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.Entity.Node.SuppressionAreaEntity entityPointer_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin entityOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin activeMessageOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin suppressedMessageOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin determineStatusOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin progressOut_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSuppressionAreaEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSuppressionAreaEntity", 0, Black.Sequence.Action.Level.SequenceActionSuppressionAreaEntity.ObjectType, Construct, properties, 0, 624);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSuppressionAreaEntity", base.GetFieldProperties(), -464940982, 1732895603);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entityOut_.pinName_", 2389901830, "Base.String", 192, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entityOut_.name_", 2764610705, "Base.String", 208, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entityOut_.connections_", 2989173649, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 224, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("entityOut_.pinValueType_", 3205508040, "Base.String", 256, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("activeMessageOut_.pinName_", 2544397810, "Base.String", 280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("activeMessageOut_.name_", 4122368173, "Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("activeMessageOut_.connections_", 2861501589, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 312, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("activeMessageOut_.pinValueType_", 1579787028, "Base.String", 344, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("suppressedMessageOut_.pinName_", 564204554, "Base.String", 368, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("suppressedMessageOut_.name_", 3184571605, "Base.String", 384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("suppressedMessageOut_.connections_", 1467211341, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 400, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("suppressedMessageOut_.pinValueType_", 3010573532, "Base.String", 432, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("determineStatusOut_.pinName_", 1754907792, "Base.String", 456, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("determineStatusOut_.name_", 940319995, "Base.String", 472, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("determineStatusOut_.connections_", 922501523, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 488, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("determineStatusOut_.pinValueType_", 4237531310, "Base.String", 520, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progressOut_.pinName_", 2822076186, "Base.String", 544, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progressOut_.name_", 1645804261, "Base.String", 560, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progressOut_.connections_", 377135485, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 576, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("progressOut_.pinValueType_", 572956012, "Base.String", 608, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("entityPointer_", 3527687820, "Black.Entity.Node.SuppressionAreaEntity", 176, 8, 1, Property.PrimitiveType.Pointer, 0, (char)1));
			fieldProperties.AddProperty(new Property("entityOut_", 549713923, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 184, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("activeMessageOut_", 3335436887, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("suppressedMessageOut_", 3778338271, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 360, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("determineStatusOut_", 2380942249, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 448, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("progressOut_", 2318921551, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 536, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionSuppressionAreaEntity();
        }
		
    }
}