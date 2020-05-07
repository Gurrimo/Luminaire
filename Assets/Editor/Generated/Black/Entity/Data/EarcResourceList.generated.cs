using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data
{
    public partial class EarcResourceList : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string filePath_;
		public string filePathOnlyPC_;
		public bool isAutoLoad_;
		public bool isEarcExternal_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new EarcResourceList();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.EarcResourceList", 0, Black.Entity.Data.EarcResourceList.ObjectType, null, properties, 0, 104);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.EarcResourceList", base.GetFieldProperties(), -2101560215, 335287790);
            
			fieldProperties.AddProperty(new Property("filePath_", 956091201, "Ebony.Base.String", 64, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("filePathOnlyPC_", 3794276572, "Ebony.Base.String", 80, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("isAutoLoad_", 2729930715, "bool", 96, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEarcExternal_", 1772276072, "bool", 97, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}