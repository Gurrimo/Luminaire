using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Team
{
    public partial class SequenceActionGetTeamMemberActor : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin teamActorIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorListOPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetTeamMemberActor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Team.SequenceActionGetTeamMemberActor", 0, Black.Sequence.Action.Level.Team.SequenceActionGetTeamMemberActor.ObjectType, Construct, properties, 0, 352);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Team.SequenceActionGetTeamMemberActor", base.GetFieldProperties(), -88673385, 236735479);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("teamActorIPin_.pinName_", 4091148683, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("teamActorIPin_.name_", 1747721670, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("teamActorIPin_.connections_", 2953583484, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("teamActorIPin_.pinValueType_", 1361050655, "Base.String", 248, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actorListOPin_.pinName_", 2658540978, "Base.String", 272, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actorListOPin_.name_", 1031150445, "Base.String", 288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actorListOPin_.connections_", 1285905493, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 304, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("actorListOPin_.pinValueType_", 267962836, "Base.String", 336, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("teamActorIPin_", 3521554116, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorListOPin_", 3584238999, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 264, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionGetTeamMemberActor();
        }
		
    }
}