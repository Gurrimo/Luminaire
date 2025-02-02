//----------------------
// <auto-generated>
// This file was automatically generated. Any changes to it will be lost if and when the file is regenerated.
// </auto-generated>
//----------------------
#pragma warning disable

using System;
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;
using CodeDom = System.CodeDom;

namespace Black.Sequence.MultiPlayer
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class SequenceMultiPlayerEventMonitoringLobby : Black.Sequence.MultiPlayer.SequenceMultiPlayerSyncEventBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enable_= new SQEX.Ebony.Framework.Node.GraphTriggerInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disable_= new SQEX.Ebony.Framework.Node.GraphTriggerInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin progress1_= new SQEX.Ebony.Framework.Node.GraphTriggerOutputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin progress2_= new SQEX.Ebony.Framework.Node.GraphTriggerOutputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin progress3_= new SQEX.Ebony.Framework.Node.GraphTriggerOutputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin progress4_= new SQEX.Ebony.Framework.Node.GraphTriggerOutputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin errorOutputPin_= new SQEX.Ebony.Framework.Node.GraphTriggerOutputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableOutputPin remainTimeVarOut1Pin_= new SQEX.Ebony.Framework.Node.GraphVariableOutputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableOutputPin remainTimeVarOut2Pin_= new SQEX.Ebony.Framework.Node.GraphVariableOutputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableOutputPin remainTimeVarOut3Pin_= new SQEX.Ebony.Framework.Node.GraphVariableOutputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableOutputPin remainTimeVarOut4Pin_= new SQEX.Ebony.Framework.Node.GraphVariableOutputPin();
		public float checkIntervalTime_;
		public float progressTime1_;
		public float progressTime2_;
		public float progressTime3_;
		public float progressTime4_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerEventMonitoringLobby();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerEventMonitoringLobby", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerEventMonitoringLobby.ObjectType, Construct, properties, 0, 1384);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerEventMonitoringLobby", base.GetFieldProperties(), -1025441981, -790432683);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("wakeUp_", 1545670293, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("wakeUp_.pinName_", 3985577540, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("wakeUp_.name_", 228058719, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("wakeUp_.connections_", 4265741839, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("wakeUp_.delayType_", 3004831161, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 248, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("wakeUp_.delayTime_", 4159864830, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("wakeUp_.delayMaxTime_", 906834708, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("options_", 1990430094, "Black.Sequence.MultiPlayer.SequenceMultiPlayerSyncEventBase.sendOption", 272, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("forCreateOnlyFixid_", 1127113041, "SQEX.Ebony.Std.Fixid", 276, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isOutputLog_", 3733482875, "bool", 280, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enable_.pinName_", 4270245062, "Base.String", 304, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enable_.name_", 3233852753, "Base.String", 320, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enable_.connections_", 620504401, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 336, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("enable_.delayType_", 2298283947, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 368, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enable_.delayTime_", 646367136, "float", 372, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enable_.delayMaxTime_", 1143749866, "float", 376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("disable_.pinName_", 1281388507, "Base.String", 400, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("disable_.name_", 2292768278, "Base.String", 416, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("disable_.connections_", 104452908, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 432, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("disable_.delayType_", 2882399586, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 464, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("disable_.delayTime_", 2377718501, "float", 468, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("disable_.delayMaxTime_", 1879485633, "float", 472, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress1_.pinName_", 1696618425, "Base.String", 496, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress1_.name_", 3469326852, "Base.String", 512, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress1_.connections_", 3553739194, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 528, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("progress1_.delayType_", 713352232, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 560, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress1_.delayTime_", 3784193507, "float", 564, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress1_.delayMaxTime_", 3742590491, "float", 568, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress2_.pinName_", 2304886656, "Base.String", 592, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress2_.name_", 3257290347, "Base.String", 608, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress2_.connections_", 381792931, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 624, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("progress2_.delayType_", 1880113933, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 656, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress2_.delayTime_", 3689933466, "float", 660, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress2_.delayMaxTime_", 2293599968, "float", 664, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress3_.pinName_", 46237183, "Base.String", 688, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress3_.name_", 3914582810, "Base.String", 704, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress3_.connections_", 2048347064, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 720, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("progress3_.delayType_", 3901783038, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 752, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress3_.delayTime_", 1872641145, "float", 756, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress3_.delayMaxTime_", 1941968357, "float", 760, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress4_.pinName_", 3859389854, "Base.String", 784, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress4_.name_", 3063883353, "Base.String", 800, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress4_.connections_", 4209531561, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 816, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("progress4_.delayType_", 243701011, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 848, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress4_.delayTime_", 349631224, "float", 852, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("progress4_.delayMaxTime_", 2420007858, "float", 856, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("errorOutputPin_.pinName_", 2046827223, "Base.String", 880, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("errorOutputPin_.name_", 763222850, "Base.String", 896, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("errorOutputPin_.connections_", 1571236368, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 912, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("errorOutputPin_.delayType_", 2666203878, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 944, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("errorOutputPin_.delayTime_", 371399217, "float", 948, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("errorOutputPin_.delayMaxTime_", 255183565, "float", 952, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("remainTimeVarOut1Pin_.pinName_", 956003669, "Base.String", 976, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("remainTimeVarOut1Pin_.name_", 3054191568, "Base.String", 992, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("remainTimeVarOut1Pin_.connections_", 2214653598, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1008, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("remainTimeVarOut1Pin_.pinValueType_", 1511005653, "Base.String", 1040, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("remainTimeVarOut2Pin_.pinName_", 471702670, "Base.String", 1064, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("remainTimeVarOut2Pin_.name_", 3122047177, "Base.String", 1080, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("remainTimeVarOut2Pin_.connections_", 41822265, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1096, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("remainTimeVarOut2Pin_.pinValueType_", 2749830592, "Base.String", 1128, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("remainTimeVarOut3Pin_.pinName_", 2851020387, "Base.String", 1152, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("remainTimeVarOut3Pin_.name_", 4252590926, "Base.String", 1168, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("remainTimeVarOut3Pin_.connections_", 1304065428, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1184, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("remainTimeVarOut3Pin_.pinValueType_", 3471071431, "Base.String", 1216, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("remainTimeVarOut4Pin_.pinName_", 3824014948, "Base.String", 1240, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("remainTimeVarOut4Pin_.name_", 2009320639, "Base.String", 1256, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("remainTimeVarOut4Pin_.connections_", 496689391, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1272, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("remainTimeVarOut4Pin_.pinValueType_", 3084377346, "Base.String", 1304, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("enable_", 3925052483, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 296, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("disable_", 1760805492, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 392, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("progress1_", 934964926, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 488, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("progress2_", 934523641, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 584, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("progress3_", 2008438352, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 680, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("progress4_", 2007893899, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 776, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("errorOutputPin_", 2215086584, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 872, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("remainTimeVarOut1Pin_", 3066961362, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 968, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("remainTimeVarOut2Pin_", 2244172699, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1056, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("remainTimeVarOut3Pin_", 937592716, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1144, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("remainTimeVarOut4Pin_", 3908671285, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1232, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkIntervalTime_", 2180604048, "float", 1320, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("progressTime1_", 517253199, "float", 1324, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("progressTime2_", 1590770552, "float", 1328, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("progressTime3_", 1590623457, "float", 1332, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("progressTime4_", 516708746, "float", 1336, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceMultiPlayerEventMonitoringLobby();
        }
		
    }
}