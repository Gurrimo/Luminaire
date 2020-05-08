using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Node
{
    public partial class GraphOutputPin : SQEX.Ebony.Framework.Node.GraphPin
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new GraphOutputPin();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Node.GraphOutputPin", 0, SQEX.Ebony.Framework.Node.GraphOutputPin.ObjectType, Construct, properties, 0, 72);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Node.GraphOutputPin", base.GetFieldProperties(), -1732987327, 837886950);
            
			fieldProperties.AddIndirectlyProperty(new Property("pinName_", 1657142480, "Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("name_", 182823483, "Base.String", 24, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("connections_", 1444105939, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			
			
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new GraphOutputPin();
        }
		
    }
}