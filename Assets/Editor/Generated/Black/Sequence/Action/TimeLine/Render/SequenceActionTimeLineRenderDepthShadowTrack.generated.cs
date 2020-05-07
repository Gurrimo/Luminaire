using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render
{
    public partial class SequenceActionTimeLineRenderDepthShadowTrack : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		public bool shadowCalcRadiusEnabled_;
		public bool shadowCullCheckMinEnabled_;
		public float zNear_;
		public float shadowDistance0_;
		public float shadowCullSize0_;
		public float shadowDistance1Near_;
		public float shadowDistance1_;
		public float shadowCullSize1_;
		public float shadowDistance2Near_;
		public float shadowDistance2_;
		public float shadowCullSize2_;
		public float shadowDistance3Near_;
		public float shadowDistance3_;
		public float shadowCullSize3_;
		public float depthBias_;
		public float depthCascadeFactor_;
		public float depthSlope_;
		public float normalBias_;
		public float dropRange_;
		public float dropRangeMode_;
		public int cascadeShadowCount_;
		public int shadowResolution_;
		public bool inverseShadowDepthCulling_;
		public float fadeFarValue_;
		public bool shadowYLimitEnabled_;
		public float shadowYLimit_;
		public bool freeCameraAngle_;
		public bool dirEnabled_;
		public float dirX_;
		public float dirY_;
		public float dirZ_;
		public float rotX_;
		public float rotY_;
		public float rotZ_;
		public int maxNumShadowedLights_;
		public Black.System.TimeLine.TrackItem.Render.DepthShadowTrackItem masterTrackItem_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineRenderDepthShadowTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.SequenceActionTimeLineRenderDepthShadowTrack", 0, Black.Sequence.Action.TimeLine.Render.SequenceActionTimeLineRenderDepthShadowTrack.ObjectType, null, properties, 0, 544);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.SequenceActionTimeLineRenderDepthShadowTrack", base.GetFieldProperties(), 1968293322, -617474687);
            
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 320, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowCalcRadiusEnabled_", 1642214844, "bool", 321, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowCullCheckMinEnabled_", 3387051819, "bool", 322, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("zNear_", 908950600, "float", 324, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowDistance0_", 760343343, "float", 328, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowCullSize0_", 977913733, "float", 332, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowDistance1Near_", 309172216, "float", 336, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowDistance1_", 760490438, "float", 340, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowCullSize1_", 2051828444, "float", 344, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowDistance2Near_", 3815847531, "float", 348, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowDistance2_", 3981248833, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowCullSize2_", 2051975539, "float", 356, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowDistance3Near_", 1788396162, "float", 360, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowDistance3_", 3981395928, "float", 364, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowCullSize3_", 978458186, "float", 368, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("depthBias_", 1085894480, "float", 372, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("depthCascadeFactor_", 3845284608, "float", 376, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("depthSlope_", 567174550, "float", 380, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("normalBias_", 4258643016, "float", 384, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("dropRange_", 1190671434, "float", 388, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("dropRangeMode_", 2594239171, "float", 392, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("cascadeShadowCount_", 3906764789, "int", 396, 4, 1, Property.PrimitiveType.Int32, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowResolution_", 1208541428, "int", 400, 4, 1, Property.PrimitiveType.Int32, 0, (char)1));
			fieldProperties.AddProperty(new Property("inverseShadowDepthCulling_", 273350453, "bool", 404, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("fadeFarValue_", 2522532850, "float", 408, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowYLimitEnabled_", 642254157, "bool", 412, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("shadowYLimit_", 3136911660, "float", 416, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("freeCameraAngle_", 1233622936, "bool", 420, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("dirEnabled_", 3693726654, "bool", 421, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("dirX_", 3301879201, "float", 424, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("dirY_", 3302026296, "float", 428, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("dirZ_", 2228405775, "float", 432, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("rotX_", 3949304839, "float", 436, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("rotY_", 3949451934, "float", 440, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("rotZ_", 3949010649, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("maxNumShadowedLights_", 2732546004, "int", 448, 4, 1, Property.PrimitiveType.Int32, 0, (char)1));
			fieldProperties.AddProperty(new Property("masterTrackItem_", 1305972098, "Black.System.TimeLine.TrackItem.Render.DepthShadowTrackItem", 456, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}