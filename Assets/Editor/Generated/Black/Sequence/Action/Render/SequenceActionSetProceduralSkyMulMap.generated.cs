using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Render
{
    public partial class SequenceActionSetProceduralSkyMulMap : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enableWeather_;
		public bool enableMulMap_;
		public UnityEngine.Color bgColor_;
		public float bgPower_;
		public float blendPower_;
		public UnityEngine.Color discColor_;
		public float discPower_;
		public float angleSoft_;
		public float angleHard_;
		public float phi_;
		public float thetaX_;
		public float thetaY_;
		public UnityEngine.Color discColor2_;
		public float discPower2_;
		public float angleSoft2_;
		public float angleHard2_;
		public float phi2_;
		public float thetaX2_;
		public float thetaY2_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetProceduralSkyMulMap();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Render.SequenceActionSetProceduralSkyMulMap", 0, Black.Sequence.Action.Render.SequenceActionSetProceduralSkyMulMap.ObjectType, Construct, properties, 0, 512);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Render.SequenceActionSetProceduralSkyMulMap", base.GetFieldProperties(), 1141004260, 1875361245);
            
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
			
			
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableWeather_", 1384777099, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableMulMap_", 2637357027, "bool", 369, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bgColor_", 3211196290, "Luminous.RenderInterface.Color", 384, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("bgPower_", 731530264, "float", 400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blendPower_", 3676737706, "float", 404, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("discColor_", 118022340, "Luminous.RenderInterface.Color", 416, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("discPower_", 1284292862, "float", 432, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("angleSoft_", 1589430157, "float", 436, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("angleHard_", 3607570798, "float", 440, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("phi_", 1561917121, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("thetaX_", 1977690962, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("thetaY_", 1977543867, "float", 452, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("discColor2_", 2922213220, "Luminous.RenderInterface.Color", 464, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("discPower2_", 574410702, "float", 480, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("angleSoft2_", 884928203, "float", 484, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("angleHard2_", 1915501118, "float", 488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("phi2_", 737234919, "float", 492, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("thetaX2_", 2664645450, "float", 496, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("thetaY2_", 1915867353, "float", 500, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionSetProceduralSkyMulMap();
        }
		
    }
}