using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraPogStart : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isUse_;
		public bool isUpdateXEveryFrame_;
		public bool isUpdateYEveryFrame__;
		public bool isUpdateZEveryFrame_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraPogStart();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPogStart", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPogStart.ObjectType, Construct, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPogStart", base.GetFieldProperties(), -882241743, -1469675481);
            
			
			
			fieldProperties.AddProperty(new Property("isUse_", 318966273, "bool", 8, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUpdateXEveryFrame_", 3087219209, "bool", 9, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUpdateYEveryFrame__", 4146338457, "bool", 10, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUpdateZEveryFrame_", 2447887599, "bool", 11, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new InGameCameraPogStart();
        }
		
    }
}