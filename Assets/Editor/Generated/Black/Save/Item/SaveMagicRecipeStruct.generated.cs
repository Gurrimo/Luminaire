using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Item
{
    public partial class SaveMagicRecipeStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool favorite;
		public bool disable;
		public sbyte disable_level;
		public bool disable_delete;
		public uint magic_bottle_id;
		public int magic_bottle_amount;
		public int element;
		public int power;
		public uint effect;
		public int effect_level;
		public Black.Save.Item.SaveMagicRecipeItemStruct item;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMagicRecipeStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Item.SaveMagicRecipeStruct", 0, Black.Save.Item.SaveMagicRecipeStruct.ObjectType, null, properties, 0, 76);
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

            fieldProperties = new PropertyContainer("Black.Save.Item.SaveMagicRecipeStruct", null, 1819852741, -155607518);
            
			fieldProperties.AddProperty(new Property("favorite", 748762573, "bool", 0, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("disable", 3454897251, "bool", 1, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("disable_level", 1575933130, "int8_t", 2, 1, 1, Property.PrimitiveType.Int8, 0, (char)0));
			fieldProperties.AddProperty(new Property("disable_delete", 3817644607, "bool", 3, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("magic_bottle_id", 2005209587, "SQEX.Ebony.Std.Fixid", 4, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("magic_bottle_amount", 3289678162, "int32_t", 8, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("element", 1330461687, "Black.Actor.STATUS_ELEMENT", 12, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("power", 4115604294, "int32_t", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("effect", 1852738900, "SQEX.Ebony.Std.Fixid", 20, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("effect_level", 1645453049, "int32_t", 24, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("item", 2671260646, "Black.Save.Item.SaveMagicRecipeItemStruct", 28, 48, 4, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}