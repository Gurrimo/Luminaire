using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable.Minigame.Fishing
{
    public partial class SequenceVariableFishingSettings : SQEX.Ebony.Framework.Sequence.SequenceActivatableNode
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin settings_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin debug_place_overwrite_;
		public uint placeId_;
		public uint debugPlaceId_;
		public bool bUseFishHabitatExtraSetting_;
		public bool bExtraSetting_;
		public float startFadeTime_;
		public float endFadeTime_;
		public float castPartCameraHeight_;
		public float castPartCameraDistance_;
		public float castPartCameraLeftRight_;
		public float castPartLookAtHeight_;
		public float castPartLookAtLeftRight_;
		public float castPartMoveRate_;
		public float castDirRangeInDegree_;
		public float reelPartCameraHeight_;
		public float reelPartCameraDistance_;
		public float reelPartCameraDistanceRateWhenInBiteArea_;
		public float reelPartCameraMoveRateWhenInBiteArea_;
		public float reelPartLookAtDistance_;
		public float reelPartMoveRate_;
		public float reelPartMinDistance_;
		public bool lureUseParamTable_;
		public float lureRotationCenterRate_;
		public float lureHeightFromWater_;
		public float lureMoveSpeedRate_;
		public float lureMoveResistRate_;
		public float lureRotSpeedRate_;
		public float lureRotResistRate_;
		public float lureRotMax_;
		public float lureStickSpeedRate_;
		public float lureFreeMoveTimeSpan_;
		public float lureFreeMoveTimeSpanFor2OrMore_;
		public float lureFreeMoveSpeedRate_;
		public float lureFreeMoveRotationSpeedRate_;
		public float lureNeutralHeadRot_;
		public float lureHeadRotRange_;
		public float sinkRate_;
		public float sinkTimeRate_;
		public float sinkMaxValue_;
		public float lureHeadMoveRate_;
		public float lureBuoyancyRate_;
		public float battlePartCameraHeight_;
		public float battlePartCameraDistance_;
		public float battlePartCameraLeftRightOffset_;
		public float battlePartMoveRate_;
		public float battleFishMoveInDegree_;
		public float battleFishMoveMinRadius_;
		public float battleAddFovWhenReeling_;
		public float battleAddFovInterpParamWhenReeling_;
		public int battleAddFovBlendTypeWhenReeling_;
		public float battleJumpActionCameraSmoothRate_;
		public UnityEngine.Vector4 battleJumpActionCameraLookAtOffset_;
		public UnityEngine.Vector4 battleJumpActionCameraEyePosOffset_;
		public float fishGetMoveTime_;
		public float fishGetDistanceToStartRaise_;
		public float fishGetTimeToStartRaiseUp_;
		public float fishGetTimeToStartResultUI_;
		public float fishGetRaiseUpCameraLookAtHeight_;
		public float fishGetRaiseUpCameraLookAtDistance_;
		public UnityEngine.Vector4 fishGetRaiseUpCameraPosOffset_;
		public float fishGetRaiseUpCameraRotationSpeed_;
		public float fishGetTimeToStartPanAfterStartRaiseUp_;
		public float fishGettTimePan_;
		public float fishGetRaiseUpTargetLookAtHeightOffsetAfterPan_;
		public float fishGetRaiseUpTargetEyeHeightOffsetAfterPan_;
		public float fishGetFreeFallGravity_;
		public float fishGetFreeFallInitSpeed_;
		public float fishGetActorScale_;
		public UnityEngine.Vector4 fishGetAttachOffset_;
		public UnityEngine.Vector4 fishGetAttachRotation_;
		public float fishGetPerformanceSmallTimeLength_;
		public float fishGetPerformanceNormalTimeLength_;
		public float fishGetPerformanceBigTimeLength_;
		public float fishGetPerformanceSuperbigTimeLength_;
		public float fishGetPerformanceBigTunaTimeLength_;
		public float fishGetPerformanceBigTunaExTimeLength_;
		public float tacklePartCameraHeight_;
		public float tacklePartCameraDistance_;
		public float tacklePartCameraLeftRight_;
		public float tacklePartLookAtHeight_;
		public float tacklePartLookAtLeftRight_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableFishingSettings();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.Minigame.Fishing.SequenceVariableFishingSettings", 0, Black.Sequence.Variable.Minigame.Fishing.SequenceVariableFishingSettings.ObjectType, Construct, properties, 0, 752);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.Minigame.Fishing.SequenceVariableFishingSettings", base.GetFieldProperties(), -1239572252, 15521117);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("settings_.pinName_", 931683236, "Base.String", 176, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("settings_.name_", 644717055, "Base.String", 192, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("settings_.connections_", 1193895471, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 208, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("settings_.pinValueType_", 683683906, "Base.String", 240, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("debug_place_overwrite_.pinName_", 668887222, "Base.String", 264, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("debug_place_overwrite_.name_", 3054342017, "Base.String", 280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("debug_place_overwrite_.connections_", 4222307553, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 296, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("debug_place_overwrite_.delayType_", 796832379, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 328, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("debug_place_overwrite_.delayTime_", 2224284464, "float", 332, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("debug_place_overwrite_.delayMaxTime_", 2397383610, "float", 336, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("settings_", 422849013, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 168, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("debug_place_overwrite_", 93035731, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 256, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("placeId_", 3839569802, "SQEX.Ebony.Std.Fixid", 352, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("debugPlaceId_", 3615376283, "SQEX.Ebony.Std.Fixid", 356, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("bUseFishHabitatExtraSetting_", 3343214748, "bool", 360, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bExtraSetting_", 3884811280, "bool", 361, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("startFadeTime_", 3091817509, "float", 364, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("endFadeTime_", 792419382, "float", 368, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("castPartCameraHeight_", 3572470660, "float", 380, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("castPartCameraDistance_", 1546497620, "float", 384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("castPartCameraLeftRight_", 3842399802, "float", 388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("castPartLookAtHeight_", 2315972227, "float", 392, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("castPartLookAtLeftRight_", 643640099, "float", 396, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("castPartMoveRate_", 3466911929, "float", 400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("castDirRangeInDegree_", 1702273466, "float", 404, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("reelPartCameraHeight_", 4029309677, "float", 408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("reelPartCameraDistance_", 3148717093, "float", 412, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("reelPartCameraDistanceRateWhenInBiteArea_", 104386335, "float", 416, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("reelPartCameraMoveRateWhenInBiteArea_", 1356244653, "float", 420, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("reelPartLookAtDistance_", 1601645366, "float", 424, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("reelPartMoveRate_", 2412681056, "float", 428, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("reelPartMinDistance_", 3432762872, "float", 432, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lureUseParamTable_", 4006659962, "bool", 436, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("lureRotationCenterRate_", 598719311, "float", 440, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lureHeightFromWater_", 2915101128, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lureMoveSpeedRate_", 516381860, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lureMoveResistRate_", 3733045403, "float", 452, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lureRotSpeedRate_", 1873533382, "float", 456, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lureRotResistRate_", 2733155737, "float", 460, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lureRotMax_", 3275174879, "float", 464, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lureStickSpeedRate_", 3506041651, "float", 468, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lureFreeMoveTimeSpan_", 401140842, "float", 472, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lureFreeMoveTimeSpanFor2OrMore_", 1331492351, "float", 476, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lureFreeMoveSpeedRate_", 3699648462, "float", 480, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lureFreeMoveRotationSpeedRate_", 1079165512, "float", 484, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lureNeutralHeadRot_", 972529478, "float", 488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lureHeadRotRange_", 477305060, "float", 492, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sinkRate_", 4160401069, "float", 496, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sinkTimeRate_", 4276249906, "float", 500, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sinkMaxValue_", 3312187542, "float", 504, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lureHeadMoveRate_", 2677251283, "float", 508, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lureBuoyancyRate_", 1167571656, "float", 512, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("battlePartCameraHeight_", 3944923939, "float", 516, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("battlePartCameraDistance_", 3817779115, "float", 520, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("battlePartCameraLeftRightOffset_", 1019908978, "float", 524, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("battlePartMoveRate_", 3123760022, "float", 528, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleFishMoveInDegree_", 1929076704, "float", 532, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleFishMoveMinRadius_", 874754059, "float", 536, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleAddFovWhenReeling_", 979656916, "float", 540, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleAddFovInterpParamWhenReeling_", 1313847269, "float", 544, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleAddFovBlendTypeWhenReeling_", 2931343165, "Black.Camera.BlendModeType", 548, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleJumpActionCameraSmoothRate_", 975452363, "float", 552, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleJumpActionCameraLookAtOffset_", 1730881872, "LM_NS_MATH.VectorA", 560, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleJumpActionCameraEyePosOffset_", 1795773173, "LM_NS_MATH.VectorA", 576, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetMoveTime_", 526737414, "float", 592, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetDistanceToStartRaise_", 869627988, "float", 596, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetTimeToStartRaiseUp_", 1272973817, "float", 600, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetTimeToStartResultUI_", 1777979341, "float", 604, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetRaiseUpCameraLookAtHeight_", 4255535377, "float", 608, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetRaiseUpCameraLookAtDistance_", 4155760465, "float", 612, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetRaiseUpCameraPosOffset_", 3729047651, "LM_NS_MATH.VectorA", 624, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetRaiseUpCameraRotationSpeed_", 3203022679, "float", 640, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetTimeToStartPanAfterStartRaiseUp_", 1184190206, "float", 644, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGettTimePan_", 3151177834, "float", 648, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetRaiseUpTargetLookAtHeightOffsetAfterPan_", 357532393, "float", 652, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetRaiseUpTargetEyeHeightOffsetAfterPan_", 3867774202, "float", 656, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetFreeFallGravity_", 206711949, "float", 660, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetFreeFallInitSpeed_", 3276941340, "float", 664, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetActorScale_", 1503366565, "float", 668, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetAttachOffset_", 3061327112, "LM_NS_MATH.VectorA", 672, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetAttachRotation_", 338091295, "LM_NS_MATH.VectorA", 688, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetPerformanceSmallTimeLength_", 1593026958, "float", 704, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetPerformanceNormalTimeLength_", 2534537508, "float", 708, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetPerformanceBigTimeLength_", 982129057, "float", 712, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetPerformanceSuperbigTimeLength_", 1953857444, "float", 716, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetPerformanceBigTunaTimeLength_", 1748769603, "float", 720, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fishGetPerformanceBigTunaExTimeLength_", 2169337192, "float", 724, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tacklePartCameraHeight_", 1814018715, "float", 728, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tacklePartCameraDistance_", 3515850579, "float", 732, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tacklePartCameraLeftRight_", 2367950411, "float", 736, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tacklePartLookAtHeight_", 3382090464, "float", 740, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tacklePartLookAtLeftRight_", 1636449830, "float", 744, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceVariableFishingSettings();
        }
		
    }
}