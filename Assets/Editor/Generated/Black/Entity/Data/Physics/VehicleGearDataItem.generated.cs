using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Physics
{
    public partial class VehicleGearDataItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float gearRatio_;
		public float autoGearUpRotateRatio_;
		public float autoGearDownRotateRatio_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VehicleGearDataItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Physics.VehicleGearDataItem", 0, Black.Entity.Data.Physics.VehicleGearDataItem.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Physics.VehicleGearDataItem", base.GetFieldProperties(), 1369837609, -1973854972);
            
			fieldProperties.AddProperty(new Property("gearRatio_", 407705662, "float", 8, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoGearUpRotateRatio_", 2630530267, "float", 12, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoGearDownRotateRatio_", 195831318, "float", 16, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}