using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Equipment
{
    public partial class SaveEquipmentStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.Save.Equipment.SaveWeaponStruct weapon;
		public Black.Save.Equipment.SaveWeaponStruct phantom_sword;
		public Black.Save.Equipment.SaveWeaponStruct accessory;
		public Black.Save.Equipment.SaveClothStruct cloth;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEquipmentStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Equipment.SaveEquipmentStruct", 0, Black.Save.Equipment.SaveEquipmentStruct.ObjectType, null, properties, 0, 325744);
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

            fieldProperties = new PropertyContainer("Black.Save.Equipment.SaveEquipmentStruct", null, 1708704790, -1832760777);
            
			
			
			fieldProperties.AddProperty(new Property("weapon", 1865621569, "Black.Save.Equipment.SaveWeaponStruct", 0, 153824, 1012, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("phantom_sword", 1002990004, "Black.Save.Equipment.SaveWeaponStruct", 153824, 3952, 26, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("accessory", 1164796377, "Black.Save.Equipment.SaveWeaponStruct", 157776, 153824, 1012, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("cloth", 214487563, "Black.Save.Equipment.SaveClothStruct", 311600, 14144, 104, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}