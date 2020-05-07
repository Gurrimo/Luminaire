using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save
{
    public partial class SaveInformation
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int SaveType;
		public string AreaFilePath;
		public uint PlayerRestartPointID;
		public SQEX.Luminous.Math.DoubleVector4 PlayerWorldPos;
		public UnityEngine.Vector4 PlayerRotation;
		public uint ActiveQuestFixID;
		public int SlotNo;
		public int tm_sec;
		public int tm_min;
		public int tm_hour;
		public int tm_mday;
		public int tm_mon;
		public int tm_year;
		public int tm_wday;
		public int tm_yday;
		public int tm_isdst;
		public int PlayerLevel;
		public int ChapterNo;
		public int AutoSaveType;
		public uint CampPlaceFixID;
		public long PlayTime;
		public bool IsClear;
		public bool IsNewPlus;
		public bool IsClearGOTY;
		public int Reserved0;
		public int Reserved1;
		public int Reserved2;
		public int Reserved3;
		public int ScreenShotWidth;
		public int ScreenShotHeight;
		public object ScreenShotBinary;
		public int NoxScore;
		public int NoxGameMode;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveInformation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.SaveInformation", 0, Black.Save.SaveInformation.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.Save.SaveInformation", null, 1449703829, 577117785);
            
			fieldProperties.AddProperty(new Property("SaveType", 2069746464, "Black.Save.SAVE_TYPE", 20, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("AreaFilePath", 2918113105, "Ebony.Base.String", 24, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("PlayerRestartPointID", 2158275454, "SQEX.Ebony.Std.Fixid", 40, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("PlayerWorldPos", 1594914542, "Luminous.Math.DoubleVector4", 48, 32, 1, Property.PrimitiveType.DoubleVector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("PlayerRotation", 3982176134, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("ActiveQuestFixID", 2262850327, "SQEX.Ebony.Std.Fixid", 96, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("SlotNo", 2526835270, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("tm_sec", 2167598752, "int", 104, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("tm_min", 2655167081, "int", 108, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("tm_hour", 1455314457, "int", 112, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("tm_mday", 3039164500, "int", 116, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("tm_mon", 2117400703, "int", 120, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("tm_year", 467010330, "int", 124, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("tm_wday", 3835669586, "int", 128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("tm_yday", 2660421008, "int", 132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("tm_isdst", 2393808114, "int", 136, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("PlayerLevel", 2511586886, "uint32_t", 140, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ChapterNo", 1840517121, "int", 144, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("AutoSaveType", 2627605707, "Black.Save.AUTO_SAVE_TYPE", 148, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("CampPlaceFixID", 1719736247, "SQEX.Ebony.Std.Fixid", 152, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("PlayTime", 564247098, "int64_t", 160, 8, 1, Property.PrimitiveType.Int64, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsClear", 926632754, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsNewPlus", 1524906897, "bool", 169, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsClearGOTY", 1989577247, "bool", 170, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("Reserved0", 1270636503, "int", 172, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("Reserved1", 1253858884, "int", 176, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("Reserved2", 1304191741, "int", 180, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("Reserved3", 1287414122, "int", 184, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ScreenShotWidth", 2496500443, "int", 188, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ScreenShotHeight", 3037310198, "int", 192, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ScreenShotBinary", 244068864, "Luminous.Core.Memory.Buffer", 200, 24, 1, Property.PrimitiveType.Buffer, 0, (char)0));
			fieldProperties.AddProperty(new Property("NoxScore", 1081715028, "uint32_t", 224, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("NoxGameMode", 3145144815, "Black.Save.GAME_MODE", 228, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}