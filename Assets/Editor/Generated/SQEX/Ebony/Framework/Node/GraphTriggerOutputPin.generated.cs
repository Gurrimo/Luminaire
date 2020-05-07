using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Node
{
    public partial class GraphTriggerOutputPin : SQEX.Ebony.Framework.Node.GraphOutputPin
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int delayType_;
		public float delayTime_;
		public float delayMaxTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new GraphTriggerOutputPin();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 0, SQEX.Ebony.Framework.Node.GraphTriggerOutputPin.ObjectType, null, properties, 0, 96);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", base.GetFieldProperties(), 1768626225, 1481760188);
            
			fieldProperties.AddProperty(new Property("delayType_", 3980331453, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 72, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("delayTime_", 258900106, "float", 76, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("delayMaxTime_", 2659674896, "float", 80, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}