//----------------------
// <auto-generated>
// This file was automatically generated. Any changes to it will be lost if and when the file is regenerated.
// </auto-generated>
//----------------------
#pragma warning disable

using System;
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;
using CodeDom = System.CodeDom;

namespace Black.Save.Equipment
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class SaveWeaponStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id;
		public bool reserve_flag;
		public bool exist;
		public bool new_flag;
		public int equipment;
		public int equipment_weapon_bank_number;
		public uint name_id;
		public int type;
		public int rank;
		public int strength;
		public int vitality;
		public int critical;
		public int recover_mp;
		public int slot;
		[UnityEngine.SerializeReference] public Black.Save.Ability.SaveAbilityEquipmentStruct ability= new Black.Save.Ability.SaveAbilityEquipmentStruct();
		[UnityEngine.SerializeReference] public Black.Save.Ability.SaveAbilityEquipmentStruct resident_ability= new Black.Save.Ability.SaveAbilityEquipmentStruct();
		public int status_adjust;
		public int remodel_fail_count;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveWeaponStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Equipment.SaveWeaponStruct", 0, Black.Save.Equipment.SaveWeaponStruct.ObjectType, null, properties, 0, 152);
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

            fieldProperties = new PropertyContainer("Black.Save.Equipment.SaveWeaponStruct", null, -743336271, -1839223059);
            
			
			
			fieldProperties.AddProperty(new Property("id", 926444256, "SQEX.Ebony.Std.Fixid", 0, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve_flag", 3857446022, "bool", 4, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("exist", 456138012, "bool", 5, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("new_flag", 1714979188, "bool", 6, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("equipment", 3463588087, "Black.Save.SAVE_PLAYER", 8, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("equipment_weapon_bank_number", 175130021, "int32_t", 12, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("name_id", 3355607158, "SQEX.Ebony.Std.Fixid", 16, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("type", 1361572173, "Black.Actor.WEAPON_TYPE", 20, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("rank", 2895879719, "int32_t", 24, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("strength", 3766098096, "int32_t", 28, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("vitality", 756208663, "int32_t", 32, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("critical", 1364460424, "int32_t", 36, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("recover_mp", 1250591417, "int32_t", 40, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("slot", 1888831345, "int32_t", 44, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ability", 3471506833, "Black.Save.Ability.SaveAbilityEquipmentStruct", 48, 16, 2, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("resident_ability", 1649238992, "Black.Save.Ability.SaveAbilityEquipmentStruct", 64, 8, 1, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("status_adjust", 3367186719, "int32_t", 72, 76, 19, Property.PrimitiveType.Int32, 0, (char)8));
			fieldProperties.AddProperty(new Property("remodel_fail_count", 256344970, "int32_t", 148, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}