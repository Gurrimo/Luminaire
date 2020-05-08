using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Render
{
    public partial class SequenceActionSetProceduralSky : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enableWeather_;
		public bool enableEVControl_;
		public float sunBrightness_;
		public float sunBrightnessEV_;
		public float moonBrightness_;
		public float moonBrightnessEV_;
		public float airThickness_;
		public float turbidityR_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turbidityRPin_;
		public float rayleighOvercastRate_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rayleighOvercastRatePin_;
		public float turbidityM_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turbidityMPin_;
		public float sunAsymmetry_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunAsymetryPin_;
		public float mieColorR_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mieColorRPin_;
		public float mieColorG_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mieColorGPin_;
		public float mieColorB_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mieColorBPin_;
		public UnityEngine.Color sunDiskColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunDiskColorPin_;
		public float sunDiskRadiation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunDiskRadiationPin_;
		public float sunDiskRelativeSize_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunDiskRelativeSizePin_;
		public UnityEngine.Color moonDiskColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moonDiskColorPin_;
		public float moonDiskRadiation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moonDiskRadiationPin_;
		public float moonDiskRelativeSize_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moonDiskRelativeSizePin_;
		public UnityEngine.Color sunColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunColorPin_;
		public float sunBrightnessSky_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunBrightnessSkyPin_;
		public UnityEngine.Color moonColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moonColorPin_;
		public float moonBrightnessSky_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moonBrightnessSkyPin_;
		public UnityEngine.Color mainLightSunColor_;
		public float sunLightScale_;
		public UnityEngine.Color mainLightMoonColor_;
		public float moonLightScale_;
		public UnityEngine.Color envSunColor_;
		public float envSunScale_;
		public UnityEngine.Color envMoonColor_;
		public float envMoonScale_;
		public float starSize_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin starSizePin_;
		public float starExtinctionHorizon_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin starExtinctionHorizoPin_;
		public float starBrightness_;
		public float starBrightnessEV_;
		public float tilingStarBrightness_;
		public float tilingStarBrightnessEV_;
		public float milkywayBrightness_;
		public float milkywayBrightnessEV_;
		public float starTwinkleSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin starTwinkleSpeedPin_;
		public float tilingStarTwinkleSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin tilingStarTwinkleSpeedPin_;
		public UnityEngine.Color backgroundColor_;
		public float backgroundColorIntensity_;
		public float backgroundColorIntensityEV_;
		public UnityEngine.Color groundColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groundColorPin_;
		public float groundAlbedo_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groundAlbedoPin_;
		public float groundColorSpread_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groundColorSpreadPin_;
		public float groundSpreadUp_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groundSpreadUpPin_;
		public float horizonOffset_;
		public float extinctionStart_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin extinctionStartPin_;
		public float extinctionEnd_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin extinctionEndPin_;
		public float extinctionFalloff_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin extinctionFalloffPin_;
		public UnityEngine.Color midgroundColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin midgroundColorPin_;
		public float midgroundIntensity_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin midgroundIntensityPin_;
		public float viewElevationAngle_;
		public float viewElevationAttenuation_;
		public float axisTilt_;
		public float axisAzimuth_;
		public float centerOfRotationHeightOffset_;
		public float meridianTime_;
		public float moonAxisTilt_;
		public float moonAxisAzimuth_;
		public float moonCenterOfRotationHeightOffset_;
		public float moonMeridianTime_;
		public float starAxisTilt_;
		public float starAxisAzimuth_;
		public float starMeridianTime_;
		public float sunDuration_;
		public float moonDuration_;
		public float START_DAY_;
		public float END_DAY_;
		public float moonriseOffset_;
		public float ambientIntensity_;
		public float directionalIntensity_;
		public float ambientSpecUseDirLightShadow_;
		public float shadowPower_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetProceduralSky();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Render.SequenceActionSetProceduralSky", 0, Black.Sequence.Action.Render.SequenceActionSetProceduralSky.ObjectType, Construct, properties, 0, 3632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Render.SequenceActionSetProceduralSky", base.GetFieldProperties(), 374908728, 1957126268);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.pinName_", 3330161590, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.name_", 192292993, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.connections_", 490033121, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayType_", 261766523, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 248, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayTime_", 1689218608, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayMaxTime_", 1529341114, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.pinName_", 1137295951, "Base.String", 280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.name_", 2182257194, "Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.connections_", 2048532136, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 312, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayType_", 124432558, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 344, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayTime_", 3264366185, "float", 348, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayMaxTime_", 456551125, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turbidityRPin_.pinName_", 2783525376, "Base.String", 408, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turbidityRPin_.name_", 3993146859, "Base.String", 424, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turbidityRPin_.connections_", 4276997411, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 440, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turbidityRPin_.pinValueType_", 2543922910, "Base.String", 472, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rayleighOvercastRatePin_.pinName_", 2750137530, "Base.String", 504, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rayleighOvercastRatePin_.name_", 2702998213, "Base.String", 520, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rayleighOvercastRatePin_.connections_", 397745117, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 536, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rayleighOvercastRatePin_.pinValueType_", 2188133068, "Base.String", 568, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turbidityMPin_.pinName_", 1090325679, "Base.String", 600, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turbidityMPin_.name_", 2350543690, "Base.String", 616, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turbidityMPin_.connections_", 567809352, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 632, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turbidityMPin_.pinValueType_", 382227539, "Base.String", 664, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunAsymetryPin_.pinName_", 3276541422, "Base.String", 696, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunAsymetryPin_.name_", 375506537, "Base.String", 712, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunAsymetryPin_.connections_", 2229730521, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 728, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sunAsymetryPin_.pinValueType_", 1941978208, "Base.String", 760, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("mieColorRPin_.pinName_", 4189777656, "Base.String", 792, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("mieColorRPin_.name_", 1667216979, "Base.String", 808, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("mieColorRPin_.connections_", 2042612027, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 824, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("mieColorRPin_.pinValueType_", 779167622, "Base.String", 856, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("mieColorGPin_.pinName_", 2417669761, "Base.String", 888, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("mieColorGPin_.name_", 3493990396, "Base.String", 904, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("mieColorGPin_.connections_", 3476612194, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 920, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("mieColorGPin_.pinValueType_", 4164144209, "Base.String", 952, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("mieColorBPin_.pinName_", 2985104296, "Base.String", 984, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("mieColorBPin_.name_", 650683971, "Base.String", 1000, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("mieColorBPin_.connections_", 4022635851, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1016, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("mieColorBPin_.pinValueType_", 1445121526, "Base.String", 1048, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunDiskColorPin_.pinName_", 297171278, "Base.String", 1096, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunDiskColorPin_.name_", 4081160585, "Base.String", 1112, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunDiskColorPin_.connections_", 3957082361, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1128, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sunDiskColorPin_.pinValueType_", 3392884608, "Base.String", 1160, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunDiskRadiationPin_.pinName_", 3848453558, "Base.String", 1192, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunDiskRadiationPin_.name_", 2689625729, "Base.String", 1208, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunDiskRadiationPin_.connections_", 3193958881, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1224, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sunDiskRadiationPin_.pinValueType_", 3587083256, "Base.String", 1256, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunDiskRelativeSizePin_.pinName_", 3038109484, "Base.String", 1288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunDiskRelativeSizePin_.name_", 3083313047, "Base.String", 1304, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunDiskRelativeSizePin_.connections_", 399733879, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1320, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sunDiskRelativeSizePin_.pinValueType_", 414394778, "Base.String", 1352, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moonDiskColorPin_.pinName_", 1925849391, "Base.String", 1400, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moonDiskColorPin_.name_", 1243635914, "Base.String", 1416, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moonDiskColorPin_.connections_", 1854009800, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1432, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("moonDiskColorPin_.pinValueType_", 1177448915, "Base.String", 1464, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moonDiskRadiationPin_.pinName_", 169095055, "Base.String", 1496, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moonDiskRadiationPin_.name_", 2115781738, "Base.String", 1512, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moonDiskRadiationPin_.connections_", 3019228904, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1528, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("moonDiskRadiationPin_.pinValueType_", 298867827, "Base.String", 1560, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moonDiskRelativeSizePin_.pinName_", 3245260467, "Base.String", 1592, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moonDiskRelativeSizePin_.name_", 1819681758, "Base.String", 1608, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moonDiskRelativeSizePin_.connections_", 222821700, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1624, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("moonDiskRelativeSizePin_.pinValueType_", 3666035991, "Base.String", 1656, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunColorPin_.pinName_", 776273323, "Base.String", 1704, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunColorPin_.name_", 1728653350, "Base.String", 1720, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunColorPin_.connections_", 1427553244, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1736, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sunColorPin_.pinValueType_", 1085887103, "Base.String", 1768, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunBrightnessSkyPin_.pinName_", 664205726, "Base.String", 1800, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunBrightnessSkyPin_.name_", 3331439193, "Base.String", 1816, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sunBrightnessSkyPin_.connections_", 4008670889, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1832, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sunBrightnessSkyPin_.pinValueType_", 2091872016, "Base.String", 1864, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moonColorPin_.pinName_", 3423361814, "Base.String", 1912, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moonColorPin_.name_", 871075233, "Base.String", 1928, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moonColorPin_.connections_", 4041746945, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1944, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("moonColorPin_.pinValueType_", 2425489688, "Base.String", 1976, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moonBrightnessSkyPin_.pinName_", 2678956539, "Base.String", 2008, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moonBrightnessSkyPin_.name_", 1616055030, "Base.String", 2024, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moonBrightnessSkyPin_.connections_", 1966061324, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2040, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("moonBrightnessSkyPin_.pinValueType_", 3305353935, "Base.String", 2072, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("starSizePin_.pinName_", 2757018271, "Base.String", 2224, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("starSizePin_.name_", 1249275130, "Base.String", 2240, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("starSizePin_.connections_", 3845419544, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2256, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("starSizePin_.pinValueType_", 1981369283, "Base.String", 2288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("starExtinctionHorizoPin_.pinName_", 1656923864, "Base.String", 2320, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("starExtinctionHorizoPin_.name_", 2147922547, "Base.String", 2336, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("starExtinctionHorizoPin_.connections_", 9564507, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2352, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("starExtinctionHorizoPin_.pinValueType_", 2308535334, "Base.String", 2384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("starTwinkleSpeedPin_.pinName_", 109524149, "Base.String", 2440, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("starTwinkleSpeedPin_.name_", 2240837872, "Base.String", 2456, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("starTwinkleSpeedPin_.connections_", 448115518, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2472, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("starTwinkleSpeedPin_.pinValueType_", 720544245, "Base.String", 2504, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("tilingStarTwinkleSpeedPin_.pinName_", 2879448376, "Base.String", 2536, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("tilingStarTwinkleSpeedPin_.name_", 1092573587, "Base.String", 2552, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("tilingStarTwinkleSpeedPin_.connections_", 2026720635, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2568, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("tilingStarTwinkleSpeedPin_.pinValueType_", 523851206, "Base.String", 2600, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("groundColorPin_.pinName_", 3706134876, "Base.String", 2680, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("groundColorPin_.name_", 2121659847, "Base.String", 2696, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("groundColorPin_.connections_", 3319668999, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2712, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("groundColorPin_.pinValueType_", 2835550922, "Base.String", 2744, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("groundAlbedoPin_.pinName_", 3062842390, "Base.String", 2776, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("groundAlbedoPin_.name_", 1517922465, "Base.String", 2792, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("groundAlbedoPin_.connections_", 3337659137, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2808, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("groundAlbedoPin_.pinValueType_", 2145944600, "Base.String", 2840, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("groundColorSpreadPin_.pinName_", 101516141, "Base.String", 2872, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("groundColorSpreadPin_.name_", 483273784, "Base.String", 2888, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("groundColorSpreadPin_.connections_", 1927346390, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2904, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("groundColorSpreadPin_.pinValueType_", 3027723005, "Base.String", 2936, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("groundSpreadUpPin_.pinName_", 2431605855, "Base.String", 2968, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("groundSpreadUpPin_.name_", 3092880570, "Base.String", 2984, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("groundSpreadUpPin_.connections_", 2958118360, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 3000, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("groundSpreadUpPin_.pinValueType_", 2453137283, "Base.String", 3032, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("extinctionStartPin_.pinName_", 428016317, "Base.String", 3064, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("extinctionStartPin_.name_", 222965960, "Base.String", 3080, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("extinctionStartPin_.connections_", 673928454, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 3096, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("extinctionStartPin_.pinValueType_", 301510925, "Base.String", 3128, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("extinctionEndPin_.pinName_", 4017757406, "Base.String", 3160, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("extinctionEndPin_.name_", 72915353, "Base.String", 3176, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("extinctionEndPin_.connections_", 1116901097, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 3192, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("extinctionEndPin_.pinValueType_", 3477093712, "Base.String", 3224, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("extinctionFalloffPin_.pinName_", 2905867419, "Base.String", 3256, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("extinctionFalloffPin_.name_", 1667843286, "Base.String", 3272, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("extinctionFalloffPin_.connections_", 3922314476, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 3288, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("extinctionFalloffPin_.pinValueType_", 3499271471, "Base.String", 3320, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("midgroundColorPin_.pinName_", 588407868, "Base.String", 3368, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("midgroundColorPin_.name_", 2084280039, "Base.String", 3384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("midgroundColorPin_.connections_", 1308360103, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 3400, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("midgroundColorPin_.pinValueType_", 1452840682, "Base.String", 3432, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("midgroundIntensityPin_.pinName_", 464213646, "Base.String", 3464, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("midgroundIntensityPin_.name_", 3757151945, "Base.String", 3480, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("midgroundIntensityPin_.connections_", 3551363641, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 3496, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("midgroundIntensityPin_.pinValueType_", 4050764736, "Base.String", 3528, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableWeather_", 1384777099, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableEVControl_", 3055238003, "bool", 369, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunBrightness_", 3498263371, "float", 372, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunBrightnessEV_", 995550358, "float", 376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonBrightness_", 590191000, "float", 380, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonBrightnessEV_", 4215596685, "float", 384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("airThickness_", 1844004448, "float", 388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turbidityR_", 1777769222, "float", 392, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turbidityRPin_", 105322105, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 400, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rayleighOvercastRate_", 618264404, "float", 488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rayleighOvercastRatePin_", 3041011439, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 496, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turbidityM_", 704251869, "float", 584, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turbidityMPin_", 1524267616, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 592, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunAsymmetry_", 1663448127, "float", 680, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunAsymetryPin_", 3393595003, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 688, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mieColorR_", 4243518558, "float", 776, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("mieColorRPin_", 3040815777, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 784, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mieColorG_", 4240120059, "float", 872, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("mieColorGPin_", 2600297750, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 880, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mieColorB_", 3167191086, "float", 968, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("mieColorBPin_", 3915369777, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 976, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunDiskColor_", 879226896, "SQEX.Luminous.RenderInterface.Color", 1072, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunDiskColorPin_", 2262117083, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1088, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunDiskRadiation_", 2826617176, "float", 1176, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunDiskRadiationPin_", 138621907, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1184, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunDiskRelativeSize_", 3209578602, "float", 1272, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunDiskRelativeSizePin_", 2638858381, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1280, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonDiskColor_", 1392231517, "SQEX.Luminous.RenderInterface.Color", 1376, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonDiskColorPin_", 4029297632, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1392, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonDiskRadiation_", 2380953213, "float", 1480, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonDiskRadiationPin_", 689577920, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1488, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonDiskRelativeSize_", 1022252393, "float", 1576, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonDiskRelativeSizePin_", 482692284, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1584, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunColor_", 887658273, "SQEX.Luminous.RenderInterface.Color", 1680, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunColorPin_", 4188086500, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1696, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunBrightnessSky_", 3902717696, "float", 1784, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunBrightnessSkyPin_", 1256340363, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1792, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonColor_", 2068206072, "SQEX.Luminous.RenderInterface.Color", 1888, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonColorPin_", 2507867571, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1904, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonBrightnessSky_", 127127569, "float", 1992, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonBrightnessSkyPin_", 3506281748, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2000, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mainLightSunColor_", 59584030, "SQEX.Luminous.RenderInterface.Color", 2096, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunLightScale_", 851310164, "float", 2112, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("mainLightMoonColor_", 1783833389, "SQEX.Luminous.RenderInterface.Color", 2128, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonLightScale_", 3703143299, "float", 2144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("envSunColor_", 2078005942, "SQEX.Luminous.RenderInterface.Color", 2160, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("envSunScale_", 3089462429, "float", 2176, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("envMoonColor_", 926947621, "SQEX.Luminous.RenderInterface.Color", 2192, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("envMoonScale_", 1073083658, "float", 2208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("starSize_", 2367835821, "float", 2212, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("starSizePin_", 562658288, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2216, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("starExtinctionHorizon_", 3744267610, "float", 2304, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("starExtinctionHorizoPin_", 2163246849, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2312, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("starBrightness_", 436879067, "float", 2400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("starBrightnessEV_", 1368443334, "float", 2404, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tilingStarBrightness_", 3457880770, "float", 2408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tilingStarBrightnessEV_", 3024994539, "float", 2412, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("milkywayBrightness_", 1046684088, "float", 2416, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("milkywayBrightnessEV_", 4149752365, "float", 2420, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("starTwinkleSpeed_", 3264214087, "float", 2424, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("starTwinkleSpeedPin_", 1880015666, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2432, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("tilingStarTwinkleSpeed_", 1929819934, "float", 2520, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tilingStarTwinkleSpeedPin_", 1442652257, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2528, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("backgroundColor_", 3676648221, "SQEX.Luminous.RenderInterface.Color", 2624, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("backgroundColorIntensity_", 1851662122, "float", 2640, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("backgroundColorIntensityEV_", 2325900403, "float", 2644, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundColor_", 507939130, "SQEX.Luminous.RenderInterface.Color", 2656, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundColorPin_", 1002298141, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2672, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundAlbedo_", 3746466552, "float", 2760, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundAlbedoPin_", 3653154995, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2768, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundColorSpread_", 2163823711, "float", 2856, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundColorSpreadPin_", 2750049274, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2864, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundSpreadUp_", 981466349, "float", 2952, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundSpreadUpPin_", 2285178416, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2960, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("horizonOffset_", 3972531260, "float", 3048, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("extinctionStart_", 1089661071, "float", 3052, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("extinctionStartPin_", 2521273194, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3056, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("extinctionEnd_", 3145689024, "float", 3144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("extinctionEndPin_", 1352391499, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3152, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("extinctionFalloff_", 3687057521, "float", 3240, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("extinctionFalloffPin_", 1818373300, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3248, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("midgroundColor_", 1453299034, "SQEX.Luminous.RenderInterface.Color", 3344, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("midgroundColorPin_", 1807965053, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3360, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("midgroundIntensity_", 2323613136, "float", 3448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("midgroundIntensityPin_", 1398618523, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3456, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("viewElevationAngle_", 3205807067, "float", 3544, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("viewElevationAttenuation_", 3027767962, "float", 3548, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("axisTilt_", 1271777844, "float", 3552, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("axisAzimuth_", 3753876753, "float", 3556, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("centerOfRotationHeightOffset_", 924825956, "float", 3560, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("meridianTime_", 3122082956, "float", 3564, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonAxisTilt_", 79685647, "float", 3568, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonAxisAzimuth_", 3430599188, "float", 3572, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonCenterOfRotationHeightOffset_", 110503819, "float", 3576, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonMeridianTime_", 254365011, "float", 3580, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("starAxisTilt_", 1570427688, "float", 3584, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("starAxisAzimuth_", 754099421, "float", 3588, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("starMeridianTime_", 408508416, "float", 3592, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sunDuration_", 1208776138, "float", 3596, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonDuration_", 989891917, "float", 3600, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("START_DAY_", 2688911951, "float", 3604, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("END_DAY_", 3971591676, "float", 3608, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("moonriseOffset_", 4232027239, "float", 3612, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientIntensity_", 2595803605, "float", 3616, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalIntensity_", 3480104993, "float", 3620, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientSpecUseDirLightShadow_", 3869096279, "float", 3624, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowPower_", 2925680519, "float", 3628, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionSetProceduralSky();
        }
		
    }
}