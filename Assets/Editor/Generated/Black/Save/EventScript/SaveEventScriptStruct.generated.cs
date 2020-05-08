using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.EventScript
{
    public partial class SaveEventScriptStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Save.EventScript.SaveEventScriptGroupDataStruct> saveEventScriptGroupDataStructList= new List<Black.Save.EventScript.SaveEventScriptGroupDataStruct>();
		public IList<Black.Save.EventScript.SaveEventScriptSceneDataStruct> saveEventScriptSceneDataStructList= new List<Black.Save.EventScript.SaveEventScriptSceneDataStruct>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEventScriptStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.EventScript.SaveEventScriptStruct", 0, Black.Save.EventScript.SaveEventScriptStruct.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.Save.EventScript.SaveEventScriptStruct", null, -2046051713, -1133893771);
            
			
			
			fieldProperties.AddProperty(new Property("saveEventScriptGroupDataStructList", 161907367, "SQEX.Ebony.Std.DynamicArray< Black.Save.EventScript.SaveEventScriptGroupDataStruct >", 0, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("saveEventScriptSceneDataStructList", 985889292, "SQEX.Ebony.Std.DynamicArray< Black.Save.EventScript.SaveEventScriptSceneDataStruct >", 16, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}