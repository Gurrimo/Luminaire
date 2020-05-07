using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraTurnTiltStart : Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnBlendBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isUse_;
		public bool isUpdateTurnEveryFrame_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraTurnTiltStart();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTiltStart", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTiltStart.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTiltStart", base.GetFieldProperties(), -785225836, -206549444);
            
			fieldProperties.AddProperty(new Property("isUse_", 318966273, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUpdateTurnEveryFrame_", 3599398000, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}