using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraCollision : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int checkCollisionType_;
		public bool isNeedCheckFocusFromPC_;
		public bool isNeedCheckAdjustPog_;
		public bool isNeedCheckGroundHeight_;
		public float groundCheckMarginHeight_;
		public float groundCheckMinimumHeight_;
		public bool isEnableCharaFadeOutWhenCollidedByCamera_;
		public bool isEnablePCFadeWhenCollidedByCamera_;
		public bool isUsePCFaseFadeWhenCollidedByCamera_;
		public bool isUseAdjustFadeMinPowerWhenCollidedByCamera_;
		public float charaFadeByCameraSphereRadius_;
		public bool isEndBlendCheckCollision_;
		public int endBlendCheckCollisionType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraCollision();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCollision", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCollision.ObjectType, Construct, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCollision", base.GetFieldProperties(), -1975832595, 536296909);
            
			
			
			fieldProperties.AddProperty(new Property("checkCollisionType_", 2944079722, "Black.Camera.CheckCollisionType", 8, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNeedCheckFocusFromPC_", 2865216757, "bool", 12, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNeedCheckAdjustPog_", 2938502035, "bool", 13, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNeedCheckGroundHeight_", 2159384780, "bool", 14, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundCheckMarginHeight_", 1441363252, "float", 16, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundCheckMinimumHeight_", 727426570, "float", 20, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnableCharaFadeOutWhenCollidedByCamera_", 4029721446, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnablePCFadeWhenCollidedByCamera_", 3602812626, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUsePCFaseFadeWhenCollidedByCamera_", 2255715659, "bool", 26, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseAdjustFadeMinPowerWhenCollidedByCamera_", 4096333349, "bool", 27, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("charaFadeByCameraSphereRadius_", 1245123424, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEndBlendCheckCollision_", 2965525390, "bool", 32, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("endBlendCheckCollisionType_", 989849126, "Black.Camera.CheckCollisionType", 36, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new InGameCameraCollision();
        }
		
    }
}