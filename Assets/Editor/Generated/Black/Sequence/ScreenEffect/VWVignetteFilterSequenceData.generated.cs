using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.ScreenEffect
{
    public partial class VWVignetteFilterSequenceData : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		public bool enableWeather_;
		public float amount_;
		public float yScale_;
		public float cornerAttenuation_;
		public float corner_r_;
		public float corner_g_;
		public float corner_b_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VWVignetteFilterSequenceData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.ScreenEffect.VWVignetteFilterSequenceData", 0, Black.Sequence.ScreenEffect.VWVignetteFilterSequenceData.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.Sequence.ScreenEffect.VWVignetteFilterSequenceData", base.GetFieldProperties(), 1418410879, 587992316);
            
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 8, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("enableWeather_", 1384777099, "bool", 9, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("amount_", 3181604002, "float", 12, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("yScale_", 1129676355, "float", 16, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("cornerAttenuation_", 1529557157, "float", 20, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("corner_r_", 505060422, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("corner_g_", 3728084483, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("corner_b_", 507620278, "float", 32, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			
			
			return fieldProperties;
        }

		
    }
}