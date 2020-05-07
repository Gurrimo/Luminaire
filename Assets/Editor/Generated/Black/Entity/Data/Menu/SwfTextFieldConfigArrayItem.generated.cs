using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Menu
{
    public partial class SwfTextFieldConfigArrayItem : Black.Entity.Data.Menu.SwfArrayItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint TextField;
		public int FontType;
		public int VerticalAlignType;
		public uint MovieClip;
		public bool IsEnableSoftWrap;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SwfTextFieldConfigArrayItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Menu.SwfTextFieldConfigArrayItem", 0, Black.Entity.Data.Menu.SwfTextFieldConfigArrayItem.ObjectType, null, properties, 0, 32);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Entity.Data.Menu.SwfTextFieldConfigArrayItem", base.GetFieldProperties(), -1403186291, -94117148);
            
			fieldProperties.AddProperty(new Property("TextField", 946348394, "SQEX.Ebony.Std.Fixid", 8, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("FontType", 2807589272, "Black.Entity.Data.Menu.SwfTextFieldConfigArrayItem.FONT_TYPE", 12, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("VerticalAlignType", 2488489512, "Black.Entity.Data.Menu.SwfTextFieldConfigArrayItem.VERTICAL_ALIGN_TYPE", 16, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("MovieClip", 1590225225, "SQEX.Ebony.Std.Fixid", 20, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsEnableSoftWrap", 2092976254, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}