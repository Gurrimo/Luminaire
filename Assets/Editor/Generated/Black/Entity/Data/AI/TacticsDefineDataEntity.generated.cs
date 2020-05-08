using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.AI
{
    public partial class TacticsDefineDataEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string name_= string.Empty;
		public string role1_= string.Empty;
		public int num1_;
		public string role2_= string.Empty;
		public int num2_;
		public string role3_= string.Empty;
		public int num3_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TacticsDefineDataEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.AI.TacticsDefineDataEntity", 0, Black.Entity.Data.AI.TacticsDefineDataEntity.ObjectType, Construct, properties, 0, 168);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.AI.TacticsDefineDataEntity", base.GetFieldProperties(), -795094482, -305559889);
            
			
			
			fieldProperties.AddProperty(new Property("name_", 182823483, "Ebony.Base.String", 64, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("role1_", 820126437, "Ebony.Base.String", 80, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("num1_", 3346845947, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("role2_", 820670890, "Ebony.Base.String", 104, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("num2_", 2272931236, "int", 120, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("role3_", 4041723475, "Ebony.Base.String", 128, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("num3_", 2272784141, "int", 144, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new TacticsDefineDataEntity();
        }
		
    }
}