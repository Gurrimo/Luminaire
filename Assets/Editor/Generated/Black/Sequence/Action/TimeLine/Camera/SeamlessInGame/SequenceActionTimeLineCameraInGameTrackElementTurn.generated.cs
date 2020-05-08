using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Camera.SeamlessInGame
{
    public partial class SequenceActionTimeLineCameraInGameTrackElementTurn : Black.Sequence.Action.TimeLine.SequenceActionTimeLineDurationTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurn masterTurnData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraInGameTrackElementTurn();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Camera.SeamlessInGame.SequenceActionTimeLineCameraInGameTrackElementTurn", 0, Black.Sequence.Action.TimeLine.Camera.SeamlessInGame.SequenceActionTimeLineCameraInGameTrackElementTurn.ObjectType, Construct, properties, 0, 496);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Camera.SeamlessInGame.SequenceActionTimeLineCameraInGameTrackElementTurn", base.GetFieldProperties(), 648796184, 928716426);
            
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
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.isOverrideLockOnLayer_", 4071546813, "bool", 408, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.isUseLockOnTurn_", 1499760570, "bool", 409, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.isUseLockOnTurnTilt_", 2954492015, "bool", 410, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.controlTurn_", 1392917018, "Black.Camera.Struct.CameraControlTurn", 416, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.controlTurn_.mode", 3499628991, "Black.Camera.Struct.CameraControlTurnMode", 424, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.controlTurn_.isUseAutoAdjustMode_", 742412025, "bool", 428, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.controlTurn_.isUseAutoAdjustAngleMode_", 1905124082, "bool", 429, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.controlTurn_.isUseDefaultBrakeParam_", 2241175301, "bool", 430, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.controlTurn_.controlTurnVelocity_", 491769510, "float", 432, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.controlTurn_.backToDefaultTurnVelocity_", 2720627432, "float", 436, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.controlTurn_.yawMin_", 3764617738, "float", 440, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.controlTurn_.yawMax_", 1196333056, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.controlTurn_.tiltMin_", 2362450470, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.controlTurn_.tiltMax_", 1714066804, "float", 452, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.controlTurn_.brakeAngleYaw_", 1419262338, "float", 456, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.controlTurn_.brakePowerYaw_", 136079884, "float", 460, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.controlTurn_.brakeAngleTilt_", 782862254, "float", 464, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.controlTurn_.brakePowerTilt_", 2081803448, "float", 468, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.angleLimit_", 3390083944, "Black.Camera.Struct.CameraAngleLimit", 472, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.angleLimit_.tiltAngleLimitMode_", 3263763757, "Black.Camera.CameraAngleLimitMode", 480, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.angleLimit_.tiltAngleLimitMin_", 857232858, "float", 484, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTurnData_.angleLimit_.tiltAngleLimitMax_", 1504924976, "float", 488, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			
			
			fieldProperties.AddProperty(new Property("masterTurnData_", 904621, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurn", 400, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionTimeLineCameraInGameTrackElementTurn();
        }
		
    }
}