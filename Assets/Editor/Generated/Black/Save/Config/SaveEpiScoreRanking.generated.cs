using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveEpiScoreRanking
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public long bestScore;
		public Black.Save.Config.SaveEpiFinalScore EpiScoreRanking;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEpiScoreRanking();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveEpiScoreRanking", 0, Black.Save.Config.SaveEpiScoreRanking.ObjectType, null, properties, 0, 328);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveEpiScoreRanking", null, -1578888346, 239009982);
            
			fieldProperties.AddProperty(new Property("bestScore", 3526121467, "int64_t", 0, 8, 1, Property.PrimitiveType.Int64, 0, (char)0));
			fieldProperties.AddProperty(new Property("EpiScoreRanking", 3079212459, "Black.Save.Config.SaveEpiFinalScore", 8, 320, 10, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}