using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.AbilityTree
{
    public partial class SaveAbilityTreeEntityStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint enableAbilityTreeEntityId;
		public int abilityBankNumber;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveAbilityTreeEntityStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.AbilityTree.SaveAbilityTreeEntityStruct", 0, Black.Save.AbilityTree.SaveAbilityTreeEntityStruct.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.Save.AbilityTree.SaveAbilityTreeEntityStruct", null, -396705802, -2091508941);
            
			fieldProperties.AddProperty(new Property("enableAbilityTreeEntityId", 2698800794, "SQEX.Ebony.Std.Fixid", 0, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("abilityBankNumber", 194599050, "int", 4, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}