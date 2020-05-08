using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Parameter
{
    public partial class ParameterInt : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string name_= string.Empty;
		public int value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ParameterInt();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Parameter.ParameterInt", 0, Black.Entity.Parameter.ParameterInt.ObjectType, Construct, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.Entity.Parameter.ParameterInt", base.GetFieldProperties(), -1283433872, 1429672875);
            
			
			
			fieldProperties.AddProperty(new Property("name_", 182823483, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("value_", 273093519, "int", 24, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new ParameterInt();
        }
		
    }
}