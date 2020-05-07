using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Equipment
{
    public partial class SaveClothStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id;
		public uint type;
		public int equipment;
		public int equipment_cloth_bank_number;
		public uint name_id;
		public bool exist;
		public bool new_flag;
		public bool jacket_off;
		public bool cap_on;
		public int occlusion_set;
		public int strength;
		public int vitality;
		public int critical;
		public int recover_mp;
		public Black.Save.Ability.SaveAbilityEquipmentStruct ability;
		public int status_adjust;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveClothStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Equipment.SaveClothStruct", 0, Black.Save.Equipment.SaveClothStruct.ObjectType, null, properties, 0, 136);
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

            fieldProperties = new PropertyContainer("Black.Save.Equipment.SaveClothStruct", null, 147862299, -367713645);
            
			fieldProperties.AddProperty(new Property("id", 926444256, "SQEX.Ebony.Std.Fixid", 0, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("type", 1361572173, "SQEX.Ebony.Std.Fixid", 4, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("equipment", 3463588087, "Black.Save.SAVE_PLAYER", 8, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("equipment_cloth_bank_number", 3981549133, "int32_t", 12, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("name_id", 3355607158, "SQEX.Ebony.Std.Fixid", 16, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("exist", 456138012, "bool", 20, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("new_flag", 1714979188, "bool", 21, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("jacket_off", 1091823313, "bool", 22, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("cap_on", 4193751029, "bool", 23, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("occlusion_set", 3398257501, "int32_t", 24, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("strength", 3766098096, "int32_t", 28, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("vitality", 756208663, "int32_t", 32, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("critical", 1364460424, "int32_t", 36, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("recover_mp", 1250591417, "int32_t", 40, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ability", 3471506833, "Black.Save.Ability.SaveAbilityEquipmentStruct", 44, 16, 2, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("status_adjust", 3367186719, "int32_t", 60, 76, 19, Property.PrimitiveType.Int32, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}