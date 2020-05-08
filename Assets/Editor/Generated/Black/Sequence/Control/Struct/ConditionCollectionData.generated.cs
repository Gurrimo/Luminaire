using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Control.Struct
{
    public partial class ConditionCollectionData : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Sequence.Control.Struct.ConditionData> data_= new List<Black.Sequence.Control.Struct.ConditionData>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ConditionCollectionData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Control.Struct.ConditionCollectionData", 0, Black.Sequence.Control.Struct.ConditionCollectionData.ObjectType, Construct, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Control.Struct.ConditionCollectionData", base.GetFieldProperties(), -1792705838, -1012876471);
            
			
			
			fieldProperties.AddProperty(new Property("data_", 3067826062, "SQEX.Ebony.Std.DynamicArray< Black.Sequence.Control.Struct.ConditionData* >", 8, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new ConditionCollectionData();
        }
		
    }
}