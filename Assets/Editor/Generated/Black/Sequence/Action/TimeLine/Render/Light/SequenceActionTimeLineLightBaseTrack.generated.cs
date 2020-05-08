using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render.Light
{
    public partial class SequenceActionTimeLineLightBaseTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.Sequence.Action.TimeLine.Render.Light.Struct.LightBaseData masterData_;
		public bool isLightDisableWhenSkip_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineLightBaseTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.Light.SequenceActionTimeLineLightBaseTrack", 0, Black.Sequence.Action.TimeLine.Render.Light.SequenceActionTimeLineLightBaseTrack.ObjectType, Construct, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.Light.SequenceActionTimeLineLightBaseTrack", base.GetFieldProperties(), 1719503952, 454026431);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("curveList_", 1657928633, "SQEX.Ebony.Framework.TimeControl.CurveList", 176, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("curveList_.propertyList_", 3952472237, "SQEX.Ebony.Std.DynamicArray< AnchorReferenceValue* >", 184, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddIndirectlyProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 208, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.pinName_", 3330161590, "Base.String", 216, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.name_", 192292993, "Base.String", 232, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.connections_", 490033121, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 248, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayType_", 261766523, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 280, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayTime_", 1689218608, "float", 284, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayMaxTime_", 1529341114, "float", 288, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.enabled_", 2295565220, "bool", 344, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.diffuseOnly_", 2771345091, "bool", 345, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.smoothFalloff_", 3275028675, "bool", 346, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.color_", 665291330, "SQEX.Luminous.RenderInterface.Color", 352, 16, 1, Property.PrimitiveType.Color, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.intensity_", 1692969208, "float", 368, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.intensityEV_", 1984899437, "float", 372, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.radius_", 3631016545, "float", 376, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.range_", 2436041796, "float", 380, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.shadowEnabled_", 1536951108, "bool", 384, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.shadowResolution_", 1564179793, "int", 388, 4, 1, Property.PrimitiveType.Int32, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.shadowZNear_", 2935939035, "float", 392, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.shadowZBias_", 1588836146, "float", 396, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.shadowSlopeBias_", 269915413, "float", 400, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.shadowPower_", 3200089208, "float", 404, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.shadowPowerHair_", 2270133824, "float", 408, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.saoTerm_", 3618293454, "float", 412, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.chrOnlyShadow_", 3175450304, "bool", 416, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.shadowWarpEnabled_", 2619923854, "bool", 417, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.volLightEnabled_", 787964219, "bool", 418, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.volLightIntensity_", 1508612327, "float", 420, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.volLightDistantIntensity_", 2489076140, "float", 424, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.volLightZOffset_", 2087778223, "float", 428, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.lpvEnabled_", 1581173246, "bool", 432, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.vsglEnabled_", 3552493040, "bool", 433, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			
			
			fieldProperties.AddProperty(new Property("masterData_", 2084001356, "Black.Sequence.Action.TimeLine.Render.Light.Struct.LightBaseData", 336, 112, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isLightDisableWhenSkip_", 3662769999, "bool", 477, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionTimeLineLightBaseTrack();
        }
		
    }
}