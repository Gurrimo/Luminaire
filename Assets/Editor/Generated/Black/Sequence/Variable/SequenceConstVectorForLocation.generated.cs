using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceConstVectorForLocation : SQEX.Ebony.Framework.Sequence.Variable.SequenceConstVector
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceConstVectorForLocation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceConstVectorForLocation", 0, Black.Sequence.Variable.SequenceConstVectorForLocation.ObjectType, Construct, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceConstVectorForLocation", base.GetFieldProperties(), 144690666, -1877410178);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("outZ_", 1988621440, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 88, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outZ_.pinName_", 2199646671, "Base.String", 96, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outZ_.name_", 194771114, "Base.String", 112, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outZ_.connections_", 306169384, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 128, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outZ_.pinValueType_", 3307115955, "Base.String", 160, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outY_", 3062536151, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outY_.pinName_", 3642470002, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outY_.name_", 4054272557, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outY_.connections_", 1981142293, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outY_.pinValueType_", 1129792660, "Base.String", 248, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outX_", 1989018798, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 264, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outX_.pinName_", 4013851593, "Base.String", 272, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outX_.name_", 2017735124, "Base.String", 288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outX_.connections_", 3902346794, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 304, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outX_.pinValueType_", 2584925961, "Base.String", 336, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 352, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.pinName_", 1137295951, "Base.String", 360, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.name_", 2182257194, "Base.String", 376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.connections_", 2048532136, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 392, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("out_.pinValueType_", 3252152115, "Base.String", 424, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("value_", 273093519, "Luminous.Math.VectorA", 448, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			
			
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceConstVectorForLocation();
        }
		
    }
}