using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Operator
{
    public partial class SequenceOperatorScreenPositionAlign : Black.Sequence.Operator.SequenceOperatorCalculateBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputValuePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputValue_;
		public int align_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceOperatorScreenPositionAlign();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Operator.SequenceOperatorScreenPositionAlign", 0, Black.Sequence.Operator.SequenceOperatorScreenPositionAlign.ObjectType, Construct, properties, 0, 320);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Operator.SequenceOperatorScreenPositionAlign", base.GetFieldProperties(), 980604949, 449822137);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("inputValuePin_.pinName_", 3951781431, "Base.String", 144, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inputValuePin_.name_", 3208503266, "Base.String", 160, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inputValuePin_.connections_", 711615536, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 176, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("inputValuePin_.pinValueType_", 3717016939, "Base.String", 208, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outputValue_.pinName_", 1332032657, "Base.String", 232, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outputValue_.name_", 67830092, "Base.String", 248, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outputValue_.connections_", 1068318418, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 264, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outputValue_.pinValueType_", 2971852705, "Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("inputValuePin_", 235825496, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 136, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputValue_", 232220166, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 224, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("align_", 3873481747, "Black.Sequence.Operator.SequenceOperatorScreenPositionAlign.ScreenPositionAlign", 312, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceOperatorScreenPositionAlign();
        }
		
    }
}