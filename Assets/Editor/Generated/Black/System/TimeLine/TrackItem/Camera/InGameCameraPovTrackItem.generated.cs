using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class InGameCameraPovTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string povId_= string.Empty;
		public string povMatrixId_= string.Empty;
		public string povOffsetId_= string.Empty;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPov povData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraPovTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.InGameCameraPovTrackItem", 0, Black.System.TimeLine.TrackItem.Camera.InGameCameraPovTrackItem.ObjectType, null, properties, 0, 272);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.InGameCameraPovTrackItem", base.GetFieldProperties(), 1126762313, 398545447);
            
			fieldProperties.AddIndirectlyProperty(new Property("name_", 182823483, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startTime_", 140908163, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("duration_", 1282328598, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.lockOnType_", 1364651742, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnType", 152, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.actorBaseType_", 1659192518, "Black.Camera.SeamlessInGameActorBaseType", 156, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.lockOnActorOffsetType_", 345433254, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnActorOffsetType", 160, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.boneId_", 2226270441, "SQEX.Ebony.Std.Fixid", 164, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionBaseType_", 3587113400, "Black.Camera.AutoCompositionBaseType", 168, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionUpdateType_", 3636045284, "Black.Camera.AutoCompositionUpdateType", 172, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.valueSettingType_", 3899692185, "Black.Camera.ValueSettingType", 180, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.incEyeDistance_", 3329328574, "float", 184, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isDisableBattleAddDistance_", 3133886870, "bool", 188, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.seamlessInGameFlameInAddDistanceCalcType_", 3621477053, "Black.Camera.SeamlessInGameFlameInAddDistanceCalcType", 192, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isDisableAroundStatusAddDistance_", 2636424483, "bool", 196, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.addDistanceRate_", 1951347064, "float", 200, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isDisableAngleDiffBetweenCam2PCAddDistance_", 3966181618, "bool", 204, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.overrideEyeDistance_", 2086105640, "float", 208, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.minimumGuaranteeEyeDistance_", 4222704638, "float", 212, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.povVelocity_", 4121629536, "float", 216, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.matrixType_", 2274861571, "Black.Camera.MatrixType", 220, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.povOffset_", 1648594688, "Luminous.Math.VectorA", 224, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.offsetXValueType_", 149451218, "Black.Camera.OffsetXValueType", 240, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionShotSize_", 1942688948, "int", 244, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionFovLevel_", 4171386142, "int", 248, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionPovBoneId_", 4019793381, "SQEX.Ebony.Std.Fixid", 252, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionFlameHeightRate_", 2925817925, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionFlameHeightYawRate_", 7214720, "float", 260, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isUpdateXEveryFrame_", 910403479, "bool", 264, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isUpdateYEveryFrame__", 528956111, "bool", 265, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isUpdateZEveryFrame_", 3601915185, "bool", 266, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("povId_", 555659408, "Ebony.Base.String", 88, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("povMatrixId_", 948652967, "Ebony.Base.String", 104, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("povOffsetId_", 3312465453, "Ebony.Base.String", 120, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("povData_", 1033385879, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPov", 144, 128, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}