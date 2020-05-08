using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionSetVisibleSwfEntityBundle : Black.Sequence.Action.Menu.SequenceActionSwfEntityHierarchyBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin swfEntityInput_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueInput_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin visibleListInput_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offsetInput_;
		public int visibleMethod_;
		public bool focusOrNormal_FocusBool_;
		public bool focusOrNormal_NormalBool_;
		public bool index_0Bool_;
		public bool index_1Bool_;
		public bool index_2Bool_;
		public bool index_3Bool_;
		public bool index_4Bool_;
		public bool index_5Bool_;
		public bool index_6Bool_;
		public bool index_7Bool_;
		public bool index_8Bool_;
		public bool index_9Bool_;
		public bool index_10Bool_;
		public bool compare_SmallBool_;
		public bool compare_EqualBool_;
		public bool compare_BigBool_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVisibleSwfEntityBundle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionSetVisibleSwfEntityBundle", 0, Black.Sequence.Action.Menu.SequenceActionSetVisibleSwfEntityBundle.ObjectType, Construct, properties, 0, 896);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionSetVisibleSwfEntityBundle", base.GetFieldProperties(), -723190041, -1070119838);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("mcInstancePathPin_", 1160557025, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 192, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("mcInstancePathPin_.pinName_", 3471311288, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("mcInstancePathPin_.name_", 457596691, "Base.String", 216, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("mcInstancePathPin_.connections_", 914993659, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 232, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("mcInstancePathPin_.pinValueType_", 1321962310, "Base.String", 264, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("mcInstancePath_", 3085499294, "Ebony.Base.String", 280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inPin_.pinName_", 4221217977, "Base.String", 320, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inPin_.name_", 875469060, "Base.String", 336, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inPin_.connections_", 2296145594, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 352, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("inPin_.delayType_", 3644047656, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 384, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inPin_.delayTime_", 2419921635, "float", 388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inPin_.delayMaxTime_", 3738510619, "float", 392, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.pinName_", 1767361694, "Base.String", 416, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.name_", 2948420441, "Base.String", 432, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.connections_", 78281129, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 448, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.delayType_", 2315115539, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 480, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.delayTime_", 2421045752, "float", 484, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.delayMaxTime_", 3973394610, "float", 488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("swfEntityInput_.pinName_", 77426036, "Base.String", 512, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("swfEntityInput_.name_", 3148774799, "Base.String", 528, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("swfEntityInput_.connections_", 2228389663, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 544, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("swfEntityInput_.pinValueType_", 3729535634, "Base.String", 576, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueInput_.pinName_", 2578831990, "Base.String", 600, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueInput_.name_", 4253135937, "Base.String", 616, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueInput_.connections_", 2204950689, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 632, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("valueInput_.pinValueType_", 171865272, "Base.String", 664, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("visibleListInput_.pinName_", 674610539, "Base.String", 688, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("visibleListInput_.name_", 2986559974, "Base.String", 704, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("visibleListInput_.connections_", 1199918492, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 720, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("visibleListInput_.pinValueType_", 2661010495, "Base.String", 752, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("offsetInput_.pinName_", 258202230, "Base.String", 776, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("offsetInput_.name_", 2748036161, "Base.String", 792, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("offsetInput_.connections_", 637198497, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 808, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("offsetInput_.pinValueType_", 4022891704, "Base.String", 840, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("inPin_", 3408135614, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 312, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPin_", 2732252299, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 408, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfEntityInput_", 531204709, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 504, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueInput_", 1426429715, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 592, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("visibleListInput_", 1834128420, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 680, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetInput_", 1142920979, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 768, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("visibleMethod_", 703761185, "Black.Sequence.Action.Menu.SequenceActionSetVisibleSwfEntityBundle.VisibleMethod", 856, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("focusOrNormal_FocusBool_", 3391988551, "bool", 860, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("focusOrNormal_NormalBool_", 187559154, "bool", 861, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_0Bool_", 622516665, "bool", 862, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_1Bool_", 4128221876, "bool", 863, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_2Bool_", 3107753787, "bool", 864, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_3Bool_", 92373614, "bool", 865, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_4Bool_", 2547650581, "bool", 866, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_5Bool_", 848402512, "bool", 867, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_6Bool_", 1149850551, "bool", 868, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_7Bool_", 804335658, "bool", 869, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_8Bool_", 3839094961, "bool", 870, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_9Bool_", 2729005068, "bool", 871, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("index_10Bool_", 436815878, "bool", 872, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("compare_SmallBool_", 32273797, "bool", 873, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("compare_EqualBool_", 2156982576, "bool", 874, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("compare_BigBool_", 1622507238, "bool", 875, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionSetVisibleSwfEntityBundle();
        }
		
    }
}