using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Ability
{
    public partial class SaveAbilityCountOneStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public short count;
		public short weapon_attack;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveAbilityCountOneStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Ability.SaveAbilityCountOneStruct", 0, Black.Save.Ability.SaveAbilityCountOneStruct.ObjectType, null, properties, 0, 4);
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

            fieldProperties = new PropertyContainer("Black.Save.Ability.SaveAbilityCountOneStruct", null, -952661298, -1206995692);
            
			fieldProperties.AddProperty(new Property("count", 967958004, "int16_t", 0, 2, 1, Property.PrimitiveType.Int16, 0, (char)0));
			fieldProperties.AddProperty(new Property("weapon_attack", 877449430, "uint16_t", 2, 2, 1, Property.PrimitiveType.Int16, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}