using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Item
{
    public partial class SaveMagicRecipeListStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int magic_recipe_amount;
		public Black.Save.Item.SaveMagicRecipeStruct magic_recipe;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMagicRecipeListStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Item.SaveMagicRecipeListStruct", 0, Black.Save.Item.SaveMagicRecipeListStruct.ObjectType, null, properties, 0, 1524);
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

            fieldProperties = new PropertyContainer("Black.Save.Item.SaveMagicRecipeListStruct", null, 944515684, 768846293);
            
			fieldProperties.AddProperty(new Property("magic_recipe_amount", 1280676424, "int32_t", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("magic_recipe", 1185871091, "Black.Save.Item.SaveMagicRecipeStruct", 4, 1520, 20, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}