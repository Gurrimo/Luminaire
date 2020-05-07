using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.EventScript
{
    public partial class SaveEventScriptSceneDataStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint sceneId;
		public long lastElapsedGameTime;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEventScriptSceneDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.EventScript.SaveEventScriptSceneDataStruct", 0, Black.Save.EventScript.SaveEventScriptSceneDataStruct.ObjectType, null, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("Black.Save.EventScript.SaveEventScriptSceneDataStruct", null, -1839855270, 1790015476);
            
			fieldProperties.AddProperty(new Property("sceneId", 3867899902, "SQEX.Ebony.Std.Fixid", 0, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("lastElapsedGameTime", 2241986172, "int64_t", 8, 8, 1, Property.PrimitiveType.Int64, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}