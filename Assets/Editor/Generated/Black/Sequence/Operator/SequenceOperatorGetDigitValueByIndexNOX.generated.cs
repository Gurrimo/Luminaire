//----------------------
// <auto-generated>
// This file was automatically generated. Any changes to it will be lost if and when the file is regenerated.
// </auto-generated>
//----------------------
#pragma warning disable

using System;
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;
using CodeDom = System.CodeDom;

namespace Black.Sequence.Operator
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class SequenceOperatorGetDigitValueByIndexNOX : Black.Sequence.Operator.SequenceOperatorCalculateBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputValuePin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputValueIndexPin_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputValue_= new SQEX.Ebony.Framework.Node.GraphVariableOutputPin();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceOperatorGetDigitValueByIndexNOX();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Operator.SequenceOperatorGetDigitValueByIndexNOX", 0, Black.Sequence.Operator.SequenceOperatorGetDigitValueByIndexNOX.ObjectType, Construct, properties, 0, 400);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Operator.SequenceOperatorGetDigitValueByIndexNOX", base.GetFieldProperties(), -2113221983, 199365275);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("inputValuePin_.pinName_", 3951781431, "Base.String", 144, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inputValuePin_.name_", 3208503266, "Base.String", 160, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inputValuePin_.connections_", 711615536, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 176, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("inputValuePin_.pinValueType_", 3717016939, "Base.String", 208, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inputValueIndexPin_.pinName_", 1909405435, "Base.String", 232, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inputValueIndexPin_.name_", 954575350, "Base.String", 248, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inputValueIndexPin_.connections_", 1226152972, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 264, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("inputValueIndexPin_.pinValueType_", 1475031503, "Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outputValue_.pinName_", 1332032657, "Base.String", 320, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outputValue_.name_", 67830092, "Base.String", 336, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outputValue_.connections_", 1068318418, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 352, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outputValue_.pinValueType_", 2971852705, "Base.String", 384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("inputValuePin_", 235825496, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 136, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inputValueIndexPin_", 2717053972, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 224, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputValue_", 232220166, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 312, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceOperatorGetDigitValueByIndexNOX();
        }
		
    }
}