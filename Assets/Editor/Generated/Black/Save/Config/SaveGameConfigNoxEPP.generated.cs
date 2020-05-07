using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveGameConfigNoxEPP
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool cleared;
		public bool played;
		public Black.Save.Config.SaveEppScoreRanking EppScoreBoard;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveGameConfigNoxEPP();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveGameConfigNoxEPP", 0, Black.Save.Config.SaveGameConfigNoxEPP.ObjectType, null, properties, 0, 1952);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveGameConfigNoxEPP", null, -1420705936, -1593875547);
            
			fieldProperties.AddProperty(new Property("cleared", 3899202675, "bool", 0, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("played", 1117382050, "bool", 1, 4, 4, Property.PrimitiveType.Bool, 0, (char)8));
			fieldProperties.AddProperty(new Property("EppScoreBoard", 1296817618, "Black.Save.Config.SaveEppScoreRanking", 8, 1944, 3, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}