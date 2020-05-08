using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Luminous.InputDevice
{
    public partial class PadRecordItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int delta_;
		public SQEX.Luminous.InputDevice.PadDataSet dataSet_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PadRecordItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Luminous.InputDevice.PadRecordItem", 0, SQEX.Luminous.InputDevice.PadRecordItem.ObjectType, Construct, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("SQEX.Luminous.InputDevice.PadRecordItem", base.GetFieldProperties(), -1870458987, 459145793);
            
			fieldProperties.AddIndirectlyProperty(new Property("dataSet_.Datas", 292680103, "SQEX.Luminous.InputDevice.PadData", 12, 464, 4, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			fieldProperties.AddProperty(new Property("delta_", 4049009242, "int32_t", 8, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("dataSet_", 1168001940, "SQEX.Luminous.InputDevice.PadDataSet", 12, 464, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new PadRecordItem();
        }
		
    }
}