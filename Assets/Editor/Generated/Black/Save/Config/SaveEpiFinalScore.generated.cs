using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveEpiFinalScore
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public sbyte ClearedMDay;
		public sbyte ClearedMonth;
		public short ClearedYear;
		public long PlayTime;
		public int Rank;
		public bool IsCleared;
		public int Score;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEpiFinalScore();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveEpiFinalScore", 0, Black.Save.Config.SaveEpiFinalScore.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveEpiFinalScore", null, 1697671251, 266482192);
            
			fieldProperties.AddProperty(new Property("ClearedMDay", 3172167432, "char", 0, 1, 1, Property.PrimitiveType.Int8, 0, (char)0));
			fieldProperties.AddProperty(new Property("ClearedMonth", 3701886039, "char", 1, 1, 1, Property.PrimitiveType.Int8, 0, (char)0));
			fieldProperties.AddProperty(new Property("ClearedYear", 2473866390, "short", 2, 2, 1, Property.PrimitiveType.Int16, 0, (char)0));
			fieldProperties.AddProperty(new Property("PlayTime", 564247098, "int64_t", 8, 8, 1, Property.PrimitiveType.Int64, 0, (char)0));
			fieldProperties.AddProperty(new Property("Rank", 751402311, "Black.Battle.BattleModeManager.RESULT_RANK", 16, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsCleared", 99008323, "bool", 20, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("Score", 2011890229, "int32_t", 24, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}