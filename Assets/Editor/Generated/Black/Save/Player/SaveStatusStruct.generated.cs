using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Player
{
    public partial class SaveStatusStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id;
		public int party_index;
		public bool join;
		public bool joined;
		public int sortie;
		public bool disable_sortie;
		public bool menu_invisible;
		public bool immortal;
		public bool pinch_available;
		public bool damage_limit_over;
		public bool parameter_limit_over;
		public int pinch_time;
		public int pinch_no_hit_time;
		public int pinch_recover_no_hit_time;
		public bool recover_non_battle_only;
		public int hp;
		public int hp_max;
		public int maximum_hp_max;
		public int minimum_hp_max;
		public int maximum_hp_max_buffer;
		public int ratio_minimum_hp_max;
		public int ratio_auto_recover_hp;
		public int ratio_pinch_damage_hp_max;
		public int ratio_poison_damage_hp;
		public int ratio_poison_damage_hp_max;
		public int ratio_pinch_poison_hp_max;
		public int ratio_deadly_poison_damage_hp;
		public int ratio_burning_damage_hp;
		public int ratio_frigid_damage_hp;
		public int ratio_ring_damage_hp;
		public int ratio_auto_recover_mp;
		public int ratio_armed_form_use_mp;
		public int ratio_death_use_mp;
		public int ratio_holy_use_mp;
		public float death_sentence;
		public int hp_bonus;
		public int mp;
		public int mp_max;
		public float ep;
		public float ep_max;
		public float stamina;
		public float stamina_max;
		public int level;
		public int level_cap;
		public int level_max;
		public int strength;
		public int vitality;
		public int magic;
		public int spirit;
		public int critical;
		public int element_attack;
		public int element_absorption;
		public int element_invalidity;
		public short element_tolerance;
		public int status_auto;
		public int status;
		public sbyte status_attack;
		public sbyte status_defence;
		public long status_count_auto;
		public sbyte status_count;
		public sbyte status_count_attack;
		public sbyte status_count_attack_time;
		public sbyte status_count_defence;
		public short status_count_time;
		public float status_count_delta_time;
		public sbyte status_count_record;
		public int buff_registration_count;
		public Black.Save.Player.SaveBuffStruct buff;
		public int buff_count;
		public float buff_time;
		public float start_buff_time;
		public float mp_burst_time;
		public float mp_burst_time_max;
		public float element_damage_time;
		public int weapon_use_number;
		public int weapon_slot_amount;
		public int knights_of_eos;
		public bool age;
		public bool injured;
		public bool child;
		public bool miners;
		public bool first_person;
		public bool friend_control;
		public bool jacket_off;
		public bool tears;
		public bool ring;
		public bool ability_available;
		public float dirty;
		public Black.Save.Ability.SaveAbilityEquipmentStruct ability;
		public Black.Save.Ability.SaveAbilityEquipmentMenuStruct ability_menu;
		public Black.Save.Equipment.SaveWeaponEquipmentStruct weapon;
		public Black.Save.Ability.SaveJobCommandEquipmentStruct job_command;
		public Black.Save.Equipment.SaveWeaponEquipmentStruct accessory;
		public Black.Save.Equipment.SaveClothEquipmentStruct cloth;
		public int reserve1;
		public int reserve2;
		public int reserve3;
		public int reserve4;
		public int reserve5;
		public int reserve6;
		public int reserve7;
		public int reserve8;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveStatusStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Player.SaveStatusStruct", 0, Black.Save.Player.SaveStatusStruct.ObjectType, null, properties, 0, 1536);
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

            fieldProperties = new PropertyContainer("Black.Save.Player.SaveStatusStruct", null, -1930500420, -1712780495);
            
			fieldProperties.AddIndirectlyProperty(new Property("job_command.id", 547597205, "SQEX.Ebony.Std.Fixid", 1432, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("job_command.bank_number", 3319982122, "int", 1436, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("id", 926444256, "SQEX.Ebony.Std.Fixid", 0, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("party_index", 1869290068, "int32_t", 4, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("join", 3374496889, "bool", 8, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("joined", 152899664, "bool", 9, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("sortie", 2584559031, "Black.Actor.SORTIE_STATUS", 12, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("disable_sortie", 486021434, "bool", 16, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("menu_invisible", 2267844742, "bool", 17, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("immortal", 854911780, "bool", 18, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinch_available", 485798323, "bool", 19, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("damage_limit_over", 3306206971, "bool", 20, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("parameter_limit_over", 444416971, "bool", 21, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinch_time", 1463619009, "int32_t", 24, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinch_no_hit_time", 2925924431, "int32_t", 28, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinch_recover_no_hit_time", 1693836952, "int32_t", 32, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("recover_non_battle_only", 1955976865, "bool", 36, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("hp", 1362809445, "int32_t", 40, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("hp_max", 1388773552, "int32_t", 44, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("maximum_hp_max", 2092205183, "int32_t", 48, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("minimum_hp_max", 1781830129, "int32_t", 52, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("maximum_hp_max_buffer", 4126579098, "int32_t", 56, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ratio_minimum_hp_max", 2619747581, "int32_t", 60, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ratio_auto_recover_hp", 1763823846, "int32_t", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ratio_pinch_damage_hp_max", 1516474371, "int32_t", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ratio_poison_damage_hp", 3747588836, "int32_t", 72, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ratio_poison_damage_hp_max", 4076670565, "int32_t", 76, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ratio_pinch_poison_hp_max", 2961720124, "int32_t", 80, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ratio_deadly_poison_damage_hp", 3952976900, "int32_t", 84, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ratio_burning_damage_hp", 1562861033, "int32_t", 88, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ratio_frigid_damage_hp", 1197349825, "int32_t", 92, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ratio_ring_damage_hp", 2382513946, "int32_t", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ratio_auto_recover_mp", 1998166059, "int32_t", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ratio_armed_form_use_mp", 888633657, "int32_t", 104, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ratio_death_use_mp", 2456214731, "int32_t", 108, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ratio_holy_use_mp", 4234673981, "int32_t", 112, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("death_sentence", 3324331635, "float", 116, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("hp_bonus", 1430366209, "int32_t", 120, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("mp", 1395526040, "int32_t", 124, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("mp_max", 1167887001, "int32_t", 128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ep", 1125804208, "float", 132, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ep_max", 903585249, "float", 136, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("stamina", 3875003702, "float", 140, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("stamina_max", 1784260771, "float", 144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("level", 2610554845, "uint32_t", 148, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("level_cap", 677655838, "uint32_t", 152, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("level_max", 2848748920, "uint32_t", 156, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("strength", 3766098096, "int32_t", 160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("vitality", 756208663, "int32_t", 164, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("magic", 3840615820, "int32_t", 168, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("spirit", 3325022696, "int32_t", 172, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("critical", 1364460424, "int32_t", 176, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("element_attack", 2956819876, "uint32_t", 180, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("element_absorption", 1280338017, "uint32_t", 184, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("element_invalidity", 2989634389, "uint32_t", 188, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("element_tolerance", 3966152231, "int16_t", 192, 34, 17, Property.PrimitiveType.Int16, 0, (char)8));
			fieldProperties.AddProperty(new Property("status_auto", 3797830263, "uint32_t", 228, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("status", 3125508079, "uint32_t", 232, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("status_attack", 4244482092, "uint8_t", 236, 8, 8, Property.PrimitiveType.Int8, 0, (char)8));
			fieldProperties.AddProperty(new Property("status_defence", 2883988108, "uint8_t", 244, 8, 8, Property.PrimitiveType.Int8, 0, (char)8));
			fieldProperties.AddProperty(new Property("status_count_auto", 458626631, "uint64_t", 256, 8, 1, Property.PrimitiveType.Int64, 0, (char)0));
			fieldProperties.AddProperty(new Property("status_count", 1326324607, "int8_t", 264, 64, 64, Property.PrimitiveType.Int8, 0, (char)8));
			fieldProperties.AddProperty(new Property("status_count_attack", 4011219004, "uint8_t", 328, 64, 64, Property.PrimitiveType.Int8, 0, (char)8));
			fieldProperties.AddProperty(new Property("status_count_attack_time", 3370233104, "int8_t", 392, 64, 64, Property.PrimitiveType.Int8, 0, (char)8));
			fieldProperties.AddProperty(new Property("status_count_defence", 1297773884, "uint8_t", 456, 64, 64, Property.PrimitiveType.Int8, 0, (char)8));
			fieldProperties.AddProperty(new Property("status_count_time", 2801608217, "uint16_t", 520, 128, 64, Property.PrimitiveType.Int16, 0, (char)8));
			fieldProperties.AddProperty(new Property("status_count_delta_time", 1344290514, "float", 648, 256, 64, Property.PrimitiveType.Float, 0, (char)8));
			fieldProperties.AddProperty(new Property("status_count_record", 4056471397, "uint8_t", 904, 64, 64, Property.PrimitiveType.Int8, 0, (char)8));
			fieldProperties.AddProperty(new Property("buff_registration_count", 3262282384, "int32_t", 968, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("buff", 1244307660, "Black.Save.Player.SaveBuffStruct", 972, 24, 3, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("buff_count", 3990091536, "int32_t", 996, 228, 57, Property.PrimitiveType.Int32, 0, (char)8));
			fieldProperties.AddProperty(new Property("buff_time", 1938903296, "float", 1224, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("start_buff_time", 1809496763, "float", 1228, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("mp_burst_time", 644516507, "float", 1232, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("mp_burst_time_max", 3016775722, "float", 1236, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("element_damage_time", 2293966963, "float", 1240, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("weapon_use_number", 3140883411, "Black.Actor.WEAPON_ATTACK", 1244, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("weapon_slot_amount", 2550146711, "int32_t", 1248, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("knights_of_eos", 3503734577, "int32_t", 1252, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("age", 742476188, "bool", 1256, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("injured", 3434601530, "bool", 1257, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("child", 3852476509, "bool", 1258, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("miners", 141206125, "bool", 1259, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("first_person", 32872551, "bool", 1260, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("friend_control", 174022651, "bool", 1261, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("jacket_off", 1091823313, "bool", 1262, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("tears", 4232364470, "bool", 1263, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("ring", 4149934955, "bool", 1264, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("ability_available", 2396617017, "bool", 1265, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("dirty", 2667581083, "float", 1268, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ability", 3471506833, "Black.Save.Ability.SaveAbilityEquipmentStruct", 1272, 64, 8, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("ability_menu", 1908737677, "Black.Save.Ability.SaveAbilityEquipmentMenuStruct", 1336, 32, 8, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("weapon", 1865621569, "Black.Save.Equipment.SaveWeaponEquipmentStruct", 1368, 64, 4, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("job_command", 2134253846, "Black.Save.Ability.SaveJobCommandEquipmentStruct", 1432, 8, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("accessory", 1164796377, "Black.Save.Equipment.SaveWeaponEquipmentStruct", 1440, 48, 3, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("cloth", 214487563, "Black.Save.Equipment.SaveClothEquipmentStruct", 1488, 12, 1, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("reserve1", 532037902, "int32_t", 1500, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve2", 515260283, "int32_t", 1504, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve3", 498482664, "int32_t", 1508, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve4", 615925997, "int32_t", 1512, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve5", 599148378, "int32_t", 1516, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve6", 582370759, "int32_t", 1520, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve7", 565593140, "int32_t", 1524, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve8", 414594569, "int32_t", 1528, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}