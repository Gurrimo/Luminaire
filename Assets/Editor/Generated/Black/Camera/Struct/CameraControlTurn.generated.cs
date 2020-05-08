using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Camera.Struct
{
    public partial class CameraControlTurn : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int mode;
		public bool isUseAutoAdjustMode_;
		public bool isUseAutoAdjustAngleMode_;
		public bool isUseDefaultBrakeParam_;
		public float controlTurnVelocity_;
		public float backToDefaultTurnVelocity_;
		public float yawMin_;
		public float yawMax_;
		public float tiltMin_;
		public float tiltMax_;
		public float brakeAngleYaw_;
		public float brakePowerYaw_;
		public float brakeAngleTilt_;
		public float brakePowerTilt_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CameraControlTurn();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Camera.Struct.CameraControlTurn", 0, Black.Camera.Struct.CameraControlTurn.ObjectType, Construct, properties, 0, 56);
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

            fieldProperties = new PropertyContainer("Black.Camera.Struct.CameraControlTurn", base.GetFieldProperties(), -1676972646, 589691802);
            
			
			
			fieldProperties.AddProperty(new Property("mode", 3966689298, "Black.Camera.Struct.CameraControlTurnMode", 8, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseAutoAdjustMode_", 1766698032, "bool", 12, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseAutoAdjustAngleMode_", 3828156189, "bool", 13, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseDefaultBrakeParam_", 3397886126, "bool", 14, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("controlTurnVelocity_", 2626005543, "float", 16, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("backToDefaultTurnVelocity_", 1608529397, "float", 20, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("yawMin_", 2200951649, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("yawMax_", 3927045883, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("tiltMin_", 2480133719, "float", 32, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("tiltMax_", 757982437, "float", 36, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("brakeAngleYaw_", 1986932595, "float", 40, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("brakePowerYaw_", 2378328281, "float", 44, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("brakeAngleTilt_", 3398535985, "float", 48, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("brakePowerTilt_", 3303021399, "float", 52, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new CameraControlTurn();
        }
		
    }
}