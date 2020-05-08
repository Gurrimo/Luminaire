using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraGeneralStart : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isUse_;
		public bool isCutChangeOrder_;
		public bool isNeedClearCameraContainerBlendDataWhenCutChange_;
		public float interpTime_;
		public int interpBlendMode_;
		public bool isUseCommonData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPogStart pogData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPogStart povData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYawStart turnYawData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTiltStart turnTiltData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRollStart turnRollData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovStartNew fovData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraGeneralStart();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralStart", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralStart.ObjectType, Construct, properties, 0, 184);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralStart", base.GetFieldProperties(), 1239833791, -742281100);
            
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.isUse_", 1043373964, "bool", 32, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.isUpdateXEveryFrame_", 3116278872, "bool", 33, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.isUpdateYEveryFrame__", 2680651982, "bool", 34, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.isUpdateZEveryFrame_", 374852638, "bool", 35, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isUse_", 2792093835, "bool", 48, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isUpdateXEveryFrame_", 910403479, "bool", 49, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isUpdateYEveryFrame__", 528956111, "bool", 50, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isUpdateZEveryFrame_", 3601915185, "bool", 51, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.rotationUseValueType_", 1115878171, "Black.Camera.RotationUseValueType", 64, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.rotationSetAngleType_", 4027057550, "Black.Camera.SeamlessInGameSetAngleType", 68, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.rotationDirection_", 1579384420, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 72, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.isUse_", 2445327348, "bool", 80, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.isUpdateTurnEveryFrame_", 2860236819, "bool", 81, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_.rotationUseValueType_", 3013828263, "Black.Camera.RotationUseValueType", 96, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_.rotationSetAngleType_", 1435317018, "Black.Camera.SeamlessInGameSetAngleType", 100, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_.rotationDirection_", 1096139120, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 104, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_.isUse_", 2992710000, "bool", 112, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_.isUpdateTurnEveryFrame_", 1074158991, "bool", 113, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnRollData_.rotationUseValueType_", 3635424035, "Black.Camera.RotationUseValueType", 128, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnRollData_.rotationSetAngleType_", 2420528358, "Black.Camera.SeamlessInGameSetAngleType", 132, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnRollData_.rotationDirection_", 3559854140, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 136, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnRollData_.isUse_", 2054150972, "bool", 144, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnRollData_.isUpdateTurnEveryFrame_", 3180718299, "bool", 145, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.isUse_", 4252696761, "bool", 160, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.fovUseValueType_", 3709996473, "Black.Camera.FovUseValueType", 164, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.setFovType_", 2031959359, "Black.Camera.SeamlessInGameSetFovType", 168, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.isUpdateEveryFrame_", 477637569, "bool", 172, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("isUse_", 318966273, "bool", 8, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCutChangeOrder_", 320944258, "bool", 9, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNeedClearCameraContainerBlendDataWhenCutChange_", 2284833010, "bool", 10, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("interpTime_", 2206145623, "float", 12, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("interpBlendMode_", 3870805242, "SQEX.Ebony.Framework.TimeControl.InterpMode", 16, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseCommonData_", 315510974, "bool", 20, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("pogData_", 3340733518, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPogStart", 24, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("povData_", 1033385879, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPogStart", 40, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnYawData_", 1189308438, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYawStart", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnTiltData_", 79670634, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTiltStart", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnRollData_", 1042086494, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRollStart", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fovData_", 3792695137, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovStartNew", 152, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new InGameCameraGeneralStart();
        }
		
    }
}