using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.CharacterEntry
{
    public partial class CharacterEntryMaterialParamArrayItem : Black.Entity.Data.CharacterEntry.CharacterEntryArrayItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int Type;
		public string MaterialName;
		public string ParamName;
		public float Value;
		public UnityEngine.Vector4 VectorValue;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CharacterEntryMaterialParamArrayItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.CharacterEntry.CharacterEntryMaterialParamArrayItem", 0, Black.Entity.Data.CharacterEntry.CharacterEntryMaterialParamArrayItem.ObjectType, null, properties, 0, 80);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.CharacterEntry.CharacterEntryMaterialParamArrayItem", base.GetFieldProperties(), -1833237775, 762505244);
            
			fieldProperties.AddProperty(new Property("Type", 3512062061, "Black.Entity.Data.CharacterEntry.CharacterEntryMaterialParamArrayItem.Type", 8, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("MaterialName", 3232801059, "Ebony.Base.String", 16, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("ParamName", 1533216953, "Ebony.Base.String", 32, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("Value", 3511155050, "float", 48, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("VectorValue", 1592999115, "Luminous.Math.VectorA", 64, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}