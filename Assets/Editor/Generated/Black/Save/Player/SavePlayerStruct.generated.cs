using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Player
{
    public partial class SavePlayerStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint object_entry_id;
		public uint character_entry_id;
		public uint default_character_entry_id;
		public sbyte name;
		public uint name_id;
		public Black.Save.Player.SaveStatusStruct status;
		public Black.Save.Player.SavePlayerStatusStruct player_status;
		public int weapon_type;
		public Black.Save.Ability.SaveAbilityStruct ability;
		public Black.Save.Ability.SaveAbilityCountStruct ability_count;
		public Black.Save.Ability.SaveAbilityEffectCountStruct ability_effect_count;
		public Black.Save.Ability.SaveEnchantCountStruct weapon_ability;
		public Black.Save.Ability.SaveJobCommandStruct job_command;
		public Black.Save.Ability.SaveInspirationStruct inspiration;
		public Black.Save.Ability.SaveInspirationCheckStruct inspiration_check;
		public Black.Save.Ability.SaveInspirationElementCheckStruct inspiration_element_check;
		public Black.Save.Ability.SaveSkillStruct skill;
		public Black.Save.Player.SavePlayerPositionStruct position;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SavePlayerStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Player.SavePlayerStruct", 0, Black.Save.Player.SavePlayerStruct.ObjectType, null, properties, 0, 55232);
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

            fieldProperties = new PropertyContainer("Black.Save.Player.SavePlayerStruct", null, -937167067, 1560390726);
            
			fieldProperties.AddIndirectlyProperty(new Property("status.id", 3556760478, "SQEX.Ebony.Std.Fixid", 152, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.party_index", 1958284482, "int32_t", 156, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.join", 1122010483, "bool", 160, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.joined", 3752807090, "bool", 161, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.sortie", 1158102649, "Black.Actor.SORTIE_STATUS", 164, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.disable_sortie", 675619072, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.menu_invisible", 4002277092, "bool", 169, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.immortal", 4220070002, "bool", 170, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.pinch_available", 2326194865, "bool", 171, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.damage_limit_over", 1031229565, "bool", 172, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.parameter_limit_over", 262400693, "bool", 173, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.pinch_time", 510468131, "int32_t", 176, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.pinch_no_hit_time", 2781865597, "int32_t", 180, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.pinch_recover_no_hit_time", 2273437286, "int32_t", 184, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.recover_non_battle_only", 643364331, "bool", 188, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.hp", 3456241859, "int32_t", 192, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.hp_max", 3709685410, "int32_t", 196, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.maximum_hp_max", 1819178717, "int32_t", 200, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.minimum_hp_max", 2078332963, "int32_t", 204, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.maximum_hp_max_buffer", 2118345552, "int32_t", 208, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.ratio_minimum_hp_max", 1563599787, "int32_t", 212, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.ratio_auto_recover_hp", 3251838268, "int32_t", 216, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.ratio_pinch_damage_hp_max", 2716166257, "int32_t", 220, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.ratio_poison_damage_hp", 928144794, "int32_t", 224, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.ratio_poison_damage_hp_max", 21532471, "int32_t", 228, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.ratio_pinch_poison_hp_max", 1714393510, "int32_t", 232, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.ratio_deadly_poison_damage_hp", 3509289618, "int32_t", 236, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.ratio_burning_damage_hp", 3404824663, "int32_t", 240, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.ratio_frigid_damage_hp", 3263467691, "int32_t", 244, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.ratio_ring_damage_hp", 4047692972, "int32_t", 248, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.ratio_auto_recover_mp", 3486180481, "int32_t", 252, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.ratio_armed_form_use_mp", 2615727303, "int32_t", 256, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.ratio_death_use_mp", 3279691537, "int32_t", 260, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.ratio_holy_use_mp", 4258750203, "int32_t", 264, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.death_sentence", 228381429, "float", 268, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.hp_bonus", 1281552443, "int32_t", 272, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.mp", 3758783454, "int32_t", 276, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.mp_max", 1734516443, "int32_t", 280, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.ep", 3489061622, "float", 284, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.ep_max", 523427171, "float", 288, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.stamina", 508149088, "float", 292, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.stamina_max", 136178257, "float", 296, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.level", 837178339, "uint32_t", 300, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.level_cap", 4088700196, "uint32_t", 304, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.level_max", 3370330754, "uint32_t", 308, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.strength", 3642016758, "int32_t", 312, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.vitality", 4259402609, "int32_t", 316, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.magic", 1724909574, "int32_t", 320, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.spirit", 3148987510, "int32_t", 324, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.critical", 578546626, "int32_t", 328, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.element_attack", 3496278474, "uint32_t", 332, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.element_absorption", 1335012519, "uint32_t", 336, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.element_invalidity", 2388619155, "uint32_t", 340, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.element_tolerance", 2657974705, "int16_t", 344, 34, 17, Property.PrimitiveType.Int16, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status.status_auto", 1365475185, "uint32_t", 380, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.status", 4094465893, "uint32_t", 384, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.status_attack", 3075244490, "uint8_t", 388, 8, 8, Property.PrimitiveType.Int8, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status.status_defence", 2389139818, "uint8_t", 396, 8, 8, Property.PrimitiveType.Int8, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status.status_count_auto", 2499329769, "uint64_t", 408, 8, 1, Property.PrimitiveType.Int64, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.status_count", 1213769741, "int8_t", 416, 64, 64, Property.PrimitiveType.Int8, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status.status_count_attack", 2823349186, "uint8_t", 480, 64, 64, Property.PrimitiveType.Int8, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status.status_count_attack_time", 1194757686, "int8_t", 544, 64, 64, Property.PrimitiveType.Int8, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status.status_count_defence", 353280978, "uint8_t", 608, 64, 64, Property.PrimitiveType.Int8, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status.status_count_time", 135245135, "uint16_t", 672, 128, 64, Property.PrimitiveType.Int16, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status.status_count_delta_time", 1427051996, "float", 800, 256, 64, Property.PrimitiveType.Float, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status.status_count_record", 674674643, "uint8_t", 1056, 64, 64, Property.PrimitiveType.Int8, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status.buff_registration_count", 573198818, "int32_t", 1120, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.buff", 2244341406, "Black.Save.Player.SaveBuffStruct", 1124, 24, 3, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status.buff_count", 1482222162, "int32_t", 1148, 228, 57, Property.PrimitiveType.Int32, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status.buff_time", 1261628362, "float", 1376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.start_buff_time", 2065410985, "float", 1380, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.mp_burst_time", 881592465, "float", 1384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.mp_burst_time_max", 3194240220, "float", 1388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.element_damage_time", 722984237, "float", 1392, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.weapon_use_number", 928395889, "Black.Actor.WEAPON_ATTACK", 1396, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.weapon_slot_amount", 1321936921, "int32_t", 1400, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.knights_of_eos", 363176519, "int32_t", 1404, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.age", 539876114, "bool", 1408, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.injured", 3626858160, "bool", 1409, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.child", 39543979, "bool", 1410, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.miners", 2829637791, "bool", 1411, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.first_person", 488199117, "bool", 1412, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.friend_control", 2931668717, "bool", 1413, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.jacket_off", 3340946747, "bool", 1414, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.tears", 3009334112, "bool", 1415, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.ring", 1169236389, "bool", 1416, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.ability_available", 3229126107, "bool", 1417, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.dirty", 3354626833, "float", 1420, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.ability", 1964208591, "Black.Save.Ability.SaveAbilityEquipmentStruct", 1424, 64, 8, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status.ability_menu", 794085463, "Black.Save.Ability.SaveAbilityEquipmentMenuStruct", 1488, 32, 8, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status.weapon", 2358450947, "Black.Save.Equipment.SaveWeaponEquipmentStruct", 1520, 64, 4, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status.job_command", 2682314300, "Black.Save.Ability.SaveJobCommandEquipmentStruct", 1584, 8, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.job_command.id", 2753221099, "SQEX.Ebony.Std.Fixid", 1584, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.job_command.bank_number", 1328196200, "int", 1588, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.accessory", 2136226971, "Black.Save.Equipment.SaveWeaponEquipmentStruct", 1592, 48, 3, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status.cloth", 1373269253, "Black.Save.Equipment.SaveClothEquipmentStruct", 1640, 12, 1, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status.reserve1", 3278972764, "int32_t", 1652, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.reserve2", 3329305621, "int32_t", 1656, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.reserve3", 3312528002, "int32_t", 1660, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.reserve4", 3228639907, "int32_t", 1664, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.reserve5", 3211862288, "int32_t", 1668, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.reserve6", 3262195145, "int32_t", 1672, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.reserve7", 3245417526, "int32_t", 1676, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.reserve8", 3429971335, "int32_t", 1680, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.exp", 2716233154, "uint32_t", 1688, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.exp_total", 3827271839, "uint32_t", 1692, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.ability_point", 3484213278, "int32_t", 1696, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.step_count", 4027424057, "int32_t", 1700, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.step_count_battle_result", 3919810468, "int32_t", 1704, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.step_count_camp", 3958232499, "int32_t", 1708, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.step_count_gladiolus", 4006187544, "int32_t", 1712, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.phantom_sword_amount", 168996347, "int32_t", 1716, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.kill_count", 1516719603, "int32_t", 1720, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.damage_count", 851105894, "int32_t", 1724, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.damage_ratio", 1273878458, "int32_t", 1728, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.damage_ratio_max", 868356631, "int32_t", 1732, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.reserve1", 550551332, "int32_t", 1736, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.reserve2", 600884189, "int32_t", 1740, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.reserve3", 584106570, "int32_t", 1744, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.reserve4", 500218475, "int32_t", 1748, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.reserve5", 483440856, "int32_t", 1752, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.reserve6", 533773713, "int32_t", 1756, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.reserve7", 516996094, "int32_t", 1760, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.reserve8", 433107999, "int32_t", 1764, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.invincible_suits_date", 3629542112, "SQEX.Ebony.Base.RTC.DateTime", 1768, 28, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.invincible_suits_date.year", 3781936695, "int", 1768, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.invincible_suits_date.month", 504635820, "int", 1772, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.invincible_suits_date.day", 944144376, "int", 1776, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.invincible_suits_date.weekDay", 1268400868, "int", 1780, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.invincible_suits_date.hour", 3993123768, "int", 1784, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.invincible_suits_date.minute", 2140299374, "int", 1788, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.invincible_suits_date.second", 1247475990, "int", 1792, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.invincible_suits_count", 3961573755, "int32_t", 1796, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("player_status.invincible_suits_time", 2907907685, "int32_t", 1800, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("skill.id", 336824373, "SQEX.Ebony.Std.Fixid", 55144, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("skill.exp", 185597943, "int32_t", 55148, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("skill.exp_total", 766768034, "int32_t", 55152, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("skill.level", 4100674622, "int32_t", 55156, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("position.available_", 1524928272, "bool", 55168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("position.double_vector_", 17350730, "Luminous.Math.DoubleVector4", 55176, 32, 1, Property.PrimitiveType.DoubleVector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("position.rotation_", 1696025263, "Luminous.Math.VectorA", 55216, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("object_entry_id", 868490063, "SQEX.Ebony.Std.Fixid", 4, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("character_entry_id", 216598113, "SQEX.Ebony.Std.Fixid", 8, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("default_character_entry_id", 3039116423, "SQEX.Ebony.Std.Fixid", 12, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("name", 2369371622, "char", 16, 128, 128, Property.PrimitiveType.Int8, 0, (char)8));
			fieldProperties.AddProperty(new Property("name_id", 3355607158, "SQEX.Ebony.Std.Fixid", 144, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("status", 3125508079, "Black.Save.Player.SaveStatusStruct", 152, 1536, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("player_status", 96348663, "Black.Save.Player.SavePlayerStatusStruct", 1688, 140, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("weapon_type", 1761553146, "Black.Actor.WEAPON_TYPE", 1828, 16, 4, Property.PrimitiveType.Enum, 0, (char)8));
			fieldProperties.AddProperty(new Property("ability", 3471506833, "Black.Save.Ability.SaveAbilityStruct", 1844, 32228, 1151, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("ability_count", 1904179969, "Black.Save.Ability.SaveAbilityCountStruct", 34072, 8192, 2, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("ability_effect_count", 2728588471, "Black.Save.Ability.SaveAbilityEffectCountStruct", 42264, 2048, 2, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("weapon_ability", 2604204528, "Black.Save.Ability.SaveEnchantCountStruct", 44312, 80, 2, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("job_command", 2134253846, "Black.Save.Ability.SaveJobCommandStruct", 44392, 256, 16, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("inspiration", 3359413299, "Black.Save.Ability.SaveInspirationStruct", 44648, 2048, 256, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("inspiration_check", 2044175116, "Black.Save.Ability.SaveInspirationCheckStruct", 46696, 8192, 2048, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("inspiration_element_check", 863795739, "Black.Save.Ability.SaveInspirationElementCheckStruct", 54888, 256, 64, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("skill", 3390427190, "Black.Save.Ability.SaveSkillStruct", 55144, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("position", 2471448074, "Black.Save.Player.SavePlayerPositionStruct", 55168, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}