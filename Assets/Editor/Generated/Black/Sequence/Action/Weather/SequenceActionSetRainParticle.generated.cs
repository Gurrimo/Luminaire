using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Weather
{
    public partial class SequenceActionSetRainParticle : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enabled_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enabled_pin_;
		public bool enableWeather_;
		public bool dofEnabled_;
		public UnityEngine.Vector4 ambientColor_;
		public float depthMapRadius_;
		public bool rainEnabled_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainEnabled_pin_;
		public bool splashEnabled_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin splashEnabled_pin_;
		public float rainEmitRate_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainEmitRate_pin_;
		public float rainEmitRadius_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainEmitRadius_pin_;
		public float rainEmitHeight_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainEmitHeight_pin_;
		public float rainEmitSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainEmitSpeed_pin_;
		public float rainEmitSpeedRandom_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainEmitSpeedRandom_pin_;
		public float rainEmitSpread_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainEmitSpread_pin_;
		public float rainLifespan_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainLifespan_pin_;
		public float rainGravity_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainGravity_pin_;
		public UnityEngine.Vector4 rainWindDirection_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainWindDirection_pin_;
		public float rainWindSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainWindSpeed_pin_;
		public float globalWindScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin globalWindScale_pin_;
		public float rainSizeNear_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainSizeNear_pin_;
		public float rainSizeFar_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainSizeFar_pin_;
		public float rainSizeRandom_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainSizeRandom_pin_;
		public float rainStretchScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainStretchScale_pin_;
		public UnityEngine.Vector4 rainColorGain_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainColorGain_pin_;
		public UnityEngine.Vector4 rainEmissive_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rainEmissive_pin_;
		public float splashEmitRate_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin splashEmitRate_pin_;
		public float splashEmitRadius_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin splashEmitRadius_pin_;
		public UnityEngine.Vector4 splashBirthScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin splashBirthScale_pin_;
		public UnityEngine.Vector4 splashDeathScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin splashDeathScale_pin_;
		public UnityEngine.Vector4 splashColorGain_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin splashColorGain_pin_;
		public UnityEngine.Vector4 splashEmissive_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin splashEmissive_pin_;
		public float blendInTime_;
		public float blendOutTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetRainParticle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Weather.SequenceActionSetRainParticle", 0, Black.Sequence.Action.Weather.SequenceActionSetRainParticle.ObjectType, Construct, properties, 0, 3008);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Weather.SequenceActionSetRainParticle", base.GetFieldProperties(), -1550555019, 1455511672);
            
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
			fieldProperties.AddIndirectlyProperty(new Property("enabled_pin_.pinName_", 2357309002, "Base.String", 384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enabled_pin_.name_", 1197700885, "Base.String", 400, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enabled_pin_.connections_", 2896948621, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 416, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("enabled_pin_.pinValueType_", 458415388, "Base.String", 448, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEnabled_pin_.pinName_", 1863140376, "Base.String", 512, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEnabled_pin_.name_", 1465138355, "Base.String", 528, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEnabled_pin_.connections_", 2483498395, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 544, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rainEnabled_pin_.pinValueType_", 637961830, "Base.String", 576, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashEnabled_pin_.pinName_", 1177109643, "Base.String", 608, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashEnabled_pin_.name_", 3447725766, "Base.String", 624, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashEnabled_pin_.connections_", 2395281020, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 640, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("splashEnabled_pin_.pinValueType_", 3998424351, "Base.String", 672, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitRate_pin_.pinName_", 3873991806, "Base.String", 704, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitRate_pin_.name_", 3536321657, "Base.String", 720, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitRate_pin_.connections_", 3641443017, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 736, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitRate_pin_.pinValueType_", 3559065648, "Base.String", 768, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitRadius_pin_.pinName_", 1306691898, "Base.String", 800, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitRadius_pin_.name_", 937523269, "Base.String", 816, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitRadius_pin_.connections_", 3782453341, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 832, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitRadius_pin_.pinValueType_", 2573430860, "Base.String", 864, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitHeight_pin_.pinName_", 1214497819, "Base.String", 896, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitHeight_pin_.name_", 3028374358, "Base.String", 912, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitHeight_pin_.connections_", 3793091692, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 928, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitHeight_pin_.pinValueType_", 814613423, "Base.String", 960, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitSpeed_pin_.pinName_", 371657419, "Base.String", 992, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitSpeed_pin_.name_", 1170663686, "Base.String", 1008, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitSpeed_pin_.connections_", 3206888892, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1024, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitSpeed_pin_.pinValueType_", 146377311, "Base.String", 1056, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitSpeedRandom_pin_.pinName_", 99357868, "Base.String", 1088, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitSpeedRandom_pin_.name_", 2714980375, "Base.String", 1104, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitSpeedRandom_pin_.connections_", 1597473271, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1120, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitSpeedRandom_pin_.pinValueType_", 4214516250, "Base.String", 1152, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitSpread_pin_.pinName_", 383235559, "Base.String", 1184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitSpread_pin_.name_", 3723712722, "Base.String", 1200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitSpread_pin_.connections_", 535437376, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmitSpread_pin_.pinValueType_", 1119443931, "Base.String", 1248, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainLifespan_pin_.pinName_", 2635579849, "Base.String", 1280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainLifespan_pin_.name_", 2773167060, "Base.String", 1296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainLifespan_pin_.connections_", 2454205482, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1312, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rainLifespan_pin_.pinValueType_", 3099529481, "Base.String", 1344, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainGravity_pin_.pinName_", 2582764643, "Base.String", 1376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainGravity_pin_.name_", 227335502, "Base.String", 1392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainGravity_pin_.connections_", 2460685204, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1408, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rainGravity_pin_.pinValueType_", 1437405895, "Base.String", 1440, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainWindDirection_pin_.pinName_", 2908454126, "Base.String", 1480, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainWindDirection_pin_.name_", 2042344297, "Base.String", 1496, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainWindDirection_pin_.connections_", 4030618585, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1512, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rainWindDirection_pin_.pinValueType_", 1850394976, "Base.String", 1544, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainWindSpeed_pin_.pinName_", 438438288, "Base.String", 1576, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainWindSpeed_pin_.name_", 469029883, "Base.String", 1592, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainWindSpeed_pin_.connections_", 1711527571, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1608, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rainWindSpeed_pin_.pinValueType_", 92481454, "Base.String", 1640, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("globalWindScale_pin_.pinName_", 4149451114, "Base.String", 1672, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("globalWindScale_pin_.name_", 1440008949, "Base.String", 1688, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("globalWindScale_pin_.connections_", 247401069, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1704, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("globalWindScale_pin_.pinValueType_", 466038652, "Base.String", 1736, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainSizeNear_pin_.pinName_", 105368980, "Base.String", 1768, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainSizeNear_pin_.name_", 1947323887, "Base.String", 1784, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainSizeNear_pin_.connections_", 3125304319, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1800, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rainSizeNear_pin_.pinValueType_", 503427442, "Base.String", 1832, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainSizeFar_pin_.pinName_", 2723272271, "Base.String", 1864, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainSizeFar_pin_.name_", 1938445866, "Base.String", 1880, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainSizeFar_pin_.connections_", 2920247976, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1896, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rainSizeFar_pin_.pinValueType_", 2366317363, "Base.String", 1928, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainSizeRandom_pin_.pinName_", 1325138241, "Base.String", 1960, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainSizeRandom_pin_.name_", 2795923388, "Base.String", 1976, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainSizeRandom_pin_.connections_", 1508447778, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1992, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rainSizeRandom_pin_.pinValueType_", 638511633, "Base.String", 2024, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainStretchScale_pin_.pinName_", 1572346294, "Base.String", 2056, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainStretchScale_pin_.name_", 1335558785, "Base.String", 2072, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainStretchScale_pin_.connections_", 2377059809, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2088, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rainStretchScale_pin_.pinValueType_", 794271736, "Base.String", 2120, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainColorGain_pin_.pinName_", 2986988185, "Base.String", 2168, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainColorGain_pin_.name_", 1776040612, "Base.String", 2184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainColorGain_pin_.connections_", 657576538, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2200, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rainColorGain_pin_.pinValueType_", 1142241177, "Base.String", 2232, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmissive_pin_.pinName_", 2713262552, "Base.String", 2280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmissive_pin_.name_", 1101998963, "Base.String", 2296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmissive_pin_.connections_", 2570884187, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2312, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("rainEmissive_pin_.pinValueType_", 3728215334, "Base.String", 2344, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashEmitRate_pin_.pinName_", 1298291499, "Base.String", 2376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashEmitRate_pin_.name_", 2924040358, "Base.String", 2392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashEmitRate_pin_.connections_", 2987159900, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2408, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("splashEmitRate_pin_.pinValueType_", 394660607, "Base.String", 2440, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashEmitRadius_pin_.pinName_", 1143573183, "Base.String", 2472, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashEmitRadius_pin_.name_", 3969418970, "Base.String", 2488, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashEmitRadius_pin_.connections_", 3376647032, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2504, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("splashEmitRadius_pin_.pinValueType_", 3183793699, "Base.String", 2536, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashBirthScale_pin_.pinName_", 1072738643, "Base.String", 2584, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashBirthScale_pin_.name_", 2058563902, "Base.String", 2600, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashBirthScale_pin_.connections_", 2904148260, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2616, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("splashBirthScale_pin_.pinValueType_", 1295412727, "Base.String", 2648, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashDeathScale_pin_.pinName_", 2427017882, "Base.String", 2696, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashDeathScale_pin_.name_", 3678598501, "Base.String", 2712, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashDeathScale_pin_.connections_", 623459581, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2728, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("splashDeathScale_pin_.pinValueType_", 3204802540, "Base.String", 2760, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashColorGain_pin_.pinName_", 2624237974, "Base.String", 2808, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashColorGain_pin_.name_", 3709468961, "Base.String", 2824, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashColorGain_pin_.connections_", 3698681985, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2840, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("splashColorGain_pin_.pinValueType_", 3756747928, "Base.String", 2872, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashEmissive_pin_.pinName_", 2142694293, "Base.String", 2920, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashEmissive_pin_.name_", 1179263504, "Base.String", 2936, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("splashEmissive_pin_.connections_", 3545078238, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2952, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("splashEmissive_pin_.pinValueType_", 199699221, "Base.String", 2984, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_pin_", 3058841247, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 376, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableWeather_", 1384777099, "bool", 464, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("dofEnabled_", 3787647060, "bool", 465, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientColor_", 1965402543, "SQEX.Luminous.Math.VectorA", 480, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("depthMapRadius_", 1020642063, "float", 496, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEnabled_", 617554293, "bool", 500, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEnabled_pin_", 2832330177, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 504, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashEnabled_", 2766504612, "bool", 592, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashEnabled_pin_", 871690180, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 600, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitRate_", 2962418847, "float", 688, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitRate_pin_", 1763016171, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 696, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitRadius_", 3581722915, "float", 784, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitRadius_pin_", 3501027439, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 792, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitHeight_", 2650479252, "float", 880, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitHeight_pin_", 1580683060, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 888, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitSpeed_", 3778395748, "float", 976, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitSpeed_pin_", 818018180, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 984, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitSpeedRandom_", 839388369, "float", 1072, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitSpeedRandom_pin_", 4111211789, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1080, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitSpread_", 3416784616, "float", 1168, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmitSpread_pin_", 385179624, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainLifespan_", 661299246, "float", 1264, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainLifespan_pin_", 1156533934, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainGravity_", 938635068, "float", 1360, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainGravity_pin_", 2312393100, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainWindDirection_", 3954469551, "SQEX.Luminous.Math.VectorA", 1456, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainWindDirection_pin_", 301775739, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1472, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainWindSpeed_", 1419610701, "float", 1560, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainWindSpeed_pin_", 2819240617, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("globalWindScale_", 1269670579, "float", 1656, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("globalWindScale_pin_", 1575729983, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1664, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainSizeNear_", 1247283001, "float", 1752, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainSizeNear_pin_", 2565057413, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1760, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainSizeFar_", 3636517904, "float", 1848, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainSizeFar_pin_", 1249877504, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1856, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainSizeRandom_", 4014427334, "float", 1944, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainSizeRandom_pin_", 3820542294, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1952, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainStretchScale_", 2608817207, "float", 2040, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainStretchScale_pin_", 999253971, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2048, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainColorGain_", 3925428830, "SQEX.Luminous.Math.VectorA", 2144, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainColorGain_pin_", 3710844446, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2160, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmissive_", 1059121077, "SQEX.Luminous.Math.VectorA", 2256, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainEmissive_pin_", 2739210241, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashEmitRate_", 3348433156, "float", 2360, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashEmitRate_pin_", 294235492, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashEmitRadius_", 2759563680, "float", 2456, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashEmitRadius_pin_", 2198464912, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2464, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashBirthScale_", 1469133772, "SQEX.Luminous.Math.VectorA", 2560, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashBirthScale_pin_", 2778509404, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2576, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashDeathScale_", 82969667, "SQEX.Luminous.Math.VectorA", 2672, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashDeathScale_pin_", 2535546319, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2688, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashColorGain_", 3739973847, "SQEX.Luminous.Math.VectorA", 2784, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashColorGain_pin_", 2499081523, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2800, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashEmissive_", 1428037666, "SQEX.Luminous.Math.VectorA", 2896, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("splashEmissive_pin_", 2074440850, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2912, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blendInTime_", 3541416507, "float", 3000, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blendOutTime_", 284564038, "float", 3004, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionSetRainParticle();
        }
		
    }
}