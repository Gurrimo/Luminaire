using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.AIMode
{
    public partial class SequenceActionExecAIModeWarpTo : Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rotateTarget_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin warpTarget_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionExecAIModeWarpTo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeWarpTo", 0, Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeWarpTo.ObjectType, null, properties, 0, 1424);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeWarpTo", base.GetFieldProperties(), 656274179, 1247309007);
            
			fieldProperties.AddProperty(new Property("rotateTarget_", 375096252, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1224, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("warpTarget_", 840263351, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1312, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}