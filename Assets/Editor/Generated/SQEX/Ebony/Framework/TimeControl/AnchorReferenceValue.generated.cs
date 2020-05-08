using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.TimeControl
{
    public partial class AnchorReferenceValue : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int valueType_;
		public object dependencyProperty_;
		public bool dependencyPropertyEnable_;
		public int elementIndex_;
		public bool curveEnable_;
		public float maxValue_;
		public float minValue_;
		public IList<SQEX.Ebony.Framework.TimeControl.AnchorPoint> anchorPoints_= new List<SQEX.Ebony.Framework.TimeControl.AnchorPoint>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AnchorReferenceValue();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.TimeControl.AnchorReferenceValue", 0, SQEX.Ebony.Framework.TimeControl.AnchorReferenceValue.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.TimeControl.AnchorReferenceValue", base.GetFieldProperties(), 1694444979, 411824244);
            
			
			
			fieldProperties.AddProperty(new Property("valueType_", 1693725455, "SQEX.Ebony.Framework.Sequence.SequenceValue.ValueType", 8, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("dependencyProperty_", 1510119278, "void", 16, 8, 1, Property.PrimitiveType.Pointer, 0, (char)0));
			fieldProperties.AddProperty(new Property("dependencyPropertyEnable_", 3822694307, "bool", 24, 8, 1, Property.PrimitiveType.Pointer, 0, (char)0));
			fieldProperties.AddProperty(new Property("elementIndex_", 2206996070, "int", 32, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("curveEnable_", 3644615204, "bool", 36, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxValue_", 3665555163, "float", 40, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("minValue_", 2862147529, "float", 44, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("anchorPoints_", 2050525420, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.TimeControl.AnchorPoint* >", 48, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			
			
			return fieldProperties;
        }

		
    }
}