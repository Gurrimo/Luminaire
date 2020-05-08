using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data
{
    public partial class CharaEntryIDResource : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string id_= string.Empty;
		public string searchParamTable_= string.Empty;
		public string ebexPathKey_= string.Empty;
		public string idKey_= string.Empty;
		public bool isAutoLoad_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CharaEntryIDResource();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.CharaEntryIDResource", 0, Black.Entity.Data.CharaEntryIDResource.ObjectType, null, properties, 0, 136);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.CharaEntryIDResource", base.GetFieldProperties(), -1939571237, -2141369144);
            
			
			
			fieldProperties.AddProperty(new Property("id_", 2899315373, "Ebony.Base.String", 64, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("searchParamTable_", 1554872927, "Ebony.Base.String", 80, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("ebexPathKey_", 2142041700, "Ebony.Base.String", 96, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("idKey_", 1661218624, "Ebony.Base.String", 112, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("isAutoLoad_", 2729930715, "bool", 128, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}