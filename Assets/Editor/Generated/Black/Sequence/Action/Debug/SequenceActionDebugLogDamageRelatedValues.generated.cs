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

namespace Black.Sequence.Action.Debug
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class SequenceActionDebugLogDamageRelatedValues : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphTriggerInputPin trigger_= new SQEX.Ebony.Framework.Node.GraphTriggerInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin noEnemy= new SQEX.Ebony.Framework.Node.GraphTriggerOutputPin();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugLogDamageRelatedValues();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.SequenceActionDebugLogDamageRelatedValues", 0, Black.Sequence.Action.Debug.SequenceActionDebugLogDamageRelatedValues.ObjectType, Construct, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.SequenceActionDebugLogDamageRelatedValues", base.GetFieldProperties(), 1413084776, 461752556);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("trigger_.pinName_", 3299755579, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("trigger_.name_", 3567949366, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("trigger_.connections_", 3345461836, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("trigger_.delayType_", 1487916098, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 248, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("trigger_.delayTime_", 2706312773, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("trigger_.delayMaxTime_", 3001762273, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("noEnemy.pinName_", 524292785, "Base.String", 280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("noEnemy.name_", 1678942892, "Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("noEnemy.connections_", 1575053618, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 312, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("noEnemy.delayType_", 2525643472, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 344, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("noEnemy.delayTime_", 3090495419, "float", 348, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("noEnemy.delayMaxTime_", 3755340707, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("trigger_", 4053944020, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noEnemy", 2550525350, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionDebugLogDamageRelatedValues();
        }
		
    }
}