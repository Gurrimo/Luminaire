using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Ecology
{
    public partial class SequenceActionEcologyBase : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int prefixType_;
		public uint id_;
		public uint teamId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionEcologyBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Ecology.SequenceActionEcologyBase", 0, Black.Sequence.Action.Ecology.SequenceActionEcologyBase.ObjectType, Construct, properties, 0, 192);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Ecology.SequenceActionEcologyBase", base.GetFieldProperties(), 1297533890, 1366532009);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("prefixType_", 3044571194, "Black.Sequence.Action.Ecology.SequenceActionEcologyBase.DATA_FIXID_PREFIX", 176, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("id_", 2899315373, "SQEX.Ebony.Std.Fixid", 180, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("teamId_", 1186824794, "SQEX.Ebony.Std.Fixid", 184, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionEcologyBase();
        }
		
    }
}