using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Player
{
    public partial class SaveDataStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int gameVersion;
		public SQEX.Ebony.Base.Timer.TimeStamp startTime;
		public SQEX.Ebony.Base.Timer.TimeStamp endTime;
		public Black.Save.Player.SavePlayerStruct player;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Player.SaveDataStruct", 0, Black.Save.Player.SaveDataStruct.ObjectType, null, properties, 0, 1049440);
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

            fieldProperties = new PropertyContainer("Black.Save.Player.SaveDataStruct", null, 1286902868, 1307448055);
            
			
			
			fieldProperties.AddProperty(new Property("gameVersion", 1162010473, "int32_t", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("startTime", 178154766, "SQEX.Ebony.Base.Timer.TimeStamp", 8, 8, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endTime", 3550905323, "SQEX.Ebony.Base.Timer.TimeStamp", 16, 8, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("player", 748274432, "Black.Save.Player.SavePlayerStruct", 32, 1049408, 19, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}