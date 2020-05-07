using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Ability
{
    public partial class SaveJobCommandEquipmentStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id;
		public int bank_number;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveJobCommandEquipmentStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Ability.SaveJobCommandEquipmentStruct", 0, Black.Save.Ability.SaveJobCommandEquipmentStruct.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.Save.Ability.SaveJobCommandEquipmentStruct", null, 989104410, 808046986);
            
			
			
			fieldProperties.AddProperty(new Property("id", 926444256, "SQEX.Ebony.Std.Fixid", 0, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("bank_number", 4231111433, "int", 4, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}