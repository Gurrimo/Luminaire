using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraPov : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int lockOnType_;
		public int actorBaseType_;
		public int lockOnActorOffsetType_;
		public uint boneId_;
		public int autoCompositionBaseType_;
		public int autoCompositionUpdateType_;
		public int valueSettingType_;
		public float incEyeDistance_;
		public bool isDisableBattleAddDistance_;
		public int seamlessInGameFlameInAddDistanceCalcType_;
		public bool isDisableAroundStatusAddDistance_;
		public float addDistanceRate_;
		public bool isDisableAngleDiffBetweenCam2PCAddDistance_;
		public float overrideEyeDistance_;
		public float minimumGuaranteeEyeDistance_;
		public float povVelocity_;
		public int matrixType_;
		public UnityEngine.Vector4 povOffset_;
		public int offsetXValueType_;
		public int autoCompositionShotSize_;
		public int autoCompositionFovLevel_;
		public uint autoCompositionPovBoneId_;
		public float autoCompositionFlameHeightRate_;
		public float autoCompositionFlameHeightYawRate_;
		public bool isUpdateXEveryFrame_;
		public bool isUpdateYEveryFrame__;
		public bool isUpdateZEveryFrame_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraPov();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPov", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPov.ObjectType, null, properties, 0, 128);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPov", base.GetFieldProperties(), -2009302515, 1513457985);
            
			fieldProperties.AddProperty(new Property("lockOnType_", 1417918068, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnType", 8, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorBaseType_", 3300297616, "Black.Camera.SeamlessInGameActorBaseType", 12, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("lockOnActorOffsetType_", 142195356, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnActorOffsetType", 16, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("boneId_", 2693567367, "SQEX.Ebony.Std.Fixid", 20, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoCompositionBaseType_", 1030842770, "Black.Camera.AutoCompositionBaseType", 24, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoCompositionUpdateType_", 2633428982, "Black.Camera.AutoCompositionUpdateType", 28, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueSettingType_", 1600821419, "Black.Camera.ValueSettingType", 36, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("incEyeDistance_", 2289517828, "float", 40, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("isDisableBattleAddDistance_", 3748863652, "bool", 44, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessInGameFlameInAddDistanceCalcType_", 3231531071, "Black.Camera.SeamlessInGameFlameInAddDistanceCalcType", 48, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isDisableAroundStatusAddDistance_", 3055160201, "bool", 52, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("addDistanceRate_", 1031721390, "float", 56, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("isDisableAngleDiffBetweenCam2PCAddDistance_", 2525946524, "bool", 60, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("overrideEyeDistance_", 2281183666, "float", 64, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("minimumGuaranteeEyeDistance_", 3389100176, "float", 68, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("povVelocity_", 400555138, "float", 72, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("matrixType_", 2625693249, "Black.Camera.MatrixType", 76, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("povOffset_", 731032398, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddProperty(new Property("offsetXValueType_", 1095131760, "Black.Camera.OffsetXValueType", 96, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoCompositionShotSize_", 2656919110, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoCompositionFovLevel_", 1895314232, "int", 104, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoCompositionPovBoneId_", 3789476895, "SQEX.Ebony.Std.Fixid", 108, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoCompositionFlameHeightRate_", 686417095, "float", 112, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoCompositionFlameHeightYawRate_", 3516317658, "float", 116, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUpdateXEveryFrame_", 3087219209, "bool", 120, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUpdateYEveryFrame__", 4146338457, "bool", 121, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUpdateZEveryFrame_", 2447887599, "bool", 122, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}