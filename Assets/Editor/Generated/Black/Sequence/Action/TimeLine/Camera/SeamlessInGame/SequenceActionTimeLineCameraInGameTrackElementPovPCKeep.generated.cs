using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Camera.SeamlessInGame
{
    public partial class SequenceActionTimeLineCameraInGameTrackElementPovPCKeep : Black.Sequence.Action.TimeLine.SequenceActionTimeLineDurationTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPog masterPogData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPov masterPovData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraInGameTrackElementPovPCKeep();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Camera.SeamlessInGame.SequenceActionTimeLineCameraInGameTrackElementPovPCKeep", 0, Black.Sequence.Action.TimeLine.Camera.SeamlessInGame.SequenceActionTimeLineCameraInGameTrackElementPovPCKeep.ObjectType, Construct, properties, 0, 656);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Camera.SeamlessInGame.SequenceActionTimeLineCameraInGameTrackElementPovPCKeep", base.GetFieldProperties(), -1979764609, -211907203);
            
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
			fieldProperties.AddIndirectlyProperty(new Property("masterPogData_.lockOnType_", 606503405, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnType", 408, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPogData_.actorBaseType_", 951711875, "Black.Camera.SeamlessInGameActorBaseType", 412, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPogData_.lockOnActorOffsetType_", 601760843, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnActorOffsetType", 416, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPogData_.boneId_", 3040633746, "SQEX.Ebony.Std.Fixid", 420, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPogData_.coordInterpType_", 3105311038, "Black.Camera.CoordInterpType", 424, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPogData_.pogInterpTime_", 2592161260, "float", 428, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPogData_.pogTimeInterpMode_", 2412586465, "SQEX.Ebony.Framework.TimeControl.InterpMode", 432, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPogData_.pogVelocity_", 503160096, "float", 436, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterPogData_.isUpdateYDirectly_", 4122431705, "bool", 440, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPogData_.pogDirectionYVelocity_", 984199312, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterPogData_.matrixType_", 2728059240, "Black.Camera.MatrixType", 448, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPogData_.offsetType_", 365653606, "Black.Camera.SeamlessInGameOffsetType", 452, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPogData_.pogOffset_", 553863872, "Luminous.Math.VectorA", 464, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterPogData_.isUseAddOffsetXByProjectionBetweenPCandTarget_", 1152078323, "bool", 496, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPogData_.addOffsetXSabunMultiplyRate_", 2683774230, "float", 500, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterPogData_.addOffsetXMaxLimit_", 2395626720, "float", 504, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterPogData_.isUpdateXEveryFrame_", 1027698298, "bool", 508, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPogData_.isUpdateYEveryFrame__", 14758408, "bool", 509, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPogData_.isUpdateZEveryFrame_", 1318827764, "bool", 510, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.lockOnType_", 1657257868, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnType", 520, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.actorBaseType_", 3681696472, "Black.Camera.SeamlessInGameActorBaseType", 524, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.lockOnActorOffsetType_", 3600432452, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnActorOffsetType", 528, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.boneId_", 3830842479, "SQEX.Ebony.Std.Fixid", 532, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.autoCompositionBaseType_", 652427114, "Black.Camera.AutoCompositionBaseType", 536, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.autoCompositionUpdateType_", 1477130990, "Black.Camera.AutoCompositionUpdateType", 540, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.valueSettingType_", 2226103011, "Black.Camera.ValueSettingType", 548, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.incEyeDistance_", 2722141260, "float", 552, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.isDisableBattleAddDistance_", 1091784636, "bool", 556, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.seamlessInGameFlameInAddDistanceCalcType_", 367956647, "Black.Camera.SeamlessInGameFlameInAddDistanceCalcType", 560, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.isDisableAroundStatusAddDistance_", 3212550641, "bool", 564, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.addDistanceRate_", 2904744918, "float", 568, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.isDisableAngleDiffBetweenCam2PCAddDistance_", 1740143220, "bool", 572, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.overrideEyeDistance_", 1849167434, "float", 576, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.minimumGuaranteeEyeDistance_", 2757314104, "float", 580, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.povVelocity_", 706263994, "float", 584, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.matrixType_", 673707929, "Black.Camera.MatrixType", 588, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.povOffset_", 3417217590, "Luminous.Math.VectorA", 592, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.offsetXValueType_", 3063012168, "Black.Camera.OffsetXValueType", 608, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.autoCompositionShotSize_", 2732625038, "int", 612, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.autoCompositionFovLevel_", 2909018576, "int", 616, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.autoCompositionPovBoneId_", 3160282871, "SQEX.Ebony.Std.Fixid", 620, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.autoCompositionFlameHeightRate_", 2217224783, "float", 624, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.autoCompositionFlameHeightYawRate_", 3054767298, "float", 628, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.isUpdateXEveryFrame_", 126339889, "bool", 632, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.isUpdateYEveryFrame__", 1212795969, "bool", 633, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterPovData_.isUpdateZEveryFrame_", 1729795479, "bool", 634, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("masterPogData_", 849868872, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPog", 400, 112, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("masterPovData_", 1457572513, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPov", 512, 128, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionTimeLineCameraInGameTrackElementPovPCKeep();
        }
		
    }
}