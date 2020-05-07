using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraTurnTilt : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isUse_;
		public int rotationUseValueTypeTilt_;
		public bool isUseDefaultValueWhenBattleHybridAndOverride_;
		public int turnInterpType_;
		public int turnTimeInterpMode_;
		public bool isUseAdjustAngle_;
		public bool isUpdateTurnEveryFrame_;
		public int rotationSetAngleType_;
		public float turnInterpTimeTilt_;
		public float turnVelocityTilt_;
		public float turnTilt_;
		public bool isAllowUserControlTurn_;
		public int stealingPlayerDirectionInterpType_;
		public float stealingPlayerDirectionInterpVelocity_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraTurnTilt();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTilt", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTilt.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTilt", base.GetFieldProperties(), 978977602, 215167140);
            
			fieldProperties.AddProperty(new Property("isUse_", 318966273, "bool", 8, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotationUseValueTypeTilt_", 2593353221, "Black.Camera.RotationUseValueType", 12, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseDefaultValueWhenBattleHybridAndOverride_", 3949753756, "bool", 16, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnInterpType_", 1040511941, "Black.Camera.RotationInterpType", 20, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnTimeInterpMode_", 4035728667, "Black.Camera.BlendModeType", 24, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseAdjustAngle_", 969232367, "bool", 32, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUpdateTurnEveryFrame_", 3599398000, "bool", 33, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotationSetAngleType_", 7143229, "Black.Camera.SeamlessInGameSetAngleType", 36, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnInterpTimeTilt_", 2199305175, "float", 40, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnVelocityTilt_", 2747914159, "float", 44, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("turnTilt_", 3897184282, "float", 48, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("isAllowUserControlTurn_", 4125811390, "bool", 52, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("stealingPlayerDirectionInterpType_", 3676963821, "Black.Camera.StealingPlayerDirectionInterpType", 56, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("stealingPlayerDirectionInterpVelocity_", 3374573324, "float", 60, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			
			
			return fieldProperties;
        }

		
    }
}