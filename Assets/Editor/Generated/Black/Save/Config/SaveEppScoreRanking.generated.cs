using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveEppScoreRanking
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public long bestTime;
		public Black.Save.Config.SaveEppFinalScore EppScoreRanking;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEppScoreRanking();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveEppScoreRanking", 0, Black.Save.Config.SaveEppScoreRanking.ObjectType, null, properties, 0, 648);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveEppScoreRanking", null, -1583175797, -788938829);
            
			fieldProperties.AddProperty(new Property("bestTime", 3618101878, "int64_t", 0, 8, 1, Property.PrimitiveType.Int64, 0, (char)0));
			fieldProperties.AddProperty(new Property("EppScoreRanking", 1606933620, "Black.Save.Config.SaveEppFinalScore", 8, 640, 10, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}