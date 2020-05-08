using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera
{
    public partial class SequenceActionSeamlessInGameCamera : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin endPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnDirectionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cameraPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnTiltPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnYawPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin povOffsetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin eyeTargetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pogOffsetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItem seamlessParameter_;
		public bool isNeedTurnYaw_;
		public bool isNeedTurnTilt_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSeamlessInGameCamera();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCamera", 0, Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCamera.ObjectType, Construct, properties, 0, 2704);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCamera", base.GetFieldProperties(), -1508499149, 1206890769);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startPin_.pinName_", 3393751070, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startPin_.name_", 2709444057, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startPin_.connections_", 3972754729, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("startPin_.delayType_", 2098578323, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 248, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startPin_.delayTime_", 2204508536, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startPin_.delayMaxTime_", 3635708722, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endPin_.pinName_", 1113190301, "Base.String", 280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endPin_.name_", 853626984, "Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endPin_.connections_", 2839725734, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 312, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("endPin_.delayType_", 1311405092, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 344, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endPin_.delayTime_", 1168370247, "float", 348, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endPin_.delayMaxTime_", 2168073055, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.pinName_", 1767361694, "Base.String", 376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.name_", 2948420441, "Base.String", 392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.connections_", 78281129, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 408, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.delayType_", 2315115539, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 440, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.delayTime_", 2421045752, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.delayMaxTime_", 3973394610, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnDirectionPin_.pinName_", 1537193374, "Base.String", 472, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnDirectionPin_.name_", 226127449, "Base.String", 488, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnDirectionPin_.connections_", 3653759657, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 504, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnDirectionPin_.pinValueType_", 796566288, "Base.String", 536, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cameraPin_.pinName_", 1626967689, "Base.String", 560, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cameraPin_.name_", 1164034196, "Base.String", 576, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cameraPin_.connections_", 3959604714, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 592, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("cameraPin_.pinValueType_", 1643032009, "Base.String", 624, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltPin_.pinName_", 1997149052, "Base.String", 648, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltPin_.name_", 35171879, "Base.String", 664, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltPin_.connections_", 4087771367, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 680, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltPin_.pinValueType_", 4245306154, "Base.String", 712, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawPin_.pinName_", 1831740656, "Base.String", 736, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawPin_.name_", 669719579, "Base.String", 752, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawPin_.connections_", 188086195, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 768, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawPin_.pinValueType_", 2809084494, "Base.String", 800, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povOffsetPin_.pinName_", 116797704, "Base.String", 824, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povOffsetPin_.name_", 3415074531, "Base.String", 840, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povOffsetPin_.connections_", 1925427435, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 856, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("povOffsetPin_.pinValueType_", 201305750, "Base.String", 888, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("eyeTargetPin_.pinName_", 2468407506, "Base.String", 912, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("eyeTargetPin_.name_", 173093453, "Base.String", 928, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("eyeTargetPin_.connections_", 2483192245, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 944, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("eyeTargetPin_.pinValueType_", 1791315380, "Base.String", 976, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogOffsetPin_.pinName_", 1998243325, "Base.String", 1000, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogOffsetPin_.name_", 1704715016, "Base.String", 1016, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogOffsetPin_.connections_", 3871772998, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1032, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pogOffsetPin_.pinValueType_", 361564237, "Base.String", 1064, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actorPin_.pinName_", 61679437, "Base.String", 1088, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actorPin_.name_", 700809432, "Base.String", 1104, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actorPin_.connections_", 2962364278, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1120, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("actorPin_.pinValueType_", 2807496477, "Base.String", 1152, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.name_", 143635512, "Ebony.Base.String", 1176, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.startTime_", 1389430562, "float", 1192, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.duration_", 3335034801, "float", 1196, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_", 1701286086, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCommon", 1256, 80, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.mode", 2872032779, "Black.Camera.InGameSeamlessTargetMode", 1264, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.startEndBlendMode_", 2296457320, "Black.Camera.SeamlessInGameSeparateStartEndBlendMode", 1268, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.isCheckCollision_", 942809165, "bool", 1272, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_", 2594561413, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCollision", 1280, 40, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.checkCollisionType_", 2792889382, "Black.Camera.CheckCollisionType", 1288, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.isNeedCheckFocusFromPC_", 2798841865, "bool", 1292, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.isNeedCheckAdjustPog_", 3388467487, "bool", 1293, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.isNeedCheckGroundHeight_", 4290292920, "bool", 1294, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.groundCheckMarginHeight_", 146133544, "float", 1296, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.groundCheckMinimumHeight_", 1599813878, "float", 1300, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.isEnableCharaFadeOutWhenCollidedByCamera_", 908932602, "bool", 1304, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.isEnablePCFadeWhenCollidedByCamera_", 1852659678, "bool", 1305, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.isUsePCFaseFadeWhenCollidedByCamera_", 1776344383, "bool", 1306, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.isUseAdjustFadeMinPowerWhenCollidedByCamera_", 3408513961, "bool", 1307, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.charaFadeByCameraSphereRadius_", 1243305420, "float", 1308, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.isEndBlendCheckCollision_", 3297988018, "bool", 1312, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.endBlendCheckCollisionType_", 3711186650, "Black.Camera.CheckCollisionType", 1316, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.isEnableCancelWhenPCFrameOut_", 906349900, "bool", 1320, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.isEnableCancelWhenTerribleCollieded_", 3354040688, "bool", 1321, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.isCutChangeOrder", 3420593584, "bool", 1322, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.isNeedClearCameraContainerBlendDataWhenCutChange_", 2201261977, "bool", 1323, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.isUseBattleAssistRotationWhenNotControlingYaw_", 3951464314, "bool", 1324, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.isIgnoreCameraShake_", 2769628122, "bool", 1325, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.autoCompositionShotType_", 1997096704, "Black.Camera.AutoCompositionShotType", 1328, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.isNeedCaptureForOtherRelativeTarget_", 926124789, "bool", 1332, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_", 3657424919, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPog", 1344, 112, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.lockOnType_", 1088827230, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnType", 1352, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.actorBaseType_", 2935401030, "Black.Camera.SeamlessInGameActorBaseType", 1356, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.lockOnActorOffsetType_", 1291811366, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnActorOffsetType", 1360, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.boneId_", 2115397993, "SQEX.Ebony.Std.Fixid", 1364, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.coordInterpType_", 2914534915, "Black.Camera.CoordInterpType", 1368, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.pogInterpTime_", 3456851449, "float", 1372, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.pogTimeInterpMode_", 421817464, "SQEX.Ebony.Framework.TimeControl.InterpMode", 1376, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.pogVelocity_", 381917901, "float", 1380, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.isUpdateYDirectly_", 3372801004, "bool", 1384, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.pogDirectionYVelocity_", 1323425817, "float", 1388, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.matrixType_", 1999037059, "Black.Camera.MatrixType", 1392, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.offsetType_", 4123060413, "Black.Camera.SeamlessInGameOffsetType", 1396, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.pogOffset_", 3972890265, "Luminous.Math.VectorA", 1408, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.isUseAddOffsetXByProjectionBetweenPCandTarget_", 2740515898, "bool", 1440, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.addOffsetXSabunMultiplyRate_", 2052567523, "float", 1444, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.addOffsetXMaxLimit_", 2444665243, "float", 1448, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.isUpdateXEveryFrame_", 2946359575, "bool", 1452, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.isUpdateYEveryFrame__", 2827992911, "bool", 1453, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.isUpdateZEveryFrame_", 1342903985, "bool", 1454, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_", 1669805262, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPov", 1456, 128, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.lockOnType_", 1550986935, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnType", 1464, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.actorBaseType_", 631887473, "Black.Camera.SeamlessInGameActorBaseType", 1468, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.lockOnActorOffsetType_", 983732245, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnActorOffsetType", 1472, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.boneId_", 3234082500, "SQEX.Ebony.Std.Fixid", 1476, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.autoCompositionBaseType_", 2168013303, "Black.Camera.AutoCompositionBaseType", 1480, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.autoCompositionUpdateType_", 1182274819, "Black.Camera.AutoCompositionUpdateType", 1484, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.valueSettingType_", 4080724064, "Black.Camera.ValueSettingType", 1492, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.incEyeDistance_", 3766841731, "float", 1496, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.isDisableBattleAddDistance_", 2659469503, "bool", 1500, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.seamlessInGameFlameInAddDistanceCalcType_", 3629814140, "Black.Camera.SeamlessInGameFlameInAddDistanceCalcType", 1504, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.isDisableAroundStatusAddDistance_", 2210501986, "bool", 1508, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.addDistanceRate_", 447603299, "float", 1512, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.isDisableAngleDiffBetweenCam2PCAddDistance_", 2917056727, "bool", 1516, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.overrideEyeDistance_", 314524423, "float", 1520, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.minimumGuaranteeEyeDistance_", 1596542917, "float", 1524, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.povVelocity_", 882226539, "float", 1528, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.matrixType_", 2555728298, "Black.Camera.MatrixType", 1532, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.povOffset_", 1251250451, "Luminous.Math.VectorA", 1536, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.offsetXValueType_", 2128689091, "Black.Camera.OffsetXValueType", 1552, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.autoCompositionShotSize_", 1293013675, "int", 1556, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.autoCompositionFovLevel_", 2338476185, "int", 1560, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.autoCompositionPovBoneId_", 226836644, "SQEX.Ebony.Std.Fixid", 1564, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.autoCompositionFlameHeightRate_", 2734151044, "float", 1568, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.autoCompositionFlameHeightYawRate_", 3122897307, "float", 1572, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.isUpdateXEveryFrame_", 857267672, "bool", 1576, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.isUpdateYEveryFrame__", 684721486, "bool", 1577, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.isUpdateZEveryFrame_", 2410808734, "bool", 1578, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_", 3981981308, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurn", 1584, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.isOverrideLockOnLayer_", 2728637830, "bool", 1592, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.isUseLockOnTurn_", 3305961141, "bool", 1593, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.isUseLockOnTurnTilt_", 3104790976, "bool", 1594, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_", 16350813, "Black.Camera.Struct.CameraControlTurn", 1600, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.mode", 2241179558, "Black.Camera.Struct.CameraControlTurnMode", 1608, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.isUseAutoAdjustMode_", 4138983180, "bool", 1612, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.isUseAutoAdjustAngleMode_", 837862769, "bool", 1613, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.isUseDefaultBrakeParam_", 2887207762, "bool", 1614, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.controlTurnVelocity_", 1500626139, "float", 1616, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.backToDefaultTurnVelocity_", 4070158945, "float", 1620, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.yawMin_", 2461927037, "float", 1624, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.yawMax_", 736524351, "float", 1628, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.tiltMin_", 2288094683, "float", 1632, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.tiltMax_", 4014777297, "float", 1636, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.brakeAngleYaw_", 967367535, "float", 1640, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.brakePowerYaw_", 3548532525, "float", 1644, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.brakeAngleTilt_", 3604515237, "float", 1648, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.brakePowerTilt_", 2815647859, "float", 1652, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.angleLimit_", 3589486985, "Black.Camera.Struct.CameraAngleLimit", 1656, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.angleLimit_.tiltAngleLimitMode_", 4016915232, "Black.Camera.CameraAngleLimitMode", 1664, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.angleLimit_.tiltAngleLimitMin_", 3814280893, "float", 1668, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.angleLimit_.tiltAngleLimitMax_", 2088878207, "float", 1672, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_", 1254386451, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYaw", 1680, 72, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.isUse_", 209838527, "bool", 1688, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.rotationUseValueTypeYaw_", 2220802697, "Black.Camera.RotationUseValueType", 1692, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.isNotControllingYawWhenBattleHybridAndOverride_", 3163149798, "bool", 1696, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.bestAngleJudgeType_", 3473295228, "Black.Camera.BestAngleJudgeType", 1700, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.turnInterpType_", 3604791567, "Black.Camera.RotationInterpType", 1704, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.turnTimeInterpMode_", 2829814513, "Black.Camera.BlendModeType", 1708, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.rotationDirection_", 3171316867, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 1712, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.isCalcAlwaysBehindPC_", 1328657347, "bool", 1716, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.isUpdateTurnEveryFrame_", 468757358, "bool", 1717, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.rotationSetAngleType_", 621053723, "Black.Camera.SeamlessInGameSetAngleType", 1720, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.turnInterpTimeYaw_", 271293147, "float", 1724, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.turnVelocityYaw_", 580031791, "float", 1728, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.turnYaw_", 3451926960, "float", 1732, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.isAllowUserControlTurn_", 1395532672, "bool", 1736, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.stealingPlayerDirectionInterpType_", 1844493211, "Black.Camera.StealingPlayerDirectionInterpType", 1740, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.stealingPlayerDirectionInterpVelocity_", 3268184142, "float", 1744, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_", 1966882297, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTilt", 1752, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.isUse_", 1399101297, "bool", 1760, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.rotationUseValueTypeTilt_", 1188533621, "Black.Camera.RotationUseValueType", 1764, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.isUseDefaultValueWhenBattleHybridAndOverride_", 746469612, "bool", 1768, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.turnInterpType_", 783235733, "Black.Camera.RotationInterpType", 1772, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.turnTimeInterpMode_", 31494187, "Black.Camera.BlendModeType", 1776, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.isUseAdjustAngle_", 1437900447, "bool", 1784, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.isUpdateTurnEveryFrame_", 3106637632, "bool", 1785, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.rotationSetAngleType_", 2773092269, "Black.Camera.SeamlessInGameSetAngleType", 1788, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.turnInterpTimeTilt_", 2384118055, "float", 1792, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.turnVelocityTilt_", 2787646303, "float", 1796, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.turnTilt_", 152851434, "float", 1800, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.isAllowUserControlTurn_", 1914548910, "bool", 1804, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.stealingPlayerDirectionInterpType_", 3352276125, "Black.Camera.StealingPlayerDirectionInterpType", 1808, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.stealingPlayerDirectionInterpVelocity_", 2459623420, "float", 1812, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_", 3723209409, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRoll", 1816, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.isUse_", 489767833, "bool", 1824, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.rotationUseValueTypeRoll_", 3976896421, "Black.Camera.RotationUseValueType", 1828, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.turnInterpType_", 324610365, "Black.Camera.RotationInterpType", 1832, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.turnTimeInterpMode_", 1910173187, "Black.Camera.BlendModeType", 1836, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.isUpdateTurnEveryFrame_", 2516096168, "bool", 1844, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.rotationSetAngleType_", 3432797765, "Black.Camera.SeamlessInGameSetAngleType", 1848, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.turnInterpTimeRoll_", 456240183, "float", 1852, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.turnVelocityRoll_", 3415226015, "float", 1856, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.turnRoll_", 1877279190, "float", 1860, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.isUseOldRollDirection_", 3205543256, "bool", 1864, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_", 818908889, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneral", 2336, 200, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.filterLevel_", 1722513656, "Black.Camera.CameraFilterLevel", 2344, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessGroupId_", 1073132137, "SQEX.Ebony.Std.Fixid", 2348, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessId_", 2891551324, "Ebony.Base.String", 2352, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.stopFilterType_", 326070016, "Black.Camera.StopCameraFilterType", 2368, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.isEnableSwitchOtherCamera_", 1520171668, "bool", 2372, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.isEnableForceStopOtherCamera_", 2662356227, "bool", 2373, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.isEventSeamless_", 3019457697, "bool", 2374, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpMode_", 4129359928, "Black.Camera.SeamlessInterpMode", 2376, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneReleaseMode_", 2893761354, "Black.Camera.SeamlessInterpCloneReleaseMode", 2380, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneAutoReleaseTime_", 2195200287, "float", 2384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessCloneData_", 3189536812, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraSeamlessClone", 2392, 40, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessCloneData_.backToSeamlessCloneReleasePreset_", 3630837667, "Black.Camera.SeamlessCloneReleasePreset", 2400, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessCloneData_.backToNormalCoordInterpType_", 1047882295, "Black.Camera.CoordInterpType", 2404, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessCloneData_.backToNormalInterpTime_", 2201185129, "float", 2408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessCloneData_.backToNormalCameraTime1_", 1477303789, "float", 2412, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessCloneData_.backToNormalCameraTime2_", 403977458, "float", 2416, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessCloneData_.backToNormalCameraAccel_", 3718135837, "float", 2420, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessCloneData_.backToNormalInterpBlendMode_", 2131477556, "SQEX.Ebony.Framework.TimeControl.InterpMode", 2424, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_", 1499393066, "Black.Camera.Struct.CameraControlTurn", 2440, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.mode", 728575983, "Black.Camera.Struct.CameraControlTurnMode", 2448, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.isUseAutoAdjustMode_", 1673448969, "bool", 2452, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.isUseAutoAdjustAngleMode_", 2521392802, "bool", 2453, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.isUseDefaultBrakeParam_", 1229840245, "bool", 2454, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.controlTurnVelocity_", 4198293558, "float", 2456, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.backToDefaultTurnVelocity_", 3631379416, "float", 2460, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.yawMin_", 391830010, "float", 2464, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.yawMax_", 3228634064, "float", 2468, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.tiltMin_", 3701477238, "float", 2472, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.tiltMax_", 900335460, "float", 2476, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.brakeAngleYaw_", 3949891186, "float", 2480, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.brakePowerYaw_", 3145525404, "float", 2484, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.brakeAngleTilt_", 2134293310, "float", 2488, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.brakePowerTilt_", 3498452648, "float", 2492, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.isUseDefaultAngleLimitTiltAtEventSeamless_", 3329976865, "bool", 2496, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpAngleLimitTiltMin_", 3065974668, "float", 2500, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpAngleLimitTiltMax_", 2414339598, "float", 2504, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.isSeamlessInterpCheckCollision_", 241757729, "bool", 2508, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.backToNormalCameraTime1_", 1929986230, "float", 2512, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.backToNormalCameraTime2_", 1929544945, "float", 2516, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.isBackToDefaultYaw_", 2837998156, "bool", 2520, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.backToDefaultYawInterpSpeed_", 2935084385, "float", 2524, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.isBackToDefaultTilt_", 3572220920, "bool", 2528, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.backToDefaultTiltInterpSpeed_", 1970275285, "float", 2532, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_", 680421896, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFov", 2536, 128, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.isUse_", 1209139194, "bool", 2544, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.fovCurveDegree_", 119523105, "float", 2548, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.fovUseValueType_", 2005694614, "Black.Camera.FovUseValueType", 2552, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.interpType_", 1916367021, "Black.Camera.RotationInterpType", 2556, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.timeInterpMode_", 2799597811, "Black.Camera.BlendModeType", 2560, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.setFovType_", 694911358, "Black.Camera.SeamlessInGameSetFovType", 2564, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.interpTime_", 2003211962, "float", 2568, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.interpVelocity_", 236331980, "float", 2572, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.autoCompositionOverrideFov_", 3097965413, "float", 2576, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.isUpdateEveryFrame_", 2836963700, "bool", 2580, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.isKeepFovFromLastSeamlessCamera_", 4275015779, "bool", 2581, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.isIgnoreIncrementFov_", 1825602713, "bool", 2582, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.useCalculateFov_", 582049795, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovNew.CalculateFOVType", 2584, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.maxTargetRaidus_", 537924638, "float", 2588, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.minTargetRaidus_", 3675811952, "float", 2592, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.boundingSizeRate_", 3480567374, "float", 2596, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.startData_", 1128469279, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovStart", 2608, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.startData_.isChangeStartFov_", 530557061, "bool", 2616, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.startData_.fovStartInterpMode_", 486056452, "Black.Camera.BlendModeType", 2620, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.startData_.fovStartInterpTime_", 1568486898, "float", 2624, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.startData_.fovStartFInterpToSpeed_", 2732170175, "float", 2628, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.startData_.fovStartDegree_", 1412947255, "float", 2632, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.endData_", 1332260200, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovEnd", 2640, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.endData_.isChangeEndFov_", 392507971, "bool", 2648, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.endData_.fovEndInterpMode_", 2511162860, "Black.Camera.BlendModeType", 2652, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.endData_.fovEndInterpTime_", 1160616986, "float", 2656, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.endData_.fovEndFInterpToSpeed_", 241671223, "float", 2660, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("startPin_", 2664043275, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endPin_", 1225342026, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPin_", 2732252299, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnDirectionPin_", 1770360715, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 464, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cameraPin_", 1695617774, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 552, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnTiltPin_", 3019476029, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 640, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnYawPin_", 1143598217, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 728, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("povOffsetPin_", 847391761, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 816, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("eyeTargetPin_", 4271124535, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 904, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pogOffsetPin_", 317626922, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 992, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorPin_", 3381458010, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1080, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessParameter_", 2917807098, "Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItem", 1168, 1504, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNeedTurnYaw_", 3908748254, "bool", 2672, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNeedTurnTilt_", 3547629154, "bool", 2673, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionSeamlessInGameCamera();
        }
		
    }
}