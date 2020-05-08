using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Area
{
    public partial class AreaStartPointItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 areaStartPosition_;
		public string memo_= string.Empty;
		public string labelName_= string.Empty;
		public int valueType_;
		public int labelValue_;
		public float labelValueFloat_;
		public bool labelValueBool_;
		public string labelValueString_= string.Empty;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AreaStartPointItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Area.AreaStartPointItem", 0, Black.Entity.Data.Area.AreaStartPointItem.ObjectType, null, properties, 0, 96);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Area.AreaStartPointItem", base.GetFieldProperties(), -420074028, -164583431);
            
			
			
			fieldProperties.AddProperty(new Property("areaStartPosition_", 2565057324, "Luminous.Math.VectorA", 16, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("memo_", 3571411732, "Ebony.Base.String", 32, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("labelName_", 2707696659, "Ebony.Base.String", 48, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueType_", 1693725455, "SQEX.Ebony.Framework.Sequence.SequenceValue.ValueType", 64, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("labelValue_", 151679239, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("labelValueFloat_", 3454876269, "float", 72, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("labelValueBool_", 1719160611, "bool", 76, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("labelValueString_", 3078307052, "Ebony.Base.String", 80, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}