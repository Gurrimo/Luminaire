using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveGraphicsConfigMain
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int displayResolutionWidth_;
		public int displayResolutionHeight_;
		public int currentDisplay_;
		public int maxFramerate_;
		public bool fullScreen_;
		public bool vSyncWaitEnable_;
		public int hdrBlightness_;
		public bool showFPS_;
		public int graphicsPreset_;
		public int display3DResolution_;
		public int assetSpecLevel_;
		public int modelLODScaling_;
		public int textureStreamingMemory_;
		public int textureAnisotropicFilter_;
		public bool terrainTessellationEnable_;
		public int lighting_;
		public int shadow_;
		public int ambientOcclusion_;
		public int antialias_;
		public bool motionBlur_;
		public int screenFilterDetail_;
		public bool nvidiaHairWorks_;
		public bool nvidiaVXAO_;
		public bool nvidiaTurf_;
		public bool nvidiaShadowLibs_;
		public bool hardwareFullScreen_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveGraphicsConfigMain();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveGraphicsConfigMain", 0, Black.Save.Config.SaveGraphicsConfigMain.ObjectType, null, properties, 0, 88);
        }
		
        public  ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected  PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveGraphicsConfigMain", null, 1128139620, 60261537);
            
			fieldProperties.AddProperty(new Property("displayResolutionWidth_", 328975530, "int", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("displayResolutionHeight_", 4012122509, "int", 4, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("currentDisplay_", 504104205, "int", 8, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxFramerate_", 302421221, "int", 12, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("fullScreen_", 2941317669, "bool", 16, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("vSyncWaitEnable_", 1364943633, "bool", 17, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("hdrBlightness_", 546154561, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("showFPS_", 3855208252, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("graphicsPreset_", 2655089400, "int", 28, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("display3DResolution_", 4023420613, "int", 32, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("assetSpecLevel_", 682197303, "int", 36, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("modelLODScaling_", 197249451, "int", 40, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("textureStreamingMemory_", 2063247760, "int", 44, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("textureAnisotropicFilter_", 3406409464, "int", 48, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("terrainTessellationEnable_", 2899252085, "bool", 52, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("lighting_", 57773858, "int", 56, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadow_", 4138696858, "int", 60, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientOcclusion_", 1782925705, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("antialias_", 2059861104, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("motionBlur_", 903728055, "bool", 72, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("screenFilterDetail_", 4240397495, "int", 76, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("nvidiaHairWorks_", 162461013, "bool", 80, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("nvidiaVXAO_", 4222171441, "bool", 81, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("nvidiaTurf_", 101243798, "bool", 82, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("nvidiaShadowLibs_", 228354511, "bool", 83, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("hardwareFullScreen_", 1159135361, "bool", 84, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}