using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Control
{
    public partial class SequenceActionControlSwitchFixid : SQEX.Ebony.Framework.Sequence.Control.SequenceControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin value_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin1_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin3_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin4_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin5_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin6_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin7_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin8_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputDefaultPin_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData fixid1_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData fixid2_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData fixid3_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData fixid4_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData fixid5_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData fixid6_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData fixid7_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData fixid8_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionControlSwitchFixid();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Control.SequenceActionControlSwitchFixid", 0, Black.Sequence.Action.Control.SequenceActionControlSwitchFixid.ObjectType, Construct, properties, 0, 1392);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Control.SequenceActionControlSwitchFixid", base.GetFieldProperties(), -343651378, -617229844);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("in_.pinName_", 3330161590, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.name_", 192292993, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.connections_", 490033121, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayType_", 261766523, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 248, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayTime_", 1689218608, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayMaxTime_", 1529341114, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("value_.pinName_", 2087686874, "Base.String", 280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("value_.name_", 589318053, "Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("value_.connections_", 829233469, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 312, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("value_.pinValueType_", 3826302252, "Base.String", 344, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin1_.pinName_", 3840578057, "Base.String", 368, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin1_.name_", 1571756820, "Base.String", 384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin1_.connections_", 2564850026, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 400, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin1_.delayType_", 1673337304, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 432, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin1_.delayTime_", 946244883, "float", 436, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin1_.delayMaxTime_", 3356122891, "float", 440, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin2_.pinName_", 3835015824, "Base.String", 464, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin2_.name_", 1260203771, "Base.String", 480, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin2_.connections_", 1514737555, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 496, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin2_.delayType_", 3037162365, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 528, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin2_.delayTime_", 3186344010, "float", 532, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin2_.delayMaxTime_", 3532913104, "float", 536, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin3_.pinName_", 2108372239, "Base.String", 560, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin3_.name_", 51930346, "Base.String", 576, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin3_.connections_", 2102895720, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 592, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin3_.delayType_", 3559438190, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 624, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin3_.delayTime_", 1980050217, "float", 628, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin3_.delayMaxTime_", 428848789, "float", 632, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin4_.pinName_", 313276206, "Base.String", 656, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin4_.name_", 1630177705, "Base.String", 672, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin4_.connections_", 1564181273, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 688, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin4_.delayType_", 1682814659, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 720, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin4_.delayTime_", 1339094120, "float", 724, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin4_.delayMaxTime_", 2802710946, "float", 728, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin5_.pinName_", 2050397781, "Base.String", 752, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin5_.name_", 929498832, "Base.String", 768, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin5_.connections_", 302849950, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 784, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin5_.delayType_", 528860492, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 816, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin5_.delayTime_", 24520063, "float", 820, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin5_.delayMaxTime_", 1534969095, "float", 824, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin6_.pinName_", 44210540, "Base.String", 848, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin6_.name_", 3391635415, "Base.String", 864, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin6_.connections_", 2463274423, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 880, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin6_.delayType_", 2846700593, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 912, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin6_.delayTime_", 349401190, "float", 916, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin6_.delayMaxTime_", 3817562572, "float", 920, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin7_.pinName_", 3906060203, "Base.String", 944, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin7_.name_", 1299459622, "Base.String", 960, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin7_.connections_", 3022888412, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 976, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin7_.delayType_", 2539483154, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1008, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin7_.delayTime_", 515920149, "float", 1012, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin7_.delayMaxTime_", 2589384241, "float", 1016, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin8_.pinName_", 3873859546, "Base.String", 1040, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin8_.name_", 1781180069, "Base.String", 1056, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin8_.connections_", 498875965, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1072, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin8_.delayType_", 2963702071, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1104, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin8_.delayTime_", 3120034164, "float", 1108, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputPin8_.delayMaxTime_", 268354702, "float", 1112, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputDefaultPin_.pinName_", 3250213191, "Base.String", 1136, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputDefaultPin_.name_", 593974386, "Base.String", 1152, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputDefaultPin_.connections_", 1266245344, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1168, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputDefaultPin_.delayType_", 3129342198, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1200, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputDefaultPin_.delayTime_", 3893221249, "float", 1204, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicTriggerOutputDefaultPin_.delayMaxTime_", 3257553245, "float", 1208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fixid1_.value_", 2519013055, "SQEX.Ebony.Std.Fixid", 1232, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fixid2_.value_", 3865904954, "SQEX.Ebony.Std.Fixid", 1248, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fixid3_.value_", 1410106229, "SQEX.Ebony.Std.Fixid", 1264, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fixid4_.value_", 1630324304, "SQEX.Ebony.Std.Fixid", 1280, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fixid5_.value_", 3135786987, "SQEX.Ebony.Std.Fixid", 1296, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fixid6_.value_", 4166411686, "SQEX.Ebony.Std.Fixid", 1312, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fixid7_.value_", 3368140241, "SQEX.Ebony.Std.Fixid", 1328, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fixid8_.value_", 3356246732, "SQEX.Ebony.Std.Fixid", 1344, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("value_", 273093519, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicTriggerOutputPin1_", 1255203182, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 360, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicTriggerOutputPin2_", 1254761897, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 456, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicTriggerOutputPin3_", 1254908992, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 552, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicTriggerOutputPin4_", 2328132155, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 648, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicTriggerOutputPin5_", 2328279250, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 744, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicTriggerOutputPin6_", 1254070349, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 840, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicTriggerOutputPin7_", 1254217444, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 936, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicTriggerOutputPin8_", 1256336015, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1032, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicTriggerOutputDefaultPin_", 2305011272, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1128, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fixid1_", 2276807257, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 1224, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fixid2_", 2277248542, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 1240, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fixid3_", 2277101447, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 1256, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fixid4_", 1202598356, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 1272, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fixid5_", 2276115709, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 1288, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fixid6_", 2276660162, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 1304, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fixid7_", 1202745451, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 1320, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fixid8_", 2278234280, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 1336, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionControlSwitchFixid();
        }
		
    }
}