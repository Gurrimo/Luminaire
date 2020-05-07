using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Player
{
    public partial class SavePlayerStatusStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int exp;
		public int exp_total;
		public int ability_point;
		public int step_count;
		public int step_count_battle_result;
		public int step_count_camp;
		public int step_count_gladiolus;
		public int phantom_sword_amount;
		public int kill_count;
		public int damage_count;
		public int damage_ratio;
		public int damage_ratio_max;
		public int reserve1;
		public int reserve2;
		public int reserve3;
		public int reserve4;
		public int reserve5;
		public int reserve6;
		public int reserve7;
		public int reserve8;
		public SQEX.Ebony.Base.RTC.DateTime invincible_suits_date;
		public int invincible_suits_count;
		public int invincible_suits_time;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SavePlayerStatusStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Player.SavePlayerStatusStruct", 0, Black.Save.Player.SavePlayerStatusStruct.ObjectType, null, properties, 0, 140);
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

            fieldProperties = new PropertyContainer("Black.Save.Player.SavePlayerStatusStruct", null, -748940090, 114902487);
            
			fieldProperties.AddProperty(new Property("exp", 1923516200, "uint32_t", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("exp_total", 888894381, "uint32_t", 4, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ability_point", 3378042268, "int32_t", 8, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("step_count", 3319692767, "int32_t", 12, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("step_count_battle_result", 3276141958, "int32_t", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("step_count_camp", 3480206141, "int32_t", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("step_count_gladiolus", 2449300862, "int32_t", 24, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("phantom_sword_amount", 2626439197, "int32_t", 28, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("kill_count", 2058811193, "int32_t", 32, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("damage_count", 569979564, "int32_t", 36, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("damage_ratio", 3970736988, "int32_t", 40, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("damage_ratio_max", 1757335373, "int32_t", 44, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve1", 532037902, "int32_t", 48, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve2", 515260283, "int32_t", 52, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve3", 498482664, "int32_t", 56, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve4", 615925997, "int32_t", 60, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve5", 599148378, "int32_t", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve6", 582370759, "int32_t", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve7", 565593140, "int32_t", 72, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve8", 414594569, "int32_t", 76, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("invincible_suits_date", 2632002154, "SQEX.Ebony.Base.RTC.DateTime", 80, 28, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("invincible_suits_count", 4216025565, "int32_t", 108, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("invincible_suits_time", 10385495, "int32_t", 112, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}