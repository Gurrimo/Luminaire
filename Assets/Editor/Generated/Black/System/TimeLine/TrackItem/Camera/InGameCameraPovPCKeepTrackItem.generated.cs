using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class InGameCameraPovPCKeepTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string pogId_= string.Empty;
		public string pogMatrixId_= string.Empty;
		public string pogOffsetId_= string.Empty;
		public string pogSignId_= string.Empty;
		public string povDistanceId_= string.Empty;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPog pogData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPov povData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraPovPCKeepTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.InGameCameraPovPCKeepTrackItem", 0, Black.System.TimeLine.TrackItem.Camera.InGameCameraPovPCKeepTrackItem.ObjectType, Construct, properties, 0, 416);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.InGameCameraPovPCKeepTrackItem", base.GetFieldProperties(), 2667630, -1697406735);
            
			fieldProperties.AddIndirectlyProperty(new Property("name_", 182823483, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startTime_", 140908163, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("duration_", 1282328598, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.lockOnType_", 1826811447, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnType", 184, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.actorBaseType_", 3650646257, "Black.Camera.SeamlessInGameActorBaseType", 188, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.lockOnActorOffsetType_", 37354133, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnActorOffsetType", 192, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.boneId_", 3344954948, "SQEX.Ebony.Std.Fixid", 196, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.coordInterpType_", 610425448, "Black.Camera.CoordInterpType", 200, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.pogInterpTime_", 2007061990, "float", 204, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.pogTimeInterpMode_", 2045120351, "SQEX.Ebony.Framework.TimeControl.InterpMode", 208, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.pogVelocity_", 35893654, "float", 212, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.isUpdateYDirectly_", 2837987103, "bool", 216, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.pogDirectionYVelocity_", 1082124262, "float", 220, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.matrixType_", 2831552810, "Black.Camera.MatrixType", 224, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.offsetType_", 3965516812, "Black.Camera.SeamlessInGameOffsetType", 228, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.pogOffset_", 607576642, "Luminous.Math.VectorA", 240, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.isUseAddOffsetXByProjectionBetweenPCandTarget_", 2569193589, "bool", 272, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.addOffsetXSabunMultiplyRate_", 2477256568, "float", 276, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.addOffsetXMaxLimit_", 1754952542, "float", 280, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.isUpdateXEveryFrame_", 3116278872, "bool", 284, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.isUpdateYEveryFrame__", 2680651982, "bool", 285, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.isUpdateZEveryFrame_", 374852638, "bool", 286, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.lockOnType_", 1364651742, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnType", 296, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.actorBaseType_", 1659192518, "Black.Camera.SeamlessInGameActorBaseType", 300, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.lockOnActorOffsetType_", 345433254, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnActorOffsetType", 304, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.boneId_", 2226270441, "SQEX.Ebony.Std.Fixid", 308, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionBaseType_", 3587113400, "Black.Camera.AutoCompositionBaseType", 312, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionUpdateType_", 3636045284, "Black.Camera.AutoCompositionUpdateType", 316, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.valueSettingType_", 3899692185, "Black.Camera.ValueSettingType", 324, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.incEyeDistance_", 3329328574, "float", 328, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isDisableBattleAddDistance_", 3133886870, "bool", 332, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.seamlessInGameFlameInAddDistanceCalcType_", 3621477053, "Black.Camera.SeamlessInGameFlameInAddDistanceCalcType", 336, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isDisableAroundStatusAddDistance_", 2636424483, "bool", 340, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.addDistanceRate_", 1951347064, "float", 344, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isDisableAngleDiffBetweenCam2PCAddDistance_", 3966181618, "bool", 348, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.overrideEyeDistance_", 2086105640, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.minimumGuaranteeEyeDistance_", 4222704638, "float", 356, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.povVelocity_", 4121629536, "float", 360, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.matrixType_", 2274861571, "Black.Camera.MatrixType", 364, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.povOffset_", 1648594688, "Luminous.Math.VectorA", 368, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.offsetXValueType_", 149451218, "Black.Camera.OffsetXValueType", 384, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionShotSize_", 1942688948, "int", 388, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionFovLevel_", 4171386142, "int", 392, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionPovBoneId_", 4019793381, "SQEX.Ebony.Std.Fixid", 396, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionFlameHeightRate_", 2925817925, "float", 400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionFlameHeightYawRate_", 7214720, "float", 404, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isUpdateXEveryFrame_", 910403479, "bool", 408, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isUpdateYEveryFrame__", 528956111, "bool", 409, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isUpdateZEveryFrame_", 3601915185, "bool", 410, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("pogId_", 3544029037, "Ebony.Base.String", 88, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("pogMatrixId_", 2515425146, "Ebony.Base.String", 104, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("pogOffsetId_", 3760658920, "Ebony.Base.String", 120, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("pogSignId_", 4146110498, "Ebony.Base.String", 136, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("povDistanceId_", 2221319305, "Ebony.Base.String", 152, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("pogData_", 3340733518, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPog", 176, 112, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("povData_", 1033385879, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPov", 288, 128, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new InGameCameraPovPCKeepTrackItem();
        }
		
    }
}