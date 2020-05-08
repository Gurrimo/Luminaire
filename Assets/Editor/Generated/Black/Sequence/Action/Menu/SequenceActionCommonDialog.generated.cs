using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionCommonDialog : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin openIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin closeIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin requestLoadIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin unloadIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin imageIdIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin captionTextIdPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin openedOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin closedOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selectedYesOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selectedNoOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selected1OPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selected2OPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selected3OPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selected4OPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selected5OPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin canceledOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin loadFinishedOPin_;
		public float disableCloseSeconds_;
		public bool enablePause_;
		public bool disableCancelButton_;
		public int dialogType_;
		public uint captionTextId_;
		public bool defaultSelectNo_;
		public uint select01TextId_;
		public uint select02TextId_;
		public uint select03TextId_;
		public uint select04TextId_;
		public uint select05TextId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin select01TextPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin select02TextPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin select03TextPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin select04TextPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin select05TextPin_;
		public int initialIndex_;
		public bool isAutoUnloadRequest_;
		public bool closeOnlyIfOpener_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCommonDialog();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionCommonDialog", 0, Black.Sequence.Action.Menu.SequenceActionCommonDialog.ObjectType, Construct, properties, 0, 2376);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionCommonDialog", base.GetFieldProperties(), -1335665172, 1954699063);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("openIPin_.pinName_", 839401151, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("openIPin_.name_", 3075482330, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("openIPin_.connections_", 1398374264, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("openIPin_.delayType_", 78675390, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 248, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("openIPin_.delayTime_", 2727381561, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("openIPin_.delayMaxTime_", 1169198501, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("closeIPin_.pinName_", 856530809, "Base.String", 280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("closeIPin_.name_", 227890628, "Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("closeIPin_.connections_", 1200687738, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 312, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("closeIPin_.delayType_", 3263717096, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 344, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("closeIPin_.delayTime_", 1615030435, "float", 348, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("closeIPin_.delayMaxTime_", 2907660763, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("requestLoadIPin_.pinName_", 183833172, "Base.String", 376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("requestLoadIPin_.name_", 4251602351, "Base.String", 392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("requestLoadIPin_.connections_", 505867967, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 408, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("requestLoadIPin_.delayType_", 633825129, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 440, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("requestLoadIPin_.delayTime_", 2704543726, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("requestLoadIPin_.delayMaxTime_", 2989993476, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("unloadIPin_.pinName_", 2788386460, "Base.String", 472, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("unloadIPin_.name_", 3092408071, "Base.String", 488, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("unloadIPin_.connections_", 2790630727, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 504, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("unloadIPin_.delayType_", 2646380993, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 536, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("unloadIPin_.delayTime_", 2803993014, "float", 540, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("unloadIPin_.delayMaxTime_", 1874067356, "float", 544, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("imageIdIPin_.pinName_", 1648068045, "Base.String", 568, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("imageIdIPin_.name_", 2641824856, "Base.String", 584, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("imageIdIPin_.connections_", 1061674486, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 600, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("imageIdIPin_.pinValueType_", 3481172637, "Base.String", 632, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("captionTextIdPin_.pinName_", 1650157402, "Base.String", 656, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("captionTextIdPin_.name_", 462058789, "Base.String", 672, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("captionTextIdPin_.connections_", 90289597, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 688, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("captionTextIdPin_.pinValueType_", 237181612, "Base.String", 720, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outOPin_.pinName_", 1405317967, "Base.String", 744, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outOPin_.name_", 905973034, "Base.String", 760, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outOPin_.connections_", 1748885416, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 776, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outOPin_.delayType_", 4113451438, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 808, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outOPin_.delayTime_", 2958417769, "float", 812, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outOPin_.delayMaxTime_", 4252974549, "float", 816, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("openedOPin_.pinName_", 875341440, "Base.String", 840, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("openedOPin_.name_", 4212951915, "Base.String", 856, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("openedOPin_.connections_", 2937815459, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 872, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("openedOPin_.delayType_", 3918248461, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 904, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("openedOPin_.delayTime_", 1433100698, "float", 908, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("openedOPin_.delayMaxTime_", 1578527712, "float", 912, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("closedOPin_.pinName_", 460763353, "Base.String", 936, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("closedOPin_.name_", 4226413028, "Base.String", 952, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("closedOPin_.connections_", 1837095322, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 968, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("closedOPin_.delayType_", 74425288, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1000, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("closedOPin_.delayTime_", 2720809091, "float", 1004, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("closedOPin_.delayMaxTime_", 727793915, "float", 1008, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selectedYesOPin_.pinName_", 1621536527, "Base.String", 1032, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selectedYesOPin_.name_", 1357157098, "Base.String", 1048, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selectedYesOPin_.connections_", 1796259432, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1064, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("selectedYesOPin_.delayType_", 3111240046, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1096, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selectedYesOPin_.delayTime_", 1531852073, "float", 1100, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selectedYesOPin_.delayMaxTime_", 1408476309, "float", 1104, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selectedNoOPin_.pinName_", 3495845083, "Base.String", 1128, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selectedNoOPin_.name_", 1791067414, "Base.String", 1144, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selectedNoOPin_.connections_", 57249836, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1160, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("selectedNoOPin_.delayType_", 2883986018, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1192, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selectedNoOPin_.delayTime_", 2379304933, "float", 1196, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selectedNoOPin_.delayMaxTime_", 36516801, "float", 1200, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected1OPin_.pinName_", 3904968975, "Base.String", 1224, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected1OPin_.name_", 533172458, "Base.String", 1240, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected1OPin_.connections_", 753387624, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1256, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("selected1OPin_.delayType_", 4140514158, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1288, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected1OPin_.delayTime_", 2561126185, "float", 1292, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected1OPin_.delayMaxTime_", 2037932693, "float", 1296, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected2OPin_.pinName_", 3419794758, "Base.String", 1320, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected2OPin_.name_", 2431407825, "Base.String", 1336, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected2OPin_.connections_", 943019473, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1352, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("selected2OPin_.delayType_", 3368133675, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1384, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected2OPin_.delayTime_", 1716216864, "float", 1388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected2OPin_.delayMaxTime_", 120821354, "float", 1392, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected3OPin_.pinName_", 3123373273, "Base.String", 1416, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected3OPin_.name_", 506596836, "Base.String", 1432, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected3OPin_.connections_", 1078152602, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1448, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("selected3OPin_.delayType_", 1696659400, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1480, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected3OPin_.delayTime_", 48075907, "float", 1484, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected3OPin_.delayMaxTime_", 4111523067, "float", 1488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected4OPin_.pinName_", 2778464160, "Base.String", 1512, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected4OPin_.name_", 1709617227, "Base.String", 1528, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected4OPin_.connections_", 320830083, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1544, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("selected4OPin_.delayType_", 1337743917, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1576, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected4OPin_.delayTime_", 1424588858, "float", 1580, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected4OPin_.delayMaxTime_", 3484505024, "float", 1584, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected5OPin_.pinName_", 2904985339, "Base.String", 1608, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected5OPin_.name_", 3070013942, "Base.String", 1624, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected5OPin_.connections_", 3632952332, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1640, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("selected5OPin_.delayType_", 2498962690, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1672, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected5OPin_.delayTime_", 4183393541, "float", 1676, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("selected5OPin_.delayMaxTime_", 2674975649, "float", 1680, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("canceledOPin_.pinName_", 2158201646, "Base.String", 1704, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("canceledOPin_.name_", 472384937, "Base.String", 1720, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("canceledOPin_.connections_", 4166260505, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1736, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("canceledOPin_.delayType_", 80161475, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1768, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("canceledOPin_.delayTime_", 4031408232, "float", 1772, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("canceledOPin_.delayMaxTime_", 3468621218, "float", 1776, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("loadFinishedOPin_.pinName_", 3334091751, "Base.String", 1800, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("loadFinishedOPin_.name_", 4061008594, "Base.String", 1816, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("loadFinishedOPin_.connections_", 855014976, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1832, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("loadFinishedOPin_.delayType_", 2805435670, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1864, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("loadFinishedOPin_.delayTime_", 997425185, "float", 1868, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("loadFinishedOPin_.delayMaxTime_", 3584747709, "float", 1872, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("select01TextPin_.pinName_", 3811800324, "Base.String", 1936, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("select01TextPin_.name_", 302377247, "Base.String", 1952, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("select01TextPin_.connections_", 1467939535, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1968, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("select01TextPin_.pinValueType_", 3489473890, "Base.String", 2000, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("select02TextPin_.pinName_", 1746496727, "Base.String", 2024, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("select02TextPin_.name_", 639930690, "Base.String", 2040, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("select02TextPin_.connections_", 2156108816, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2056, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("select02TextPin_.pinValueType_", 2460782155, "Base.String", 2088, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("select03TextPin_.pinName_", 1786814034, "Base.String", 2112, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("select03TextPin_.name_", 2290705101, "Base.String", 2128, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("select03TextPin_.connections_", 2701659957, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2144, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("select03TextPin_.pinValueType_", 1786973748, "Base.String", 2176, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("select04TextPin_.pinName_", 1424860573, "Base.String", 2200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("select04TextPin_.name_", 286569064, "Base.String", 2216, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("select04TextPin_.connections_", 2262555814, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2232, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("select04TextPin_.pinValueType_", 2755221933, "Base.String", 2264, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("select05TextPin_.pinName_", 2812592968, "Base.String", 2288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("select05TextPin_.name_", 105740067, "Base.String", 2304, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("select05TextPin_.connections_", 260381483, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2320, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("select05TextPin_.pinValueType_", 570439638, "Base.String", 2352, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("openIPin_", 1128097168, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("closeIPin_", 1685805310, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("requestLoadIPin_", 1555863237, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("unloadIPin_", 2263201757, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("imageIdIPin_", 3503864794, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 560, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("captionTextIdPin_", 3131903247, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 648, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outOPin_", 3584478464, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 736, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("openedOPin_", 3642562553, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 832, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("closedOPin_", 3921963998, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 928, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("selectedYesOPin_", 1018266176, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1024, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("selectedNoOPin_", 905011572, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1120, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("selected1OPin_", 1597501504, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1216, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("selected2OPin_", 1830674883, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1312, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("selected3OPin_", 3475793886, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1408, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("selected4OPin_", 4126044825, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1504, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("selected5OPin_", 2505325588, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1600, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("canceledOPin_", 1201985083, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1696, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("loadFinishedOPin_", 2339924456, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1792, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("disableCloseSeconds_", 3057605451, "float", 1888, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enablePause_", 759558965, "bool", 1892, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("disableCancelButton_", 3446458762, "bool", 1893, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("dialogType_", 1072466506, "Black.Sequence.Action.Menu.SequenceActionCommonDialog.DialogType", 1896, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("captionTextId_", 1670090420, "SQEX.Ebony.Std.Fixid", 1900, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("defaultSelectNo_", 2665910334, "bool", 1904, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("select01TextId_", 2218232617, "SQEX.Ebony.Std.Fixid", 1908, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("select02TextId_", 2264615630, "SQEX.Ebony.Std.Fixid", 1912, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("select03TextId_", 53991275, "SQEX.Ebony.Std.Fixid", 1916, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("select04TextId_", 3371164808, "SQEX.Ebony.Std.Fixid", 1920, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("select05TextId_", 2281557997, "SQEX.Ebony.Std.Fixid", 1924, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("select01TextPin_", 3417811669, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1928, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("select02TextPin_", 2282582008, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2016, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("select03TextPin_", 2617705655, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2104, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("select04TextPin_", 2812554826, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2192, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("select05TextPin_", 3077204945, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2280, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("initialIndex_", 410109010, "int", 2368, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("isAutoUnloadRequest_", 869869987, "bool", 2372, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("closeOnlyIfOpener_", 422197842, "bool", 2373, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionCommonDialog();
        }
		
    }
}