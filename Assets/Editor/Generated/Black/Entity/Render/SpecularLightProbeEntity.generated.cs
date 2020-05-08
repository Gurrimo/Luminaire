using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Render
{
    public partial class SpecularLightProbeEntity : Black.Entity.Render.LightProbeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		public bool boxShape_;
		public bool useNewFadingControl_;
		public float power_;
		public bool renderDebug_;
		public bool renderInfluence_;
		public bool detatchCaptureBox_;
		public float captureRadius_;
		public UnityEngine.Vector4 captureBoxPosition_;
		public UnityEngine.Vector4 captureBoxRotation_;
		public UnityEngine.Vector4 captureBoxScale_;
		public bool setCaptureToInfluence_;
		public float useDirLightShadow_;
		public string sourceDirectory_= string.Empty;
		public string sourceFileName_= string.Empty;
		public float captureZNear_;
		public float captureZFar_;
		public int capturingOption_;
		public float captureAmbientScale_;
		public bool captureNow_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SpecularLightProbeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Render.SpecularLightProbeEntity", 0, Black.Entity.Render.SpecularLightProbeEntity.ObjectType, Construct, properties, 0, 720);
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

            fieldProperties = new PropertyContainer("Black.Entity.Render.SpecularLightProbeEntity", base.GetFieldProperties(), -123102586, 996350082);
            
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entitySearchLabelId_", 3840219358, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("scaling_", 3325430311, "SQEX.Luminous.Math.VectorA", 288, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("indoor_", 3843014775, "bool", 304, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("oceanOnly_", 1385946972, "bool", 305, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blendLayer_", 64456310, "int", 308, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("probeMaskType_", 1846203086, "Black.Entity.Render.LightProbeEntityBase.PROBE_MASK_TYPE", 312, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fadeLengthXZ_", 3648846130, "SQEX.Luminous.Math.VectorA", 320, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fadeLengthY_", 408022843, "SQEX.Luminous.Math.VectorA", 336, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("radius_", 2286360452, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("interpolationRadius_", 1399182860, "float", 356, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("boxShape_", 4075282224, "bool", 369, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("useNewFadingControl_", 1413719157, "bool", 370, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("power_", 1150566491, "float", 372, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("renderDebug_", 4286953853, "bool", 376, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("renderInfluence_", 1055556861, "bool", 377, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("detatchCaptureBox_", 1668914652, "bool", 378, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("captureRadius_", 2011779488, "float", 380, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("captureBoxPosition_", 2996234786, "LM_NS_MATH.VectorA", 384, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("captureBoxRotation_", 3090160369, "LM_NS_MATH.VectorA", 400, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("captureBoxScale_", 1079105865, "LM_NS_MATH.VectorA", 416, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("setCaptureToInfluence_", 3490831602, "bool", 432, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("useDirLightShadow_", 1513720650, "float", 436, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourceDirectory_", 2687263660, "Ebony.Base.String", 440, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourceFileName_", 1506120470, "Ebony.Base.String", 456, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("captureZNear_", 228627148, "float", 472, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("captureZFar_", 2498364095, "float", 476, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("capturingOption_", 737721064, "Black.Entity.Render.SpecularLightProbeEntity.CAPTURE_OPTION", 480, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("captureAmbientScale_", 2690275888, "float", 484, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("captureNow_", 91214628, "bool", 488, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SpecularLightProbeEntity();
        }
		
    }
}