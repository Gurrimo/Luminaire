using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class ClimateChangeArea2Entity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enableTrigger_;
		public UnityEngine.Vector4 scaling_;
		public int triggerType_;
		public uint climateId_;
		public string weatherKey_;
		public short priorityLevel_;
		public float transitionTime_;
		public bool isIndoorEnv_;
		public bool drawSky_;
		public bool useMainLight_;
		public bool updateWeather_;
		public bool updateFoliage_;
		public bool updateHeightMap_;
		public bool updateOceans_;
		public bool useFullResWaterSSR_;
		public bool rainOcclusionMapSettingOverride_;
		public float rainOcclusionMapHeight_;
		public float rainOcclusionMapDepth_;
		public bool useAniso_;
		public string preset_;
		public float fadeSec_;
		public uint eventId_;
		public uint eventEndId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ClimateChangeArea2Entity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.ClimateChangeArea2Entity", 0, Black.Entity.Node.ClimateChangeArea2Entity.ObjectType, null, properties, 0, 384);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.ClimateChangeArea2Entity", base.GetFieldProperties(), 592108503, -923010447);
            
			fieldProperties.AddProperty(new Property("enableTrigger_", 1936258923, "bool", 256, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("scaling_", 3325430311, "Luminous.Math.VectorA", 272, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerType_", 1915532364, "Black.Entity.Node.ClimateChangeArea2Entity.TriggerType", 288, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("climateId_", 2674659282, "SQEX.Ebony.Std.Fixid", 292, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("weatherKey_", 1274001839, "SQEX.Ebony.Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("priorityLevel_", 3014990202, "int16_t", 312, 2, 1, Property.PrimitiveType.Int16, 0, (char)0));
			fieldProperties.AddProperty(new Property("transitionTime_", 897948532, "float", 316, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isIndoorEnv_", 1218005774, "bool", 320, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("drawSky_", 2377302789, "bool", 321, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("useMainLight_", 2899741804, "bool", 322, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("updateWeather_", 3060604117, "bool", 323, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("updateFoliage_", 2689716008, "bool", 324, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("updateHeightMap_", 993487656, "bool", 325, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("updateOceans_", 676139588, "bool", 326, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("useFullResWaterSSR_", 1108233561, "bool", 327, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainOcclusionMapSettingOverride_", 2068075755, "bool", 328, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainOcclusionMapHeight_", 3784187282, "float", 332, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rainOcclusionMapDepth_", 3278456292, "float", 336, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("useAniso_", 2387799141, "bool", 340, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("preset_", 158396755, "Ebony.Base.String", 344, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeSec_", 432278097, "float", 360, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("eventId_", 548562519, "SQEX.Ebony.Std.Fixid", 364, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("eventEndId_", 4289875194, "SQEX.Ebony.Std.Fixid", 368, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}