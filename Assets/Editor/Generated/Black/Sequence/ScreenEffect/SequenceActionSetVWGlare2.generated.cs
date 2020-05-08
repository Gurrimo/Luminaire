using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.ScreenEffect
{
    public partial class SequenceActionSetVWGlare2 : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enabled_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin softAmount_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin softExpand_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin foggyAmount_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin foggyExpand_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin useColoring_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin soft_r_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin soft_g_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin soft_b_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin foggy_r_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin foggy_g_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin foggy_b_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sparkBlend_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sparkAttenuation_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sparkShape_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sparkRotation_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin useSparkColoring_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spark_r_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spark_g_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spark_b_pin_;
		public Black.Sequence.ScreenEffect.VWGlareFilterSequenceData masterData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVWGlare2();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.ScreenEffect.SequenceActionSetVWGlare2", 0, Black.Sequence.ScreenEffect.SequenceActionSetVWGlare2.ObjectType, Construct, properties, 0, 2320);
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

            fieldProperties = new PropertyContainer("Black.Sequence.ScreenEffect.SequenceActionSetVWGlare2", base.GetFieldProperties(), 725916156, 203152158);
            
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
			fieldProperties.AddIndirectlyProperty(new Property("enabled_pin_.pinName_", 2357309002, "Base.String", 376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enabled_pin_.name_", 1197700885, "Base.String", 392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enabled_pin_.connections_", 2896948621, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 408, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("enabled_pin_.pinValueType_", 458415388, "Base.String", 440, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("softAmount_pin_.pinName_", 4023952837, "Base.String", 552, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("softAmount_pin_.name_", 3801905280, "Base.String", 568, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("softAmount_pin_.connections_", 286503726, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 584, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("softAmount_pin_.pinValueType_", 1470516165, "Base.String", 616, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("softExpand_pin_.pinName_", 2208143549, "Base.String", 640, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("softExpand_pin_.name_", 1055273672, "Base.String", 656, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("softExpand_pin_.connections_", 2262387462, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 672, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("softExpand_pin_.pinValueType_", 500364045, "Base.String", 704, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("foggyAmount_pin_.pinName_", 497784135, "Base.String", 728, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("foggyAmount_pin_.name_", 372023410, "Base.String", 744, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("foggyAmount_pin_.connections_", 1983570656, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 760, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("foggyAmount_pin_.pinValueType_", 3725833595, "Base.String", 792, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("foggyExpand_pin_.pinName_", 3095251459, "Base.String", 816, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("foggyExpand_pin_.name_", 2356618670, "Base.String", 832, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("foggyExpand_pin_.connections_", 4140104180, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 848, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("foggyExpand_pin_.pinValueType_", 4278833831, "Base.String", 880, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useColoring_pin_.pinName_", 3189268065, "Base.String", 904, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useColoring_pin_.name_", 3167212316, "Base.String", 920, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useColoring_pin_.connections_", 3911016706, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 936, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("useColoring_pin_.pinValueType_", 777447793, "Base.String", 968, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("soft_r_pin_.pinName_", 902129084, "Base.String", 992, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("soft_r_pin_.name_", 974269287, "Base.String", 1008, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("soft_r_pin_.connections_", 3678246695, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1024, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("soft_r_pin_.pinValueType_", 886913898, "Base.String", 1056, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("soft_g_pin_.pinName_", 361228211, "Base.String", 1080, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("soft_g_pin_.name_", 731840222, "Base.String", 1096, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("soft_g_pin_.connections_", 3758798404, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("soft_g_pin_.pinValueType_", 2735505431, "Base.String", 1144, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("soft_b_pin_.pinName_", 1704102988, "Base.String", 1168, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("soft_b_pin_.name_", 3488429047, "Base.String", 1184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("soft_b_pin_.connections_", 943492567, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1200, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("soft_b_pin_.pinValueType_", 1896839802, "Base.String", 1232, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("foggy_r_pin_.pinName_", 1724146070, "Base.String", 1256, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("foggy_r_pin_.name_", 510202145, "Base.String", 1272, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("foggy_r_pin_.connections_", 2662996097, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1288, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("foggy_r_pin_.pinValueType_", 2987162776, "Base.String", 1320, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("foggy_g_pin_.pinName_", 2528658101, "Base.String", 1344, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("foggy_g_pin_.name_", 1995236080, "Base.String", 1360, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("foggy_g_pin_.connections_", 678011198, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1376, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("foggy_g_pin_.pinValueType_", 3174190069, "Base.String", 1408, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("foggy_b_pin_.pinName_", 3650665574, "Base.String", 1432, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("foggy_b_pin_.name_", 2196201393, "Base.String", 1448, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("foggy_b_pin_.connections_", 3453298481, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1464, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("foggy_b_pin_.pinValueType_", 545084136, "Base.String", 1496, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sparkBlend_pin_.pinName_", 2674535581, "Base.String", 1520, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sparkBlend_pin_.name_", 779020136, "Base.String", 1536, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sparkBlend_pin_.connections_", 1381618598, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1552, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sparkBlend_pin_.pinValueType_", 4219809453, "Base.String", 1584, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sparkAttenuation_pin_.pinName_", 770166246, "Base.String", 1608, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sparkAttenuation_pin_.name_", 3287819313, "Base.String", 1624, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sparkAttenuation_pin_.connections_", 3731083441, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1640, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sparkAttenuation_pin_.pinValueType_", 2970756968, "Base.String", 1672, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sparkShape_pin_.pinName_", 3031128551, "Base.String", 1696, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sparkShape_pin_.name_", 780387538, "Base.String", 1712, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sparkShape_pin_.connections_", 3763602496, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1728, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sparkShape_pin_.pinValueType_", 694896603, "Base.String", 1760, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sparkRotation_pin_.pinName_", 3993445512, "Base.String", 1784, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sparkRotation_pin_.name_", 2639597923, "Base.String", 1800, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sparkRotation_pin_.connections_", 3503316075, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1816, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sparkRotation_pin_.pinValueType_", 2582751510, "Base.String", 1848, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useSparkColoring_pin_.pinName_", 1783632052, "Base.String", 1872, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useSparkColoring_pin_.name_", 3194881487, "Base.String", 1888, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useSparkColoring_pin_.connections_", 280170591, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1904, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("useSparkColoring_pin_.pinValueType_", 3570692562, "Base.String", 1936, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("spark_r_pin_.pinName_", 3208840039, "Base.String", 1960, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("spark_r_pin_.name_", 3329708370, "Base.String", 1976, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("spark_r_pin_.connections_", 152880576, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1992, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("spark_r_pin_.pinValueType_", 3715359835, "Base.String", 2024, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("spark_g_pin_.pinName_", 503822856, "Base.String", 2048, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("spark_g_pin_.name_", 671343075, "Base.String", 2064, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("spark_g_pin_.connections_", 3617901035, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2080, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("spark_g_pin_.pinValueType_", 3663333782, "Base.String", 2112, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("spark_b_pin_.pinName_", 4076991575, "Base.String", 2136, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("spark_b_pin_.name_", 941750210, "Base.String", 2152, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("spark_b_pin_.connections_", 1028463504, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2168, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("spark_b_pin_.pinValueType_", 1138771147, "Base.String", 2200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.enabled_", 2295565220, "bool", 2224, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.enableWeather_", 3172807716, "bool", 2225, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.gammaSpace_", 1086394236, "float", 2228, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.softAmount_", 2355918355, "float", 2232, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.softExpand_", 2438924987, "float", 2236, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.foggyAmount_", 743179375, "float", 2240, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.foggyExpand_", 1706157815, "float", 2244, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.useColoring_", 2003827489, "bool", 2248, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.soft_r_", 668618816, "float", 2252, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.soft_g_", 1744107645, "float", 2256, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.soft_b_", 671178672, "float", 2260, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.foggy_r_", 3834822892, "float", 2264, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.foggy_g_", 2758936705, "float", 2268, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.foggy_b_", 2758495420, "float", 2272, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.sparkBlend_", 3225603631, "float", 2276, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.sparkAttenuation_", 555550350, "float", 2280, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.sparkShape_", 2912147889, "int", 2284, 4, 1, Property.PrimitiveType.Int32, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.sparkRotation_", 1256377902, "float", 2288, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.useSparkColoring_", 2249473680, "bool", 2292, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.spark_r_", 414053199, "float", 2296, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.spark_g_", 416171770, "float", 2300, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.spark_b_", 1490380671, "float", 2304, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.debugGraph_", 1988355284, "bool", 2308, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.debugIndex_", 1674195096, "int", 2312, 4, 1, Property.PrimitiveType.Int32, 0, (char)1));
			
			
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_pin_", 3058841247, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("softAmount_pin_", 1829042274, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 544, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("softExpand_pin_", 2113414506, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 632, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("foggyAmount_pin_", 2304662088, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 720, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("foggyExpand_pin_", 3506368940, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 808, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("useColoring_pin_", 2711753462, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 896, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("soft_r_pin_", 4152931325, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 984, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("soft_g_pin_", 1554628540, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1072, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("soft_b_pin_", 813039533, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1160, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("foggy_r_pin_", 2350941491, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1248, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("foggy_g_pin_", 405601586, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1336, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("foggy_b_pin_", 3453525987, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1424, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sparkBlend_pin_", 3904850762, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1512, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sparkAttenuation_pin_", 2652219491, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1600, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sparkShape_pin_", 387722216, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1688, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sparkRotation_pin_", 1797147281, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1776, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("useSparkColoring_pin_", 727619365, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1864, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("spark_r_pin_", 508836968, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1952, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("spark_g_pin_", 3265576721, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2040, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("spark_b_pin_", 4265126520, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2128, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("masterData_", 2084001356, "Black.Sequence.ScreenEffect.VWGlareFilterSequenceData", 2216, 104, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionSetVWGlare2();
        }
		
    }
}