using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraTurnRollEnd : Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnBlendBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isUse_;
		public int interpMode_;
		public float interpTime_;
		public float interpVelocity_;
		public float turnRoll_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraTurnRollEnd();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRollEnd", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRollEnd.ObjectType, Construct, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRollEnd", base.GetFieldProperties(), -1777947719, 595230543);
            
			fieldProperties.AddIndirectlyProperty(new Property("rotationUseValueType_", 489983024, "Black.Camera.RotationUseValueType", 8, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotationSetAngleType_", 7143229, "Black.Camera.SeamlessInGameSetAngleType", 12, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotationDirection_", 1052729957, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 16, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("isUse_", 318966273, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("interpMode_", 1180138017, "Black.Camera.BlendModeType", 28, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("interpTime_", 2206145623, "float", 32, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("interpVelocity_", 4143689385, "float", 36, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnRoll_", 2444428606, "float", 40, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new InGameCameraTurnRollEnd();
        }
		
    }
}