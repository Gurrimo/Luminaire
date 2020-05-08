using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Render
{
    public partial class LightEntityBase : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		public bool mayaLightDirection_;
		public bool diffuseOnly_;
		public bool smoothFalloff_;
		public int weatherType_;
		public UnityEngine.Color color_;
		public float intensity_;
		public float intensityEV_;
		public float radius_;
		public float specRadius_;
		public float range_;
		public float roughnessModifier_;
		public bool counterExposure_;
		public bool shadowEnabled_;
		public int shadowResolution_;
		public float shadowZNear_;
		public float shadowZBias_;
		public float shadowSlopeBias_;
		public float shadowPower_;
		public float shadowPowerHair_;
		public float saoTerm_;
		public bool chrOnlyShadow_;
		public bool chrAndDBGShadow_;
		public int shadowMode_;
		public bool shadowWarpEnabled_;
		public bool shadowAutoResize_;
		public bool shadowEnableMaxAngle_;
		public float shadowMaxAngle_;
		public int shadowLODOffset_;
		public float shadowCullingMaxObjectSize_;
		public bool useCharacterExclusionMask_;
		public bool excludeNoctis_;
		public bool excludeGladiolus_;
		public bool excludeIgnis_;
		public bool excludePrompto_;
		public bool excludeNoctisChildhood_;
		public bool bakeStaticShadowMap_;
		public string sourceDirectory_= string.Empty;
		public string sourceFileName_= string.Empty;
		public string projectionSourcePath_= string.Empty;
		public float projectionTextureScale_;
		public UnityEngine.Vector4 projectionTextureScroll_;
		public bool caustics_;
		public string iesSourcePath_= string.Empty;
		public string iesData_= string.Empty;
		public bool volLightEnabled_;
		public float volLightIntensity_;
		public float volLightDistantIntensity_;
		public float volLightZOffset_;
		public bool lpvEnabled_;
		public bool vsglEnabled_;
		public bool isEnabledOnOffByTime_;
		public float timeOfDayLightStart_;
		public float timeOfDayLightEnd_;
		public float transitionWorldSecLight_;
		public bool isEnabledLOD_;
		public float onOffDistance_;
		public float transitionDistanceLight_;
		public float transitionLightEV_;
		public bool isShadowEnabledOnOffByDistance_;
		public float shadowOnOffDistance_;
		public float transitionRadiusShadow_;
		public bool renderDebug_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LightEntityBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Render.LightEntityBase", 0, Black.Entity.Render.LightEntityBase.ObjectType, Construct, properties, 0, 832);
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

            fieldProperties = new PropertyContainer("Black.Entity.Render.LightEntityBase", base.GetFieldProperties(), -1006256753, -1036138698);
            
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entitySearchLabelId_", 3840219358, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 256, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("mayaLightDirection_", 670431381, "bool", 257, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("diffuseOnly_", 1220725680, "bool", 258, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("smoothFalloff_", 181256924, "bool", 259, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("weatherType_", 601680828, "Black.Entity.Render.LightEntityBase.LIGHT_WEATHER_TYPE", 260, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("color_", 3572781317, "Luminous.RenderInterface.Color", 272, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("intensity_", 1363281103, "float", 288, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("intensityEV_", 2764622858, "float", 292, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("radius_", 2286360452, "float", 296, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("specRadius_", 1598061993, "float", 300, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("range_", 1969734135, "float", 304, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("roughnessModifier_", 2915097229, "float", 308, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("counterExposure_", 32373431, "bool", 312, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowEnabled_", 3882039727, "bool", 313, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowResolution_", 1208541428, "int", 316, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowZNear_", 2446145452, "float", 320, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowZBias_", 2446539005, "float", 324, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowSlopeBias_", 2830696338, "float", 328, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowPower_", 2925680519, "float", 332, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowPowerHair_", 1876796191, "float", 336, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("saoTerm_", 711051605, "float", 340, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("chrOnlyShadow_", 75793315, "bool", 344, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("chrAndDBGShadow_", 177070405, "bool", 345, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowMode_", 2110126163, "Black.Entity.Render.LightEntityBase.SHADOW_MODE", 348, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowWarpEnabled_", 3628345333, "bool", 352, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowAutoResize_", 1698562339, "bool", 353, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowEnableMaxAngle_", 4240660008, "bool", 354, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowMaxAngle_", 4000503973, "float", 356, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowLODOffset_", 587801504, "int", 360, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowCullingMaxObjectSize_", 2911680222, "float", 364, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("useCharacterExclusionMask_", 1003605162, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("excludeNoctis_", 1273413026, "bool", 369, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("excludeGladiolus_", 859002622, "bool", 370, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("excludeIgnis_", 325665498, "bool", 371, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("excludePrompto_", 540962741, "bool", 372, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("excludeNoctisChildhood_", 2725747152, "bool", 373, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bakeStaticShadowMap_", 1082345933, "bool", 374, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourceDirectory_", 2687263660, "Ebony.Base.String", 376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourceFileName_", 1506120470, "Ebony.Base.String", 392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("projectionSourcePath_", 4247085131, "Ebony.Base.String", 408, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("projectionTextureScale_", 1395228132, "float", 424, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("projectionTextureScroll_", 1539060583, "Luminous.Math.VectorA", 432, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("caustics_", 984425753, "bool", 448, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("iesSourcePath_", 1320969163, "Ebony.Base.String", 456, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("iesData_", 896790613, "Ebony.Base.String", 472, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("volLightEnabled_", 308339756, "bool", 488, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("volLightIntensity_", 2359384144, "float", 492, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("volLightDistantIntensity_", 1545324381, "float", 496, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("volLightZOffset_", 2307886776, "float", 500, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lpvEnabled_", 2490550915, "bool", 504, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("vsglEnabled_", 3587658515, "bool", 505, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnabledOnOffByTime_", 1181927813, "bool", 506, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeOfDayLightStart_", 3250156230, "float", 508, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeOfDayLightEnd_", 3094197601, "float", 512, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("transitionWorldSecLight_", 779957570, "float", 516, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnabledLOD_", 457062662, "bool", 520, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("onOffDistance_", 1015230423, "float", 524, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("transitionDistanceLight_", 3862046468, "float", 528, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("transitionLightEV_", 3773278470, "float", 532, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isShadowEnabledOnOffByDistance_", 2257243679, "bool", 536, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowOnOffDistance_", 2964819171, "float", 540, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("transitionRadiusShadow_", 256202897, "float", 544, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("renderDebug_", 4286953853, "bool", 548, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new LightEntityBase();
        }
		
    }
}