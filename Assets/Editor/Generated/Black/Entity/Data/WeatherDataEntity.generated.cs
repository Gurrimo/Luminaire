using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data
{
    public partial class WeatherDataEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float weatherTransitionTime_;
		public string skyFilePath_= string.Empty;
		public bool reloadSky_;
		public uint defaultClimateId_;
		public string exposureFilePath_= string.Empty;
		public bool reloadExposure_;
		public short defaultExposureId_;
		public string postEffectFilePath_= string.Empty;
		public bool reloadPostEffect_;
		public short defaultPostEffectId_;
		public string cameraLightFilePath_= string.Empty;
		public bool reloadCameraLight_;
		public short defaultCameraLightId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new WeatherDataEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.WeatherDataEntity", 0, Black.Entity.Data.WeatherDataEntity.ObjectType, Construct, properties, 0, 176);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.WeatherDataEntity", base.GetFieldProperties(), -1036387836, -442917900);
            
			
			
			fieldProperties.AddProperty(new Property("weatherTransitionTime_", 4249573478, "float", 64, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("skyFilePath_", 1621698040, "Ebony.Base.String", 72, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("reloadSky_", 608769770, "bool", 88, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("defaultClimateId_", 1751479349, "SQEX.Ebony.Std.Fixid", 92, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("exposureFilePath_", 3444061062, "Ebony.Base.String", 96, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("reloadExposure_", 957663130, "bool", 112, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("defaultExposureId_", 2350617423, "int16_t", 114, 2, 1, Property.PrimitiveType.Int16, 0, (char)0));
			fieldProperties.AddProperty(new Property("postEffectFilePath_", 1832584068, "Ebony.Base.String", 120, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("reloadPostEffect_", 496010540, "bool", 136, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("defaultPostEffectId_", 4229827121, "int16_t", 138, 2, 1, Property.PrimitiveType.Int16, 0, (char)0));
			fieldProperties.AddProperty(new Property("cameraLightFilePath_", 2838000532, "Ebony.Base.String", 144, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("reloadCameraLight_", 4184588526, "bool", 160, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("defaultCameraLightId_", 3356481279, "int16_t", 162, 2, 1, Property.PrimitiveType.Int16, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new WeatherDataEntity();
        }
		
    }
}