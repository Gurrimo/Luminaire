using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data
{
    public partial class CharaEntryIDResource2 : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string id_;
		public string searchParamTable_;
		public string ebexPathKey_;
		public string idKey_;
		public string searchParamTable2_;
		public string ebexPathKey2_;
		public string idKey2_;
		public bool isAutoLoad_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CharaEntryIDResource2();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.CharaEntryIDResource2", 0, Black.Entity.Data.CharaEntryIDResource2.ObjectType, null, properties, 0, 184);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.CharaEntryIDResource2", base.GetFieldProperties(), -824945525, -1160790945);
            
			fieldProperties.AddProperty(new Property("id_", 2899315373, "Ebony.Base.String", 64, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("searchParamTable_", 1554872927, "Ebony.Base.String", 80, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("ebexPathKey_", 2142041700, "Ebony.Base.String", 96, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("idKey_", 1661218624, "Ebony.Base.String", 112, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("searchParamTable2_", 638403621, "Ebony.Base.String", 128, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("ebexPathKey2_", 958062084, "Ebony.Base.String", 144, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("idKey2_", 4268150680, "Ebony.Base.String", 160, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("isAutoLoad_", 2729930715, "bool", 176, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}