using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetSameLevelPackageLoadManager : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin up_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin down_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishUpper_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishLower_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin completed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin completedUpper_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin completedLower_;
		public string packagePath_= string.Empty;
		public string campPackagePath_= string.Empty;
		public IList<Black.Sequence.Action.Level.DungeonLevelItem> itemList_= new List<Black.Sequence.Action.Level.DungeonLevelItem>();
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueInitLevel_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueOffset_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valueLevelOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valueCampOut_;
		public UnityEngine.Vector4 offset_;
		public bool isFinish_;
		public int levelMax_;
		public bool isInformNavimeshOffset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetSameLevelPackageLoadManager();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetSameLevelPackageLoadManager", 0, Black.Sequence.Action.Level.SequenceActionSetSameLevelPackageLoadManager.ObjectType, Construct, properties, 0, 1888);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetSameLevelPackageLoadManager", base.GetFieldProperties(), -1138692803, 2084106125);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.pinName_", 3330161590, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.name_", 192292993, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.connections_", 490033121, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayType_", 261766523, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 248, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayTime_", 1689218608, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayMaxTime_", 1529341114, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("up_.pinName_", 2863165708, "Base.String", 280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("up_.name_", 35835319, "Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("up_.connections_", 2569744279, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 312, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("up_.delayType_", 174928081, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 344, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("up_.delayTime_", 3695570566, "float", 348, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("up_.delayMaxTime_", 2166804396, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("down_.pinName_", 2411248377, "Base.String", 376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("down_.name_", 2343172164, "Base.String", 392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("down_.connections_", 1152540154, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 408, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("down_.delayType_", 2261886568, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 440, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("down_.delayTime_", 613199907, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("down_.delayMaxTime_", 2831537243, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.pinName_", 1137295951, "Base.String", 472, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.name_", 2182257194, "Base.String", 488, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.connections_", 2048532136, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 504, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayType_", 124432558, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 536, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayTime_", 3264366185, "float", 540, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayMaxTime_", 456551125, "float", 544, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finish_.pinName_", 2309327954, "Base.String", 568, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finish_.name_", 578120909, "Base.String", 584, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finish_.connections_", 2970475829, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 600, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("finish_.delayType_", 537700863, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 632, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finish_.delayTime_", 462558956, "float", 636, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finish_.delayMaxTime_", 1069533014, "float", 640, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishUpper_.pinName_", 676322710, "Base.String", 664, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishUpper_.name_", 3915515169, "Base.String", 680, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishUpper_.connections_", 478237825, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 696, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("finishUpper_.delayType_", 51847259, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 728, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishUpper_.delayTime_", 3160800400, "float", 732, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishUpper_.delayMaxTime_", 2734869466, "float", 736, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishLower_.pinName_", 4273611855, "Base.String", 760, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishLower_.name_", 2680455210, "Base.String", 776, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishLower_.connections_", 3828261032, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 792, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("finishLower_.delayType_", 112648878, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 824, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishLower_.delayTime_", 3252582505, "float", 828, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishLower_.delayMaxTime_", 427757781, "float", 832, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("completed_.pinName_", 331431122, "Base.String", 856, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("completed_.name_", 1789505101, "Base.String", 872, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("completed_.connections_", 55842229, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 888, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("completed_.delayType_", 1485115007, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 920, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("completed_.delayTime_", 1409973100, "float", 924, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("completed_.delayMaxTime_", 1145747670, "float", 928, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("completedUpper_.pinName_", 752537366, "Base.String", 952, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("completedUpper_.name_", 567962017, "Base.String", 968, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("completedUpper_.connections_", 489283073, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 984, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("completedUpper_.delayType_", 4197133787, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1016, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("completedUpper_.delayTime_", 3011119632, "float", 1020, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("completedUpper_.delayMaxTime_", 743653466, "float", 1024, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("completedLower_.pinName_", 54859215, "Base.String", 1048, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("completedLower_.name_", 3627869354, "Base.String", 1064, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("completedLower_.connections_", 3839306280, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1080, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("completedLower_.delayType_", 4257935406, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1112, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("completedLower_.delayTime_", 3102901737, "float", 1116, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("completedLower_.delayMaxTime_", 2731509077, "float", 1120, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueInitLevel_.pinName_", 1129099854, "Base.String", 1192, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueInitLevel_.name_", 2074582153, "Base.String", 1208, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueInitLevel_.connections_", 4208792057, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1224, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("valueInitLevel_.pinValueType_", 1752676992, "Base.String", 1256, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueOffset_.pinName_", 2010517009, "Base.String", 1280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueOffset_.name_", 1218190796, "Base.String", 1296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueOffset_.connections_", 380776530, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1312, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("valueOffset_.pinValueType_", 2917862433, "Base.String", 1344, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueLevelOut_.pinName_", 1100361616, "Base.String", 1368, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueLevelOut_.name_", 3490940411, "Base.String", 1384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueLevelOut_.connections_", 571759763, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1400, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("valueLevelOut_.pinValueType_", 327555502, "Base.String", 1432, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueCampOut_.pinName_", 2815305729, "Base.String", 1456, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueCampOut_.name_", 6550652, "Base.String", 1472, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueCampOut_.connections_", 219278818, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1488, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("valueCampOut_.pinValueType_", 3571302609, "Base.String", 1520, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("up_", 1636505837, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("down_", 1969139582, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("finish_", 190439095, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("finishUpper_", 971381043, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("finishLower_", 22648832, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("completed_", 543657015, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 848, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("completedUpper_", 1022345651, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 944, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("completedLower_", 73613440, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1040, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("packagePath_", 3395354377, "Ebony.Base.String", 1136, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("campPackagePath_", 3001348604, "Ebony.Base.String", 1152, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("itemList_", 2476936183, "SQEX.Ebony.Std.DynamicArray< Black.Sequence.Action.Level.DungeonLevelItem* >", 1168, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueInitLevel_", 1342983643, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1184, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueOffset_", 513640070, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueLevelOut_", 2094986409, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1360, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueCampOut_", 4099706262, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1448, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("offset_", 1294275471, "Luminous.Math.VectorA", 1536, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("isFinish_", 16708295, "bool", 1552, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("levelMax_", 1272701146, "int", 1556, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("isInformNavimeshOffset_", 250826803, "bool", 1560, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionSetSameLevelPackageLoadManager();
        }
		
    }
}