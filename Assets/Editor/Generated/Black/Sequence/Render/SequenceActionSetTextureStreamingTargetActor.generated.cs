using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Render
{
    public partial class SequenceActionSetTextureStreamingTargetActor : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin set_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reset_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public bool ignoreMargin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetTextureStreamingTargetActor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Render.SequenceActionSetTextureStreamingTargetActor", 0, Black.Sequence.Render.SequenceActionSetTextureStreamingTargetActor.ObjectType, null, properties, 0, 576);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Render.SequenceActionSetTextureStreamingTargetActor", base.GetFieldProperties(), 5711970, -1993968882);
            
			fieldProperties.AddProperty(new Property("set_", 1265669588, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("reset_", 2999468877, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorPin_", 3381458010, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 464, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ignoreMargin_", 2574934318, "bool", 552, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}