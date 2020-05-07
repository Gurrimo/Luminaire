using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveGameConfigMain
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Luminous.GameFramework.Locale.LocaleCategory text_;
		public Luminous.GameFramework.Locale.LocaleCategory voice_;
		public int brightness_;
		public int soundMode_;
		public bool virticalCameraNormal_;
		public bool horizontalCameraNormal_;
		public bool displayText_;
		public bool speakerText_;
		public bool vibrationEnable_;
		public bool firstBoot_;
		public bool newgamePlus_;
		public int masterVolume_;
		public int bgmVolume_;
		public int voiceVolume_;
		public int seVolume_;
		public int cameraSpeed_;
		public int padButtonIconKind_;
		public int autoSaveSlotNo_;
		public int autoSaveSlotOldNo_;
		public bool rotateNaviMap_;
		public bool displayNaviMap_;
		public bool displayNaviMapRoute_;
		public bool displayKeyHelp_;
		public bool displayHUD_;
		public int cameraLength_;
		public bool isHUDFullscreen_;
		public bool displayHelpMessage_;
		public bool displaySTGauge_;
		public bool is4KMode_;
		public int gameMode_;
		public int gameStyle_;
		public int controllerType_;
		public int reserved0_;
		public int reserved1_;
		public int reserved2_;
		public int reserved3_;
		public bool reserved4_;
		public bool reserved5_;
		public bool reserved6_;
		public bool isHDRMode_;
		public long reservedStats_;
		public bool appContent_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveGameConfigMain();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveGameConfigMain", 0, Black.Save.Config.SaveGameConfigMain.ObjectType, null, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveGameConfigMain", null, -1990184729, 1757269977);
            
			fieldProperties.AddProperty(new Property("text_", 1384997555, "Luminous.GameFramework.Locale.LocaleCategory", 0, 4, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("voice_", 2285793362, "Luminous.GameFramework.Locale.LocaleCategory", 4, 4, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("brightness_", 2567634479, "int", 8, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("soundMode_", 937406328, "int", 12, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("virticalCameraNormal_", 3391388204, "bool", 16, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("horizontalCameraNormal_", 3848184586, "bool", 17, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("displayText_", 132010371, "bool", 18, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("speakerText_", 784285026, "bool", 19, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("vibrationEnable_", 1901477143, "bool", 20, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("firstBoot_", 537906066, "bool", 21, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("newgamePlus_", 3822884768, "bool", 22, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("masterVolume_", 1035454998, "int", 24, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("bgmVolume_", 837035660, "int", 28, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("voiceVolume_", 457371940, "int", 32, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("seVolume_", 412011312, "int", 36, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("cameraSpeed_", 4088304938, "int", 40, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("padButtonIconKind_", 1981494334, "int", 44, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoSaveSlotNo_", 1672330977, "int", 48, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoSaveSlotOldNo_", 548541072, "int", 52, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotateNaviMap_", 1860574069, "bool", 56, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("displayNaviMap_", 1914610134, "bool", 57, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("displayNaviMapRoute_", 3977974683, "bool", 58, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("displayKeyHelp_", 2961269472, "bool", 59, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("displayHUD_", 3652610315, "bool", 60, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("cameraLength_", 2317480559, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("isHUDFullscreen_", 894077060, "bool", 68, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("displayHelpMessage_", 343693930, "bool", 69, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("displaySTGauge_", 178155610, "bool", 70, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("is4KMode_", 2037326092, "bool", 71, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("gameMode_", 36591373, "Black.Save.GAME_MODE", 72, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("gameStyle_", 2327791589, "Black.Save.GAME_STYLE", 76, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("controllerType_", 3222919810, "Black.Save.CONTROLLER_TYPE", 80, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserved0_", 365964600, "int", 84, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserved1_", 365817505, "int", 88, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserved2_", 3587458470, "int", 92, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserved3_", 3587311375, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserved4_", 365273052, "bool", 100, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserved5_", 3586325637, "bool", 101, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserved6_", 3586870090, "bool", 102, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isHDRMode_", 407115587, "bool", 103, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("reservedStats_", 747837329, "int64_t", 104, 160, 20, Property.PrimitiveType.Int64, 0, (char)8));
			fieldProperties.AddProperty(new Property("appContent_", 2420367250, "bool", 264, 100, 100, Property.PrimitiveType.Bool, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}