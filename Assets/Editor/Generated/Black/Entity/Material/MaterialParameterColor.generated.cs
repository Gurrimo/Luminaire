using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Material
{
    public partial class MaterialParameterColor : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string materialName_= string.Empty;
		public string name_= string.Empty;
		public UnityEngine.Color color_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MaterialParameterColor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Material.MaterialParameterColor", 0, Black.Entity.Material.MaterialParameterColor.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.Entity.Material.MaterialParameterColor", base.GetFieldProperties(), 876329529, -1699221965);
            
			
			
			fieldProperties.AddProperty(new Property("materialName_", 3099305108, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("name_", 182823483, "Ebony.Base.String", 24, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("color_", 3572781317, "Luminous.RenderInterface.Color", 48, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}