using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Chocobo
{
    public partial class SaveChocoboStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public sbyte name_;
		public int flag_;
		public Black.Save.Multiplay.SaveChocoboDataStruct multiChocoboData_;
		public bool effectedEntitlement_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveChocoboStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Chocobo.SaveChocoboStruct", 0, Black.Save.Chocobo.SaveChocoboStruct.ObjectType, null, properties, 0, 1748);
        }
		
        public  ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected  PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Save.Chocobo.SaveChocoboStruct", null, 423255878, 1837290904);
            
			fieldProperties.AddProperty(new Property("name_", 182823483, "char", 0, 256, 256, Property.PrimitiveType.Int8, 0, (char)8));
			fieldProperties.AddProperty(new Property("flag_", 2154253848, "uint32_t", 256, 512, 128, Property.PrimitiveType.Int32, 0, (char)8));
			fieldProperties.AddProperty(new Property("multiChocoboData_", 3709650808, "Black.Save.Multiplay.SaveChocoboDataStruct", 768, 928, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("effectedEntitlement_", 2870207469, "bool", 1696, 50, 50, Property.PrimitiveType.Bool, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}