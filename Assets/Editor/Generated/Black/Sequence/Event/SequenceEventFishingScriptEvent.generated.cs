using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event
{
    public partial class SequenceEventFishingScriptEvent : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin first_fishing_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cast_started_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cast_prepare_finished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cast_failed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cast_evening_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cast_few_line_hp_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin lure_splash_down_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin line_break_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin jump_qte_failure_and_keep_lure_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin bite_qte_decided_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin bite_qte_success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin bite_qte_big_fish_success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin bite_qte_failure_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin jump_qte_success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin jump_qte_big_fish_success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin battle_started_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin battle_few_line_hp_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin get_small_fish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin get_normal_fish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin get_big_fish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin get_very_big_fish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin get_small_fish_ui_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin get_normal_fish_ui_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin get_big_fish_ui_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin get_very_big_fish_ui_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin onLineTensionUp_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin onTackleMenuOpened_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventFishingScriptEvent();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.SequenceEventFishingScriptEvent", 0, Black.Sequence.Event.SequenceEventFishingScriptEvent.ObjectType, Construct, properties, 0, 2872);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.SequenceEventFishingScriptEvent", base.GetFieldProperties(), 1639559776, 1492443489);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("in_.pinName_", 3330161590, "Base.String", 192, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.name_", 192292993, "Base.String", 208, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.connections_", 490033121, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 224, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayType_", 261766523, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 256, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayTime_", 1689218608, "float", 260, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayMaxTime_", 1529341114, "float", 264, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("first_fishing_.pinName_", 3504054208, "Base.String", 288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("first_fishing_.name_", 3729166507, "Base.String", 304, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("first_fishing_.connections_", 4164383459, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 320, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("first_fishing_.delayType_", 3891545421, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 352, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("first_fishing_.delayTime_", 1830958298, "float", 356, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("first_fishing_.delayMaxTime_", 2433578016, "float", 360, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_started_.pinName_", 1671994148, "Base.String", 384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_started_.name_", 2206673023, "Base.String", 400, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_started_.connections_", 250486191, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 416, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("cast_started_.delayType_", 4006560793, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 448, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_started_.delayTime_", 1291084638, "float", 452, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_started_.delayMaxTime_", 1728371636, "float", 456, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_prepare_finished_.pinName_", 1079376121, "Base.String", 480, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_prepare_finished_.name_", 1115484740, "Base.String", 496, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_prepare_finished_.connections_", 1499823098, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 512, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("cast_prepare_finished_.delayType_", 1658590312, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 544, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_prepare_finished_.delayTime_", 9903651, "float", 548, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_prepare_finished_.delayMaxTime_", 1052642907, "float", 552, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_failed_.pinName_", 4267733046, "Base.String", 576, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_failed_.name_", 1902605825, "Base.String", 592, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_failed_.connections_", 2217102433, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 608, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("cast_failed_.delayType_", 828818939, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 640, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_failed_.delayTime_", 2256271024, "float", 644, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_failed_.delayMaxTime_", 3901055546, "float", 648, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_evening_.pinName_", 748674677, "Base.String", 672, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_evening_.name_", 1809936560, "Base.String", 688, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_evening_.connections_", 1321526782, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 704, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("cast_evening_.delayType_", 2161932012, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 736, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_evening_.delayTime_", 4229481119, "float", 740, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_evening_.delayMaxTime_", 1317719527, "float", 744, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_few_line_hp_.pinName_", 4282946731, "Base.String", 768, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_few_line_hp_.name_", 410946854, "Base.String", 784, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_few_line_hp_.connections_", 209502940, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 800, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("cast_few_line_hp_.delayType_", 429706514, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 832, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_few_line_hp_.delayTime_", 2701110805, "float", 836, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cast_few_line_hp_.delayMaxTime_", 2666405169, "float", 840, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lure_splash_down_.pinName_", 2841954328, "Base.String", 864, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lure_splash_down_.name_", 1864648883, "Base.String", 880, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lure_splash_down_.connections_", 2907894171, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 896, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("lure_splash_down_.delayType_", 3500230741, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 928, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lure_splash_down_.delayTime_", 1197620690, "float", 932, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lure_splash_down_.delayMaxTime_", 3762867432, "float", 936, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("line_break_.pinName_", 330547367, "Base.String", 960, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("line_break_.name_", 3132222354, "Base.String", 976, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("line_break_.connections_", 2049390592, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 992, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("line_break_.delayType_", 620762838, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1024, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("line_break_.delayTime_", 3532177121, "float", 1028, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("line_break_.delayMaxTime_", 1615931773, "float", 1032, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("jump_qte_failure_and_keep_lure_.pinName_", 3507822762, "Base.String", 1056, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("jump_qte_failure_and_keep_lure_.name_", 3294736181, "Base.String", 1072, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("jump_qte_failure_and_keep_lure_.connections_", 2457052333, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1088, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("jump_qte_failure_and_keep_lure_.delayType_", 4097370279, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1120, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("jump_qte_failure_and_keep_lure_.delayTime_", 2247997924, "float", 1124, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("jump_qte_failure_and_keep_lure_.delayMaxTime_", 2579825086, "float", 1128, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_decided_.pinName_", 1855555047, "Base.String", 1152, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_decided_.name_", 3058092242, "Base.String", 1168, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_decided_.connections_", 1710813248, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1184, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_decided_.delayType_", 2464427798, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1216, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_decided_.delayTime_", 656417313, "float", 1220, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_decided_.delayMaxTime_", 579100349, "float", 1224, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_success_.pinName_", 3127272388, "Base.String", 1248, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_success_.name_", 870309599, "Base.String", 1264, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_success_.connections_", 3869291407, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1280, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_success_.delayType_", 3981958969, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1312, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_success_.delayTime_", 842025342, "float", 1316, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_success_.delayMaxTime_", 2198584212, "float", 1320, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_big_fish_success_.pinName_", 2894893680, "Base.String", 1344, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_big_fish_success_.name_", 2184475803, "Base.String", 1360, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_big_fish_success_.connections_", 1332591923, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1376, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_big_fish_success_.delayType_", 3645299037, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1408, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_big_fish_success_.delayTime_", 2071402922, "float", 1412, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_big_fish_success_.delayMaxTime_", 2563767024, "float", 1416, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_failure_.pinName_", 3309151109, "Base.String", 1440, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_failure_.name_", 1698192704, "Base.String", 1456, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_failure_.connections_", 2396015854, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1472, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_failure_.delayType_", 2939009628, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1504, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_failure_.delayTime_", 4090873807, "float", 1508, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bite_qte_failure_.delayMaxTime_", 1979722967, "float", 1512, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("jump_qte_success_.pinName_", 2671322682, "Base.String", 1536, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("jump_qte_success_.name_", 3320196933, "Base.String", 1552, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("jump_qte_success_.connections_", 2497123677, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1568, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("jump_qte_success_.delayType_", 1139195927, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1600, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("jump_qte_success_.delayTime_", 3018605780, "float", 1604, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("jump_qte_success_.delayMaxTime_", 521634862, "float", 1608, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("jump_qte_big_fish_success_.pinName_", 3530394066, "Base.String", 1632, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("jump_qte_big_fish_success_.name_", 1232172365, "Base.String", 1648, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("jump_qte_big_fish_success_.connections_", 1337471669, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1664, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("jump_qte_big_fish_success_.delayType_", 1138926463, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1696, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("jump_qte_big_fish_success_.delayTime_", 1063784556, "float", 1700, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("jump_qte_big_fish_success_.delayMaxTime_", 2246336470, "float", 1704, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("battle_started_.pinName_", 3532580697, "Base.String", 1728, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("battle_started_.name_", 859440484, "Base.String", 1744, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("battle_started_.connections_", 3917805594, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1760, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("battle_started_.delayType_", 341245512, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1792, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("battle_started_.delayTime_", 2987629315, "float", 1796, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("battle_started_.delayMaxTime_", 3882894459, "float", 1800, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("battle_few_line_hp_.pinName_", 3940146074, "Base.String", 1824, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("battle_few_line_hp_.name_", 12769381, "Base.String", 1840, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("battle_few_line_hp_.connections_", 1042337277, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1856, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("battle_few_line_hp_.delayType_", 988577015, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1888, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("battle_few_line_hp_.delayTime_", 720554804, "float", 1892, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("battle_few_line_hp_.delayMaxTime_", 2747169102, "float", 1896, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_small_fish_.pinName_", 4083921082, "Base.String", 1920, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_small_fish_.name_", 3971792581, "Base.String", 1936, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_small_fish_.connections_", 1783089117, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1952, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("get_small_fish_.delayType_", 4154625687, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1984, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_small_fish_.delayTime_", 1739068244, "float", 1988, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_small_fish_.delayMaxTime_", 2675999662, "float", 1992, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_normal_fish_.pinName_", 1856916134, "Base.String", 2016, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_normal_fish_.name_", 2815528433, "Base.String", 2032, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_normal_fish_.connections_", 1139648369, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2048, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("get_normal_fish_.delayType_", 1667553931, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2080, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_normal_fish_.delayTime_", 2545949952, "float", 2084, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_normal_fish_.delayMaxTime_", 388391946, "float", 2088, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_big_fish_.pinName_", 4159466853, "Base.String", 2112, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_big_fish_.name_", 2578713440, "Base.String", 2128, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_big_fish_.connections_", 1042535310, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2144, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("get_big_fish_.delayType_", 2337539260, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2176, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_big_fish_.delayTime_", 1383444911, "float", 2180, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_big_fish_.delayMaxTime_", 3918286199, "float", 2184, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_very_big_fish_.pinName_", 384634412, "Base.String", 2208, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_very_big_fish_.name_", 1843448983, "Base.String", 2224, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_very_big_fish_.connections_", 2679018359, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2240, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("get_very_big_fish_.delayType_", 1664324337, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2272, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_very_big_fish_.delayTime_", 3037431590, "float", 2276, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_very_big_fish_.delayMaxTime_", 4099223948, "float", 2280, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_small_fish_ui_.pinName_", 690061769, "Base.String", 2304, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_small_fish_ui_.name_", 3381685204, "Base.String", 2320, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_small_fish_ui_.connections_", 1160639530, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2336, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("get_small_fish_ui_.delayType_", 1791553944, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2368, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_small_fish_ui_.delayTime_", 640107219, "float", 2372, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_small_fish_ui_.delayMaxTime_", 1439602635, "float", 2376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_normal_fish_ui_.pinName_", 2680527965, "Base.String", 2400, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_normal_fish_ui_.name_", 415066152, "Base.String", 2416, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_normal_fish_ui_.connections_", 854148710, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2432, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("get_normal_fish_ui_.delayType_", 626229476, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2464, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_normal_fish_ui_.delayTime_", 483194631, "float", 2468, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_normal_fish_ui_.delayMaxTime_", 2462065439, "float", 2472, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_big_fish_ui_.pinName_", 2688002088, "Base.String", 2496, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_big_fish_ui_.name_", 1851200451, "Base.String", 2512, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_big_fish_ui_.connections_", 2739136971, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2528, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("get_big_fish_ui_.delayType_", 3587447173, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2560, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_big_fish_ui_.delayTime_", 2400153090, "float", 2564, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_big_fish_ui_.delayMaxTime_", 648123672, "float", 2568, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_very_big_fish_ui_.pinName_", 389287019, "Base.String", 2592, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_very_big_fish_ui_.name_", 2818430694, "Base.String", 2608, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_very_big_fish_ui_.connections_", 1339657372, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2624, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("get_very_big_fish_ui_.delayType_", 4040520658, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2656, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_very_big_fish_ui_.delayTime_", 1551026645, "float", 2660, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("get_very_big_fish_ui_.delayMaxTime_", 4242574065, "float", 2664, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("onLineTensionUp_.pinName_", 258677601, "Base.String", 2688, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("onLineTensionUp_.name_", 151841308, "Base.String", 2704, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("onLineTensionUp_.connections_", 673115650, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2720, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("onLineTensionUp_.delayType_", 265160608, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2752, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("onLineTensionUp_.delayTime_", 4261214219, "float", 2756, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("onLineTensionUp_.delayMaxTime_", 2299728691, "float", 2760, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("onTackleMenuOpened_.pinName_", 1702486612, "Base.String", 2784, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("onTackleMenuOpened_.name_", 2703670703, "Base.String", 2800, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("onTackleMenuOpened_.connections_", 2418589375, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2816, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("onTackleMenuOpened_.delayType_", 828421993, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2848, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("onTackleMenuOpened_.delayTime_", 2899140590, "float", 2852, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("onTackleMenuOpened_.delayMaxTime_", 722607620, "float", 2856, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("first_fishing_", 2708624825, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 280, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cast_started_", 511102069, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 376, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cast_prepare_finished_", 1189869950, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 472, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cast_failed_", 2887210835, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 568, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cast_evening_", 2740113778, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 664, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cast_few_line_hp_", 693956068, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 760, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lure_splash_down_", 274553281, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 856, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("line_break_", 3220532008, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 952, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("jump_qte_failure_and_keep_lure_", 274904831, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1048, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bite_qte_decided_", 1881165800, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1144, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bite_qte_success_", 3898862357, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1240, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bite_qte_big_fish_success_", 2828085513, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1336, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bite_qte_failure_", 3051582626, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1432, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("jump_qte_success_", 3986399087, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1528, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("jump_qte_big_fish_success_", 1687505719, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1624, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("battle_started_", 4212456286, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1720, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("battle_few_line_hp_", 2225543375, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1816, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("get_small_fish_", 2698873583, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1912, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("get_normal_fish_", 980766115, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2008, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("get_big_fish_", 538149378, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2104, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("get_very_big_fish_", 705273229, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2200, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("get_small_fish_ui_", 3845033646, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2296, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("get_normal_fish_ui_", 3124128906, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2392, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("get_big_fish_ui_", 328992433, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2488, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("get_very_big_fish_ui_", 4111911204, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2584, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("onLineTensionUp_", 1756078582, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2680, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("onTackleMenuOpened_", 1624803013, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2776, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceEventFishingScriptEvent();
        }
		
    }
}