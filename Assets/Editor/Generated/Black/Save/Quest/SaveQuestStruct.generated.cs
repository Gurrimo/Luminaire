using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Quest
{
    public partial class SaveQuestStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.Save.Quest.SaveQuestDataStruct quest_data;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveQuestStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Quest.SaveQuestStruct", 0, Black.Save.Quest.SaveQuestStruct.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.Save.Quest.SaveQuestStruct", null, 418251789, -1400173965);
            
			fieldProperties.AddIndirectlyProperty(new Property("quest_data.saveVersion", 1385026567, "uint32_t", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("quest_data.gameInformationCount", 3925774403, "uint32_t", 4, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("quest_data.gameInformationList", 325008100, "SQEX.Ebony.Std.DynamicArray< Black.Save.Quest.SaveQuestGameInformationStruct >", 8, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("quest_data.acceptQuestIdList_", 3819905960, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Std.Fixid >", 24, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("quest_data", 4011775558, "Black.Save.Quest.SaveQuestDataStruct", 0, 40, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}