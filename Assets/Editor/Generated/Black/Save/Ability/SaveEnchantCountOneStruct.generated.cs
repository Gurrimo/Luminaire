using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Ability
{
    public partial class SaveEnchantCountOneStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int ability_id;
		public int ability_effect;
		public Black.Save.Ability.SaveAbilityCountOneStruct ability;
		public uint attack_id;
		public int effect;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEnchantCountOneStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Ability.SaveEnchantCountOneStruct", 0, Black.Save.Ability.SaveEnchantCountOneStruct.ObjectType, null, properties, 0, 20);
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

            fieldProperties = new PropertyContainer("Black.Save.Ability.SaveEnchantCountOneStruct", null, 206926160, -406515321);
            
			fieldProperties.AddIndirectlyProperty(new Property("ability.count", 970159372, "int16_t", 8, 2, 1, Property.PrimitiveType.Int16, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("ability.weapon_attack", 2274627758, "uint16_t", 10, 2, 1, Property.PrimitiveType.Int16, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("ability_id", 1929600199, "Black.Actor.ABILITY", 0, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("ability_effect", 1637282071, "Black.Actor.ABILITY_EFFECT", 4, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("ability", 3471506833, "Black.Save.Ability.SaveAbilityCountOneStruct", 8, 4, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("attack_id", 3817258651, "SQEX.Ebony.Std.Fixid", 12, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("effect", 1852738900, "int32_t", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}