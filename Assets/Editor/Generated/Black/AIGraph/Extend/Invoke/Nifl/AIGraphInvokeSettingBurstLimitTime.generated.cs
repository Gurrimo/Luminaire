using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Nifl
{
    public partial class AIGraphInvokeSettingBurstLimitTime : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int limitTimeSetteingOption;
		public float remainingTime;
		public float attenuationInteropSpeed;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSettingBurstLimitTime();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Nifl.AIGraphInvokeSettingBurstLimitTime", 0, Black.AIGraph.Extend.Invoke.Nifl.AIGraphInvokeSettingBurstLimitTime.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Nifl.AIGraphInvokeSettingBurstLimitTime", base.GetFieldProperties(), -1275145301, 1786139246);
            
			fieldProperties.AddProperty(new Property("limitTimeSetteingOption", 3744254689, "Black.AIGraph.Extend.Invoke.Nifl.AIGraphInvokeSettingBurstLimitTime.LIMIT_TIME_SETTING_MODE", 24, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("remainingTime", 4053188922, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("attenuationInteropSpeed", 3899894651, "float", 32, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}