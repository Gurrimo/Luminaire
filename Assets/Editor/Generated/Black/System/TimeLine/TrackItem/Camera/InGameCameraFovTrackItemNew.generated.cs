using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class InGameCameraFovTrackItemNew : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string fovId_= string.Empty;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovNew fovData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraFovTrackItemNew();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.InGameCameraFovTrackItemNew", 0, Black.System.TimeLine.TrackItem.Camera.InGameCameraFovTrackItemNew.ObjectType, Construct, properties, 0, 176);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.InGameCameraFovTrackItemNew", base.GetFieldProperties(), -836947333, 1403933992);
            
			fieldProperties.AddIndirectlyProperty(new Property("name_", 182823483, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startTime_", 140908163, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("duration_", 1282328598, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.isUse_", 4252696761, "bool", 112, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.fovCurveDegree_", 1511594452, "float", 116, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.fovUseValueType_", 3709996473, "Black.Camera.FovUseValueType", 120, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.interpType_", 2625157596, "Black.Camera.RotationInterpType", 124, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.timeInterpMode_", 2279307602, "Black.Camera.BlendModeType", 128, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.setFovType_", 2031959359, "Black.Camera.SeamlessInGameSetFovType", 132, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.interpTime_", 3777021775, "float", 136, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.interpVelocity_", 386526241, "float", 140, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.autoCompositionOverrideFov_", 3185339512, "float", 144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.isUpdateEveryFrame_", 477637569, "bool", 148, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.isKeepFovFromLastSeamlessCamera_", 905858788, "bool", 149, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.isIgnoreIncrementFov_", 4109359260, "bool", 150, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.useCalculateFov_", 394518596, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovNew.CalculateFOVType", 152, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.maxTargetRaidus_", 3540973189, "float", 156, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.minTargetRaidus_", 1968280059, "float", 160, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.boundingSizeRate_", 1937741635, "float", 164, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("fovId_", 944640490, "Ebony.Base.String", 88, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("fovData_", 3792695137, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovNew", 104, 72, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new InGameCameraFovTrackItemNew();
        }
		
    }
}