using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableSwfDefEntity : Black.Sequence.Variable.SequenceVariableSwfConnector
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValue_;
		public SQEX.Ebony.Framework.Entity.Entity entityPointer_;
		public bool isSetTextFieldConfig_;
		public bool isSetLabelSound_;
		public IList<Black.Entity.Data.Menu.SwfTextFieldConfigArrayItem> textFiledConfigList_= new List<Black.Entity.Data.Menu.SwfTextFieldConfigArrayItem>();
		public IList<Black.Entity.Data.Menu.SwfLabelAccessoryArrayItem> labelAccessoryList_= new List<Black.Entity.Data.Menu.SwfLabelAccessoryArrayItem>();
		public IList<Black.Entity.Data.Menu.SwfStringArrayItem> nameList_= new List<Black.Entity.Data.Menu.SwfStringArrayItem>();
		public IList<Black.Entity.Data.Menu.SwfFixidArrayItem> fixidList_= new List<Black.Entity.Data.Menu.SwfFixidArrayItem>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableSwfDefEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableSwfDefEntity", 0, Black.Sequence.Variable.SequenceVariableSwfDefEntity.ObjectType, null, properties, 0, 3624);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableSwfDefEntity", base.GetFieldProperties(), -101153703, -981291477);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("pinNum_", 2027049857, "int", 88, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin8_", 941291293, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 128, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin8_.pinName_", 508081500, "Base.String", 136, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin8_.name_", 386544071, "Base.String", 152, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin8_.connections_", 2428826887, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 168, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin8_.pinValueType_", 308465354, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin7_", 2017471670, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 216, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin7_.pinName_", 2291776673, "Base.String", 224, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin7_.name_", 944142940, "Base.String", 240, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin7_.connections_", 708304450, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 256, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin7_.pinValueType_", 1703381681, "Base.String", 288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin6_", 943556959, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 304, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin6_.pinName_", 4219199114, "Base.String", 312, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin6_.name_", 3023570005, "Base.String", 328, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin6_.connections_", 1959841997, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 344, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin6_.pinValueType_", 1824748636, "Base.String", 376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin5_", 943409864, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 392, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin5_.pinName_", 4056145607, "Base.String", 400, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin5_.name_", 832441586, "Base.String", 416, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin5_.connections_", 669926496, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 432, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin5_.pinValueType_", 460730875, "Base.String", 464, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin4_", 2017030385, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 480, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin4_.pinName_", 2084450280, "Base.String", 488, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin4_.name_", 2790467715, "Base.String", 504, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin4_.connections_", 728665739, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 520, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin4_.pinValueType_", 2604571702, "Base.String", 552, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin3_", 2016883290, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin3_.pinName_", 3989176653, "Base.String", 576, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin3_.name_", 3844984536, "Base.String", 592, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin3_.connections_", 3521024374, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 608, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin3_.pinValueType_", 314248477, "Base.String", 640, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin2_", 942968579, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 656, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin2_.pinName_", 3079821062, "Base.String", 664, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin2_.name_", 905739153, "Base.String", 680, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin2_.connections_", 3207254161, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 696, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin2_.pinValueType_", 897641160, "Base.String", 728, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin1_", 2016485932, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 744, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin1_.pinName_", 897700739, "Base.String", 752, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin1_.name_", 3012809262, "Base.String", 768, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin1_.connections_", 3831503732, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 784, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin1_.pinValueType_", 2319421223, "Base.String", 816, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin32_", 2195376514, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 832, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin32_.pinName_", 3434433509, "Base.String", 840, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin32_.name_", 2969900768, "Base.String", 856, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin32_.connections_", 205265422, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 872, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin32_.pinValueType_", 3097759141, "Base.String", 904, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin31_", 2194935229, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 920, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin31_.pinName_", 2643656700, "Base.String", 928, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin31_.name_", 118694823, "Base.String", 944, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin31_.connections_", 3673269607, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 960, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin31_.pinValueType_", 2557337770, "Base.String", 992, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin30_", 1121314708, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1008, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin30_.pinName_", 1541167483, "Base.String", 1016, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin30_.name_", 2283078006, "Base.String", 1032, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin30_.connections_", 4252133004, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1048, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin30_.pinValueType_", 3321755983, "Base.String", 1080, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin29_", 3598517886, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1096, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin29_.pinName_", 4173680633, "Base.String", 1104, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin29_.name_", 723359556, "Base.String", 1120, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin29_.connections_", 4080222970, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1136, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin29_.pinValueType_", 81233849, "Base.String", 1168, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin28_", 3598370791, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1184, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin28_.pinName_", 1648991074, "Base.String", 1192, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin28_.name_", 1678073053, "Base.String", 1208, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin28_.connections_", 490466789, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1224, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin28_.pinValueType_", 819757444, "Base.String", 1256, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin27_", 377612396, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin27_.pinName_", 2243751747, "Base.String", 1280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin27_.name_", 1124782830, "Base.String", 1296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin27_.connections_", 2775240756, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1312, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin27_.pinValueType_", 2626481127, "Base.String", 1344, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin26_", 377465301, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1360, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin26_.pinName_", 2521465348, "Base.String", 1368, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin26_.name_", 1888874527, "Base.String", 1384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin26_.connections_", 607770575, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1400, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin26_.pinValueType_", 438766690, "Base.String", 1432, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin25_", 377906586, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1448, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin25_.pinName_", 2989946381, "Base.String", 1456, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin25_.name_", 483224472, "Base.String", 1472, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin25_.connections_", 1838838326, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1488, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin25_.pinValueType_", 1682477789, "Base.String", 1520, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin24_", 3598959171, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1536, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin24_.pinName_", 3823765190, "Base.String", 1544, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin24_.name_", 3944690513, "Base.String", 1560, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin24_.connections_", 634488657, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1576, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin24_.pinValueType_", 2271853448, "Base.String", 1608, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin23_", 3599503624, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1624, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin23_.pinName_", 3530846599, "Base.String", 1632, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin23_.name_", 2031120818, "Base.String", 1648, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin23_.connections_", 1765901856, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1664, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin23_.pinValueType_", 4062153659, "Base.String", 1696, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin22_", 378053681, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1712, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin22_.pinName_", 2834376872, "Base.String", 1720, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin22_.name_", 3723674947, "Base.String", 1736, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin22_.connections_", 4097110603, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1752, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin22_.pinValueType_", 1393675510, "Base.String", 1784, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin21_", 378598134, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1800, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin21_.pinName_", 3839295073, "Base.String", 1808, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin21_.name_", 1396683548, "Base.String", 1824, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin21_.connections_", 3844473090, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1840, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin21_.pinValueType_", 4025141617, "Base.String", 1872, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin20_", 3599650719, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1888, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin20_.pinName_", 1078815050, "Base.String", 1896, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin20_.name_", 3942041621, "Base.String", 1912, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin20_.connections_", 3828897933, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1928, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin20_.pinValueType_", 2371833372, "Base.String", 1960, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin19_", 2829245627, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1976, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin19_.pinName_", 1789114030, "Base.String", 1984, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin19_.name_", 3020019753, "Base.String", 2000, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin19_.connections_", 118192793, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2016, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin19_.pinValueType_", 4153259552, "Base.String", 2048, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin18_", 2829392722, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2064, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin18_.pinName_", 3526235605, "Base.String", 2072, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin18_.name_", 2319340880, "Base.String", 2088, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin18_.connections_", 3151828766, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2104, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin18_.pinValueType_", 3382959957, "Base.String", 2136, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin17_", 2830922913, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2152, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin17_.pinName_", 3777506552, "Base.String", 2160, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin17_.name_", 2896343123, "Base.String", 2176, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin17_.connections_", 1648551739, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2192, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin17_.pinValueType_", 886661510, "Base.String", 2224, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin16_", 2831070008, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2240, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin16_.pinName_", 2291598743, "Base.String", 2248, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin16_.name_", 2861616130, "Base.String", 2264, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin16_.connections_", 836981712, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2280, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin16_.pinValueType_", 1910017035, "Base.String", 2312, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin15_", 1757449487, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2328, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin15_.pinName_", 1054730074, "Base.String", 2336, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin15_.name_", 3171022117, "Base.String", 2352, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin15_.connections_", 3347854781, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2368, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin15_.pinValueType_", 3070925484, "Base.String", 2400, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin14_", 1757596582, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2416, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin14_.pinName_", 1493617841, "Base.String", 2424, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin14_.name_", 1543016620, "Base.String", 2440, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin14_.connections_", 333038386, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2456, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin14_.pinValueType_", 2752283009, "Base.String", 2488, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin13_", 1756463749, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2504, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin13_.pinName_", 535487124, "Base.String", 2512, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin13_.name_", 2428038383, "Base.String", 2528, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin13_.connections_", 742899967, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2544, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin13_.pinValueType_", 2467147890, "Base.String", 2576, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin12_", 2830378460, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2592, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin12_.pinName_", 1398094291, "Base.String", 2600, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin12_.name_", 576912062, "Base.String", 2616, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin12_.connections_", 710826404, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2632, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin12_.pinValueType_", 2484087, "Base.String", 2664, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin11_", 2830525555, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2680, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin11_.pinName_", 4262562390, "Base.String", 2688, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin11_.name_", 1958345185, "Base.String", 2704, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin11_.connections_", 1320267073, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2720, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin11_.pinValueType_", 2887240536, "Base.String", 2752, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin10_", 1757008202, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2768, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin10_.pinName_", 2931252893, "Base.String", 2776, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin10_.name_", 3731176808, "Base.String", 2792, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin10_.connections_", 3989317030, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2808, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin10_.pinValueType_", 2855290029, "Base.String", 2840, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin9_", 2015206004, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2856, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin9_.pinName_", 3541596123, "Base.String", 2864, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin9_.name_", 1606678038, "Base.String", 2880, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin9_.connections_", 2724879148, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2896, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("dynamicVarInputPin9_.pinValueType_", 3901238639, "Base.String", 2928, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix1_", 1054310805, "Ebony.Base.String", 2944, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix2_", 1054855258, "Ebony.Base.String", 2960, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix3_", 4275907843, "Ebony.Base.String", 2976, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix4_", 4276349128, "Ebony.Base.String", 2992, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix5_", 1055002353, "Ebony.Base.String", 3008, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix6_", 1055443638, "Ebony.Base.String", 3024, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix7_", 4276496223, "Ebony.Base.String", 3040, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix8_", 1053177972, "Ebony.Base.String", 3056, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix9_", 4274230557, "Ebony.Base.String", 3072, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix10_", 3079881077, "Ebony.Base.String", 3088, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix11_", 3080028172, "Ebony.Base.String", 3104, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix12_", 4153942883, "Ebony.Base.String", 3120, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix13_", 3080322362, "Ebony.Base.String", 3136, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix14_", 3080469457, "Ebony.Base.String", 3152, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix15_", 4154384168, "Ebony.Base.String", 3168, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix16_", 4154531263, "Ebony.Base.String", 3184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix17_", 3081013910, "Ebony.Base.String", 3200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix18_", 4152265597, "Ebony.Base.String", 3216, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix19_", 3078748244, "Ebony.Base.String", 3232, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix20_", 4266041748, "Ebony.Base.String", 3248, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix21_", 1044694973, "Ebony.Base.String", 3264, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix22_", 1045136258, "Ebony.Base.String", 3280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix23_", 4266188843, "Ebony.Base.String", 3296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix24_", 4266733296, "Ebony.Base.String", 3312, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix25_", 1045283353, "Ebony.Base.String", 3328, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix26_", 1045827806, "Ebony.Base.String", 3344, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix27_", 1045680711, "Ebony.Base.String", 3360, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix28_", 4267321676, "Ebony.Base.String", 3376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix29_", 4267174581, "Ebony.Base.String", 3392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix30_", 2449410463, "Ebony.Base.String", 3408, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix31_", 3523325174, "Ebony.Base.String", 3424, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("prefix32_", 3522780721, "Ebony.Base.String", 3440, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValue_.pinName_", 1626062440, "Base.String", 3464, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValue_.name_", 229917699, "Base.String", 3480, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outValue_.connections_", 2399569163, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 3496, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outValue_.pinValueType_", 3816269750, "Base.String", 3528, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("outValue_", 2704623729, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 3456, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("entityPointer_", 3527687820, "SQEX.Ebony.Framework.Entity.Entity", 3544, 8, 1, Property.PrimitiveType.Pointer, 0, (char)1));
			fieldProperties.AddProperty(new Property("isSetTextFieldConfig_", 2984682235, "bool", 3552, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isSetLabelSound_", 2439029007, "bool", 3553, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("textFiledConfigList_", 3885649187, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.Menu.SwfTextFieldConfigArrayItem* >", 3560, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("labelAccessoryList_", 2486815510, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.Menu.SwfLabelAccessoryArrayItem* >", 3576, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("nameList_", 1377118711, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.Menu.SwfStringArrayItem* >", 3592, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("fixidList_", 4122648698, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.Menu.SwfFixidArrayItem* >", 3608, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			
			
			return fieldProperties;
        }

		
    }
}