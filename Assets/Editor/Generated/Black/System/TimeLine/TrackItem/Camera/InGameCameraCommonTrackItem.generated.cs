using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class InGameCameraCommonTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string relativeTargetId_= string.Empty;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCommon commonData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraCommonTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.InGameCameraCommonTrackItem", 0, Black.System.TimeLine.TrackItem.Camera.InGameCameraCommonTrackItem.ObjectType, Construct, properties, 0, 184);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.InGameCameraCommonTrackItem", base.GetFieldProperties(), -491289243, -1372788521);
            
			fieldProperties.AddIndirectlyProperty(new Property("name_", 182823483, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startTime_", 140908163, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("duration_", 1282328598, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.mode", 1852175906, "Black.Camera.InGameSeamlessTargetMode", 112, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.startEndBlendMode_", 3000916853, "Black.Camera.SeamlessInGameSeparateStartEndBlendMode", 116, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.isCheckCollision_", 2397548114, "bool", 120, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_", 1305617768, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCollision", 128, 40, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.checkCollisionType_", 88331415, "Black.Camera.CheckCollisionType", 136, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.isNeedCheckFocusFromPC_", 2725639260, "bool", 140, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.isNeedCheckAdjustPog_", 2687050262, "bool", 141, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.isNeedCheckGroundHeight_", 998449139, "bool", 142, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.groundCheckMarginHeight_", 1554342835, "float", 144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.groundCheckMinimumHeight_", 4026439387, "float", 148, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.isEnableCharaFadeOutWhenCollidedByCamera_", 2970294967, "bool", 152, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.isEnablePCFadeWhenCollidedByCamera_", 3352589291, "bool", 153, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.isUsePCFaseFadeWhenCollidedByCamera_", 109148000, "bool", 154, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.isUseAdjustFadeMinPowerWhenCollidedByCamera_", 2184529942, "bool", 155, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.charaFadeByCameraSphereRadius_", 2541676283, "float", 156, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.isEndBlendCheckCollision_", 302127735, "bool", 160, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.endBlendCheckCollisionType_", 3824355899, "Black.Camera.CheckCollisionType", 164, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.isEnableCancelWhenPCFrameOut_", 2497537047, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.isEnableCancelWhenTerribleCollieded_", 3186678865, "bool", 169, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.isCutChangeOrder", 3983111193, "bool", 170, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.isNeedClearCameraContainerBlendDataWhenCutChange_", 3956054690, "bool", 171, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.isUseBattleAssistRotationWhenNotControlingYaw_", 3599718539, "bool", 172, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.isIgnoreCameraShake_", 3591993503, "bool", 173, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.autoCompositionShotType_", 1776257369, "Black.Camera.AutoCompositionShotType", 176, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.isNeedCaptureForOtherRelativeTarget_", 732736696, "bool", 180, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("relativeTargetId_", 2055114374, "Ebony.Base.String", 88, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("commonData_", 2069969881, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCommon", 104, 80, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new InGameCameraCommonTrackItem();
        }
		
    }
}