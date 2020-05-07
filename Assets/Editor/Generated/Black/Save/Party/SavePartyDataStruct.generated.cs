using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Party
{
    public partial class SavePartyDataStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int usercontrol_player_save_number;
		public int chapter;
		public int gil;
		public int medal;
		public int coin;
		public int ability_point;
		public int reward_count;
		public int clear_count;
		public bool newgame_plus;
		public bool premium_camera_status;
		public bool premium_camera_equipment;
		public float element_power;
		public float phantom_gauge;
		public float phantom_gauge_max;
		public bool job_command_available;
		public float job_command_gauge;
		public float job_command_gauge_max;
		public int strategy_probability;
		public uint camp_point_fixid;
		public string camp_point_area_file_path;
		public bool isLoopDungeon;
		public int loopDungeonLevel;
		public uint before_camp_point_fixid;
		public int link_count;
		public int death_count;
		public int kill_count;
		public int picture_count;
		public long world_time;
		public long total_seconds;
		public string weather_key;
		public int weather_type;
		public int weather_index_command;
		public int move_distance_type;
		public Black.Save.Party.SaveMoveDistanceStruct move;
		public int battle_result_rank;
		public int battle_result_count;
		public SQEX.Luminous.Math.DoubleVector4 camp_point_;
		public SQEX.Luminous.Math.DoubleVector4 before_camp_point_;
		public SQEX.Luminous.Math.DoubleVector4 loopDungeonBasePoint_;
		public SQEX.Luminous.Math.DoubleVector4 loopDungeonCampPoint_;
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

            var dummy = new SavePartyDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Party.SavePartyDataStruct", 0, Black.Save.Party.SavePartyDataStruct.ObjectType, null, properties, 0, 880);
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

            fieldProperties = new PropertyContainer("Black.Save.Party.SavePartyDataStruct", null, 1403872290, 2094854431);
            
			fieldProperties.AddProperty(new Property("usercontrol_player_save_number", 24324069, "Black.Save.SAVE_PLAYER", 0, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("chapter", 703916114, "int32_t", 4, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("gil", 1546307843, "int32_t", 8, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("medal", 3886957996, "int32_t", 12, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("coin", 3528263180, "int32_t", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ability_point", 3378042268, "int32_t", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reward_count", 517310246, "int32_t", 24, 256, 64, Property.PrimitiveType.Int32, 0, (char)8));
			fieldProperties.AddProperty(new Property("clear_count", 3161007230, "int32_t", 280, 12, 3, Property.PrimitiveType.Int32, 0, (char)8));
			fieldProperties.AddProperty(new Property("newgame_plus", 3897858172, "bool", 292, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("premium_camera_status", 3709495795, "bool", 293, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("premium_camera_equipment", 2635886939, "bool", 294, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("element_power", 3315767345, "float", 296, 68, 17, Property.PrimitiveType.Float, 0, (char)8));
			fieldProperties.AddProperty(new Property("phantom_gauge", 4229004542, "float", 364, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("phantom_gauge_max", 3258521787, "float", 368, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("job_command_available", 895139170, "bool", 372, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("job_command_gauge", 111122618, "float", 376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("job_command_gauge_max", 2215568151, "float", 380, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("strategy_probability", 2362990328, "int32_t", 384, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("camp_point_fixid", 3032686812, "SQEX.Ebony.Std.Fixid", 388, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("camp_point_area_file_path", 3200145280, "Ebony.Base.String", 392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("isLoopDungeon", 1638742231, "bool", 408, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("loopDungeonLevel", 612858871, "int", 412, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("before_camp_point_fixid", 4282607786, "SQEX.Ebony.Std.Fixid", 416, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("link_count", 4082388393, "int32_t", 420, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("death_count", 719516517, "int32_t", 424, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("kill_count", 2058811193, "int32_t", 428, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("picture_count", 1899721225, "int32_t", 432, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("world_time", 3394747813, "int64_t", 440, 8, 1, Property.PrimitiveType.Int64, 0, (char)0));
			fieldProperties.AddProperty(new Property("total_seconds", 443148979, "int64_t", 448, 8, 1, Property.PrimitiveType.Int64, 0, (char)0));
			fieldProperties.AddProperty(new Property("weather_key", 3194267011, "Ebony.Base.String", 456, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("weather_type", 1093910060, "Black.Weather.WeatherType", 472, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("weather_index_command", 3322485322, "uint32_t", 476, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("move_distance_type", 2009511131, "Black.Save.MOVE_DISTANCE_TYPE", 480, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("move", 407568404, "Black.Save.Party.SaveMoveDistanceStruct", 488, 192, 3, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("battle_result_rank", 2205722764, "int", 680, 32, 8, Property.PrimitiveType.Int32, 0, (char)8));
			fieldProperties.AddProperty(new Property("battle_result_count", 1205526513, "int", 712, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("camp_point_", 4041278646, "Luminous.Math.DoubleVector4", 720, 32, 1, Property.PrimitiveType.DoubleVector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("before_camp_point_", 3001770140, "Luminous.Math.DoubleVector4", 752, 32, 1, Property.PrimitiveType.DoubleVector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("loopDungeonBasePoint_", 1491860153, "Luminous.Math.DoubleVector4", 784, 32, 1, Property.PrimitiveType.DoubleVector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("loopDungeonCampPoint_", 979014857, "Luminous.Math.DoubleVector4", 816, 32, 1, Property.PrimitiveType.DoubleVector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve1", 532037902, "int32_t", 848, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve2", 515260283, "int32_t", 852, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve3", 498482664, "int32_t", 856, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve4", 615925997, "int32_t", 860, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve5", 599148378, "int32_t", 864, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve6", 582370759, "int32_t", 868, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve7", 565593140, "int32_t", 872, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve8", 414594569, "int32_t", 876, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}