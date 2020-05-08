using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Render
{
    public partial class BokehIrisTextureEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		public string sourcePath_= string.Empty;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BokehIrisTextureEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Render.BokehIrisTextureEntity", 0, Black.Entity.Render.BokehIrisTextureEntity.ObjectType, null, properties, 0, 176);
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

            fieldProperties = new PropertyContainer("Black.Entity.Render.BokehIrisTextureEntity", base.GetFieldProperties(), -1207968520, -2081084607);
            
			
			
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 64, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourcePath_", 341055184, "Ebony.Base.String", 72, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}