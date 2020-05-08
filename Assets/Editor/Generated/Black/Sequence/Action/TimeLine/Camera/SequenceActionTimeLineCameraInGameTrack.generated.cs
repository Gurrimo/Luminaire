using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Camera
{
    public partial class SequenceActionTimeLineCameraInGameTrack : Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin eyeTargetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnYawPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnTiltPin_;
		public Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItem masterTrackItem_;
		public bool isNeedTurnYaw_;
		public bool isNeedTurnTilt_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraInGameTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameTrack", 0, Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameTrack.ObjectType, Construct, properties, 0, 2384);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameTrack", base.GetFieldProperties(), 1295662871, 732374047);
            
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
			fieldProperties.AddIndirectlyProperty(new Property("turnDirectionPin_", 1770360715, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 400, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnDirectionPin_.pinName_", 1537193374, "Base.String", 408, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnDirectionPin_.name_", 226127449, "Base.String", 424, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnDirectionPin_.connections_", 3653759657, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 440, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnDirectionPin_.pinValueType_", 796566288, "Base.String", 472, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isUseEndReserve_", 1132012408, "bool", 488, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actorPin_.pinName_", 61679437, "Base.String", 512, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actorPin_.name_", 700809432, "Base.String", 528, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actorPin_.connections_", 2962364278, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 544, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("actorPin_.pinValueType_", 2807496477, "Base.String", 576, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("eyeTargetPin_.pinName_", 2468407506, "Base.String", 600, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("eyeTargetPin_.name_", 173093453, "Base.String", 616, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("eyeTargetPin_.connections_", 2483192245, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 632, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("eyeTargetPin_.pinValueType_", 1791315380, "Base.String", 664, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawPin_.pinName_", 1831740656, "Base.String", 688, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawPin_.name_", 669719579, "Base.String", 704, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawPin_.connections_", 188086195, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 720, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawPin_.pinValueType_", 2809084494, "Base.String", 752, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltPin_.pinName_", 1997149052, "Base.String", 776, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltPin_.name_", 35171879, "Base.String", 792, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltPin_.connections_", 4087771367, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 808, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltPin_.pinValueType_", 4245306154, "Base.String", 840, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.name_", 368818912, "Ebony.Base.String", 872, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.startTime_", 2047928410, "float", 888, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.duration_", 3412329161, "float", 892, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_", 2999013918, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCommon", 952, 80, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.mode", 3177227107, "Black.Camera.InGameSeamlessTargetMode", 960, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.startEndBlendMode_", 3925174400, "Black.Camera.SeamlessInGameSeparateStartEndBlendMode", 964, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.isCheckCollision_", 3751520453, "bool", 968, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.collisionData_", 2964762557, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCollision", 976, 40, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.collisionData_.checkCollisionType_", 4084575422, "Black.Camera.CheckCollisionType", 984, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.collisionData_.isNeedCheckFocusFromPC_", 749253553, "bool", 988, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.collisionData_.isNeedCheckAdjustPog_", 2830568471, "bool", 989, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.collisionData_.isNeedCheckGroundHeight_", 2565853328, "bool", 990, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.collisionData_.groundCheckMarginHeight_", 606489648, "float", 992, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.collisionData_.groundCheckMinimumHeight_", 665399486, "float", 996, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.collisionData_.isEnableCharaFadeOutWhenCollidedByCamera_", 1974250914, "bool", 1000, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.collisionData_.isEnablePCFadeWhenCollidedByCamera_", 2862026470, "bool", 1001, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.collisionData_.isUsePCFaseFadeWhenCollidedByCamera_", 892244727, "bool", 1002, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.collisionData_.isUseAdjustFadeMinPowerWhenCollidedByCamera_", 3498794993, "bool", 1003, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.collisionData_.charaFadeByCameraSphereRadius_", 112785316, "float", 1004, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.collisionData_.isEndBlendCheckCollision_", 982784634, "bool", 1008, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.collisionData_.endBlendCheckCollisionType_", 22805442, "Black.Camera.CheckCollisionType", 1012, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.isEnableCancelWhenPCFrameOut_", 763712980, "bool", 1016, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.isEnableCancelWhenTerribleCollieded_", 3912447432, "bool", 1017, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.isCutChangeOrder", 983385608, "bool", 1018, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.isNeedClearCameraContainerBlendDataWhenCutChange_", 3952174961, "bool", 1019, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.isUseBattleAssistRotationWhenNotControlingYaw_", 930030242, "bool", 1020, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.isIgnoreCameraShake_", 458109042, "bool", 1021, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.autoCompositionShotType_", 2476035352, "Black.Camera.AutoCompositionShotType", 1024, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.commonData_.isNeedCaptureForOtherRelativeTarget_", 4142265709, "bool", 1028, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_", 3815686079, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPog", 1040, 112, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_.lockOnType_", 260362758, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnType", 1048, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_.actorBaseType_", 1823883998, "Black.Camera.SeamlessInGameActorBaseType", 1052, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_.lockOnActorOffsetType_", 1561779454, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnActorOffsetType", 1056, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_.boneId_", 3983947425, "SQEX.Ebony.Std.Fixid", 1060, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_.coordInterpType_", 1455858475, "Black.Camera.CoordInterpType", 1064, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_.pogInterpTime_", 2838434817, "float", 1068, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_.pogTimeInterpMode_", 2932825664, "SQEX.Ebony.Framework.TimeControl.InterpMode", 1072, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_.pogVelocity_", 3946131637, "float", 1076, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_.isUpdateYDirectly_", 591627508, "bool", 1080, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_.pogDirectionYVelocity_", 3649394609, "float", 1084, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_.matrixType_", 616991243, "Black.Camera.MatrixType", 1088, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_.offsetType_", 990983429, "Black.Camera.SeamlessInGameOffsetType", 1092, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_.pogOffset_", 3606908561, "Luminous.Math.VectorA", 1104, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_.isUseAddOffsetXByProjectionBetweenPCandTarget_", 1123538082, "bool", 1136, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_.addOffsetXSabunMultiplyRate_", 2188034971, "float", 1140, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_.addOffsetXMaxLimit_", 3815069443, "float", 1144, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_.isUpdateXEveryFrame_", 1929341007, "bool", 1148, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_.isUpdateYEveryFrame__", 4182406535, "bool", 1149, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.pogData_.isUpdateZEveryFrame_", 2996077033, "bool", 1150, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_", 265320694, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPov", 1152, 128, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.lockOnType_", 721697375, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnType", 1160, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.actorBaseType_", 4249232361, "Black.Camera.SeamlessInGameActorBaseType", 1164, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.lockOnActorOffsetType_", 3418931501, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnActorOffsetType", 1168, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.boneId_", 3286888828, "SQEX.Ebony.Std.Fixid", 1172, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.autoCompositionBaseType_", 1228667455, "Black.Camera.AutoCompositionBaseType", 1176, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.autoCompositionUpdateType_", 1808125579, "Black.Camera.AutoCompositionUpdateType", 1180, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.valueSettingType_", 3495118376, "Black.Camera.ValueSettingType", 1188, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.incEyeDistance_", 368526171, "float", 1192, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.isDisableBattleAddDistance_", 1919662983, "bool", 1196, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.seamlessInGameFlameInAddDistanceCalcType_", 3921052468, "Black.Camera.SeamlessInGameFlameInAddDistanceCalcType", 1200, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.isDisableAroundStatusAddDistance_", 2664125786, "bool", 1204, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.addDistanceRate_", 3762958811, "float", 1208, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.isDisableAngleDiffBetweenCam2PCAddDistance_", 1230717183, "bool", 1212, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.overrideEyeDistance_", 1373879631, "float", 1216, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.minimumGuaranteeEyeDistance_", 1111018621, "float", 1220, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.povVelocity_", 2843826515, "float", 1224, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.matrixType_", 1072013778, "Black.Camera.MatrixType", 1228, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.povOffset_", 454156779, "Luminous.Math.VectorA", 1232, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.offsetXValueType_", 3385400459, "Black.Camera.OffsetXValueType", 1248, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.autoCompositionShotSize_", 3029198307, "int", 1252, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.autoCompositionFovLevel_", 79164001, "int", 1256, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.autoCompositionPovBoneId_", 2497534604, "SQEX.Ebony.Std.Fixid", 1260, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.autoCompositionFlameHeightRate_", 184791932, "float", 1264, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.autoCompositionFlameHeightYawRate_", 2483097363, "float", 1268, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.isUpdateXEveryFrame_", 3795529616, "bool", 1272, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.isUpdateYEveryFrame__", 3599245734, "bool", 1273, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.povData_.isUpdateZEveryFrame_", 2438348374, "bool", 1274, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_", 1548138100, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurn", 1280, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.isOverrideLockOnLayer_", 1667879470, "bool", 1288, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.isUseLockOnTurn_", 1067834349, "bool", 1289, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.isUseLockOnTurnTilt_", 1342875256, "bool", 1290, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.controlTurn_", 1338413909, "Black.Camera.Struct.CameraControlTurn", 1296, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.controlTurn_.mode", 2935117694, "Black.Camera.Struct.CameraControlTurnMode", 1304, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.controlTurn_.isUseAutoAdjustMode_", 1329246660, "bool", 1308, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.controlTurn_.isUseAutoAdjustAngleMode_", 256041497, "bool", 1309, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.controlTurn_.isUseDefaultBrakeParam_", 4004511626, "bool", 1310, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.controlTurn_.controlTurnVelocity_", 3989147635, "float", 1312, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.controlTurn_.backToDefaultTurnVelocity_", 1554223081, "float", 1316, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.controlTurn_.yawMin_", 3380970645, "float", 1320, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.controlTurn_.yawMax_", 808154631, "float", 1324, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.controlTurn_.tiltMin_", 50841971, "float", 1328, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.controlTurn_.tiltMax_", 1551273465, "float", 1332, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.controlTurn_.brakeAngleYaw_", 2391089943, "float", 1336, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.controlTurn_.brakePowerYaw_", 2019255461, "float", 1340, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.controlTurn_.brakeAngleTilt_", 1195557165, "float", 1344, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.controlTurn_.brakePowerTilt_", 3956265227, "float", 1348, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.angleLimit_", 2838479553, "Black.Camera.Struct.CameraAngleLimit", 1352, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.angleLimit_.tiltAngleLimitMode_", 439140280, "Black.Camera.CameraAngleLimitMode", 1360, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.angleLimit_.tiltAngleLimitMin_", 3104131189, "float", 1364, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnData_.angleLimit_.tiltAngleLimitMax_", 531315175, "float", 1368, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnYawData_", 3832971083, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYaw", 1376, 72, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnYawData_.isUse_", 1678055671, "bool", 1384, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnYawData_.rotationUseValueTypeYaw_", 928615745, "Black.Camera.RotationUseValueType", 1388, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnYawData_.isNotControllingYawWhenBattleHybridAndOverride_", 2393697182, "bool", 1392, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnYawData_.bestAngleJudgeType_", 2703247412, "Black.Camera.BestAngleJudgeType", 1396, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnYawData_.turnInterpType_", 320536871, "Black.Camera.RotationInterpType", 1400, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnYawData_.turnTimeInterpMode_", 3302818585, "Black.Camera.BlendModeType", 1404, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnYawData_.rotationDirection_", 1449083499, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 1408, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnYawData_.isCalcAlwaysBehindPC_", 2666002827, "bool", 1412, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnYawData_.isUpdateTurnEveryFrame_", 2829803526, "bool", 1413, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnYawData_.rotationSetAngleType_", 754918211, "Black.Camera.SeamlessInGameSetAngleType", 1416, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnYawData_.turnInterpTimeYaw_", 4177114627, "float", 1420, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnYawData_.turnVelocityYaw_", 354868471, "float", 1424, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnYawData_.turnYaw_", 357154040, "float", 1428, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnYawData_.isAllowUserControlTurn_", 1137210184, "bool", 1432, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnYawData_.stealingPlayerDirectionInterpType_", 716479683, "Black.Camera.StealingPlayerDirectionInterpType", 1436, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnYawData_.stealingPlayerDirectionInterpVelocity_", 1595820198, "float", 1440, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnTiltData_", 3109648849, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTilt", 1448, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnTiltData_.isUse_", 637759561, "bool", 1456, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnTiltData_.rotationUseValueTypeTilt_", 4037866669, "Black.Camera.RotationUseValueType", 1460, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnTiltData_.isUseDefaultValueWhenBattleHybridAndOverride_", 1053007620, "bool", 1464, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnTiltData_.turnInterpType_", 2002712909, "Black.Camera.RotationInterpType", 1468, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnTiltData_.turnTimeInterpMode_", 15177683, "Black.Camera.BlendModeType", 1472, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnTiltData_.isUseAdjustAngle_", 1695015607, "bool", 1480, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnTiltData_.isUpdateTurnEveryFrame_", 2855836280, "bool", 1481, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnTiltData_.rotationSetAngleType_", 3857080373, "Black.Camera.SeamlessInGameSetAngleType", 1484, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnTiltData_.turnInterpTimeTilt_", 1641341903, "float", 1488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnTiltData_.turnVelocityTilt_", 3509421511, "float", 1492, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnTiltData_.turnTilt_", 1082361586, "float", 1496, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnTiltData_.isAllowUserControlTurn_", 1557315990, "bool", 1500, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnTiltData_.stealingPlayerDirectionInterpType_", 1252566693, "Black.Camera.StealingPlayerDirectionInterpType", 1504, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnTiltData_.stealingPlayerDirectionInterpVelocity_", 247155860, "float", 1508, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnRollData_", 2902877929, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRoll", 1512, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnRollData_.isUse_", 299158401, "bool", 1520, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnRollData_.rotationUseValueTypeRoll_", 1920948317, "Black.Camera.RotationUseValueType", 1524, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnRollData_.turnInterpType_", 1547673669, "Black.Camera.RotationInterpType", 1528, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnRollData_.turnTimeInterpMode_", 149244315, "Black.Camera.BlendModeType", 1532, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnRollData_.isUpdateTurnEveryFrame_", 1587425520, "bool", 1540, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnRollData_.rotationSetAngleType_", 1248741309, "Black.Camera.SeamlessInGameSetAngleType", 1544, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnRollData_.turnInterpTimeRoll_", 885126815, "float", 1548, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnRollData_.turnVelocityRoll_", 801060807, "float", 1552, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnRollData_.turnRoll_", 3161667006, "float", 1556, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.turnRollData_.isUseOldRollDirection_", 3239502032, "bool", 1560, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_", 245730993, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneral", 2032, 200, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.filterLevel_", 835084544, "Black.Camera.CameraFilterLevel", 2040, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessGroupId_", 3468726385, "SQEX.Ebony.Std.Fixid", 2044, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessId_", 336202276, "Ebony.Base.String", 2048, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.stopFilterType_", 2324458904, "Black.Camera.StopCameraFilterType", 2064, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.isEnableSwitchOtherCamera_", 3815316348, "bool", 2068, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.isEnableForceStopOtherCamera_", 3292223163, "bool", 2069, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.isEventSeamless_", 1294933737, "bool", 2070, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpMode_", 1577757520, "Black.Camera.SeamlessInterpMode", 2072, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpCloneReleaseMode_", 3859257442, "Black.Camera.SeamlessInterpCloneReleaseMode", 2076, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpCloneAutoReleaseTime_", 476320263, "float", 2080, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessCloneData_", 4020016676, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraSeamlessClone", 2088, 40, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessCloneData_.backToSeamlessCloneReleasePreset_", 2079985499, "Black.Camera.SeamlessCloneReleasePreset", 2096, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessCloneData_.backToNormalCoordInterpType_", 476800303, "Black.Camera.CoordInterpType", 2100, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessCloneData_.backToNormalInterpTime_", 273675009, "float", 2104, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessCloneData_.backToNormalCameraTime1_", 1822813029, "float", 2108, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessCloneData_.backToNormalCameraTime2_", 1823357482, "float", 2112, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessCloneData_.backToNormalCameraAccel_", 3455680997, "float", 2116, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessCloneData_.backToNormalInterpBlendMode_", 1766193756, "SQEX.Ebony.Framework.TimeControl.InterpMode", 2120, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpCloneControlTurn_", 2298847458, "Black.Camera.Struct.CameraControlTurn", 2136, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpCloneControlTurn_.mode", 808403879, "Black.Camera.Struct.CameraControlTurnMode", 2144, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpCloneControlTurn_.isUseAutoAdjustMode_", 3103079745, "bool", 2148, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpCloneControlTurn_.isUseAutoAdjustAngleMode_", 1717550410, "bool", 2149, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpCloneControlTurn_.isUseDefaultBrakeParam_", 1694049485, "bool", 2150, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpCloneControlTurn_.controlTurnVelocity_", 615230990, "float", 2152, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpCloneControlTurn_.backToDefaultTurnVelocity_", 3875215904, "float", 2156, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpCloneControlTurn_.yawMin_", 3960704338, "float", 2160, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpCloneControlTurn_.yawMax_", 1166168536, "float", 2164, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpCloneControlTurn_.tiltMin_", 1075410126, "float", 2168, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpCloneControlTurn_.tiltMax_", 1727045196, "float", 2172, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpCloneControlTurn_.brakeAngleYaw_", 2425646074, "float", 2176, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpCloneControlTurn_.brakePowerYaw_", 2993144372, "float", 2180, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpCloneControlTurn_.brakeAngleTilt_", 356830598, "float", 2184, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpCloneControlTurn_.brakePowerTilt_", 1044623744, "float", 2188, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.isUseDefaultAngleLimitTiltAtEventSeamless_", 3295197369, "bool", 2192, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpAngleLimitTiltMin_", 1812764196, "float", 2196, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.seamlessInterpAngleLimitTiltMax_", 360412214, "float", 2200, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.isSeamlessInterpCheckCollision_", 1842489273, "bool", 2204, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.backToNormalCameraTime1_", 1783614830, "float", 2208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.backToNormalCameraTime2_", 1783173545, "float", 2212, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.isBackToDefaultYaw_", 3823496916, "bool", 2216, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.backToDefaultYawInterpSpeed_", 2544882313, "float", 2220, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.isBackToDefaultTilt_", 235871008, "bool", 2224, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.generalData_.backToDefaultTiltInterpSpeed_", 1625532829, "float", 2228, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_", 4250057584, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFov", 2232, 128, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.isUse_", 1310368162, "bool", 2240, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.fovCurveDegree_", 367311993, "float", 2244, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.fovUseValueType_", 243208702, "Black.Camera.FovUseValueType", 2248, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.interpType_", 2078444773, "Black.Camera.RotationInterpType", 2252, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.timeInterpMode_", 1917654395, "Black.Camera.BlendModeType", 2256, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.setFovType_", 1425222342, "Black.Camera.SeamlessInGameSetFovType", 2260, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.interpTime_", 3080262626, "float", 2264, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.interpVelocity_", 1889459668, "float", 2268, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.autoCompositionOverrideFov_", 828024317, "float", 2272, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.isUpdateEveryFrame_", 568587276, "bool", 2276, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.isKeepFovFromLastSeamlessCamera_", 3160399915, "bool", 2277, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.isIgnoreIncrementFov_", 276801105, "bool", 2278, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.useCalculateFov_", 1970904683, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovNew.CalculateFOVType", 2280, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.maxTargetRaidus_", 2664754694, "float", 2284, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.minTargetRaidus_", 1498321224, "float", 2288, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.boundingSizeRate_", 1888561462, "float", 2292, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.startData_", 1649385431, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovStart", 2304, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.startData_.isChangeStartFov_", 9927005, "bool", 2312, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.startData_.fovStartInterpMode_", 2844725900, "Black.Camera.BlendModeType", 2316, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.startData_.fovStartInterpTime_", 2660968122, "float", 2320, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.startData_.fovStartFInterpToSpeed_", 1991353815, "float", 2324, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.startData_.fovStartDegree_", 2030960671, "float", 2328, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.endData_", 893147952, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovEnd", 2336, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.endData_.isChangeEndFov_", 2325289403, "bool", 2344, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.endData_.fovEndInterpMode_", 1562276500, "Black.Camera.BlendModeType", 2348, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.endData_.fovEndInterpTime_", 1821254626, "float", 2352, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterTrackItem_.fovData_.endData_.fovEndFInterpToSpeed_", 1937564079, "float", 2356, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("actorPin_", 3381458010, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 504, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("eyeTargetPin_", 4271124535, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 592, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnYawPin_", 1143598217, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 680, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnTiltPin_", 3019476029, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 768, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("masterTrackItem_", 1305972098, "Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItem", 864, 1504, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNeedTurnYaw_", 3908748254, "bool", 2368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNeedTurnTilt_", 3547629154, "bool", 2369, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionTimeLineCameraInGameTrack();
        }
		
    }
}