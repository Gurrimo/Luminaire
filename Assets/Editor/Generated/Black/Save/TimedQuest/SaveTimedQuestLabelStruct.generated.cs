using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.TimedQuest
{
    public partial class SaveTimedQuestLabelStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint labelId;
		public int var;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveTimedQuestLabelStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.TimedQuest.SaveTimedQuestLabelStruct", 0, Black.Save.TimedQuest.SaveTimedQuestLabelStruct.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.Save.TimedQuest.SaveTimedQuestLabelStruct", null, 1208322621, -572757269);
            
			fieldProperties.AddProperty(new Property("labelId", 3903604776, "SQEX.Luminous.Std.Fixid", 0, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("var", 2317739966, "int32_t", 4, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}