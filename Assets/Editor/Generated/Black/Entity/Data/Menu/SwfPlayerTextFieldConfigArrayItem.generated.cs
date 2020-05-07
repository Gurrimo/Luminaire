using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Menu
{
    public partial class SwfPlayerTextFieldConfigArrayItem : Black.Entity.Data.Menu.SwfArrayItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint TextField;
		public int FontType;
		public int VerticalAlignType;
		public uint MovieClip;
		public bool IsEnableSoftWrap;
		public bool IsEnableTruncate;
		public uint MessageFixId_;
		public bool IsSetString_;
		public string MessageString_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SwfPlayerTextFieldConfigArrayItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Menu.SwfPlayerTextFieldConfigArrayItem", 0, Black.Entity.Data.Menu.SwfPlayerTextFieldConfigArrayItem.ObjectType, null, properties, 0, 56);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Menu.SwfPlayerTextFieldConfigArrayItem", base.GetFieldProperties(), -588298855, -2120345529);
            
			fieldProperties.AddProperty(new Property("TextField", 946348394, "SQEX.Ebony.Std.Fixid", 8, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("FontType", 2807589272, "Black.Entity.Data.Menu.SwfPlayerTextFieldConfigArrayItem.FONT_TYPE", 12, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("VerticalAlignType", 2488489512, "Black.Entity.Data.Menu.SwfPlayerTextFieldConfigArrayItem.VERTICAL_ALIGN_TYPE", 16, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("MovieClip", 1590225225, "SQEX.Ebony.Std.Fixid", 20, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsEnableSoftWrap", 2092976254, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsEnableTruncate", 4158242500, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("MessageFixId_", 2478662327, "SQEX.Ebony.Std.Fixid", 28, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsSetString_", 1245151115, "bool", 32, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("MessageString_", 4042742094, "Ebony.Base.String", 40, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}