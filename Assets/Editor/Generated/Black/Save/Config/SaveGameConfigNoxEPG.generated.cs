using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveGameConfigNoxEPG
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int highScore;
		public bool cleared;
		public bool played;
		public Black.Save.Config.SaveEpgFinalScore EpgScoreRanking;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveGameConfigNoxEPG();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveGameConfigNoxEPG", 0, Black.Save.Config.SaveGameConfigNoxEPG.ObjectType, null, properties, 0, 1456);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveGameConfigNoxEPG", null, -1421557904, 1611742678);
            
			fieldProperties.AddProperty(new Property("highScore", 3905136301, "int", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("cleared", 3899202675, "bool", 4, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("played", 1117382050, "bool", 5, 4, 4, Property.PrimitiveType.Bool, 0, (char)8));
			fieldProperties.AddProperty(new Property("EpgScoreRanking", 1572072081, "Black.Save.Config.SaveEpgFinalScore", 16, 1440, 10, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}