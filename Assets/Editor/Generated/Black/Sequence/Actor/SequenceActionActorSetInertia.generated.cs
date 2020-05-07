using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorSetInertia : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool inertiaEnabled_;
		public float groundDynamicFriction_;
		public float airResistance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorSetInertia();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorSetInertia", 0, Black.Sequence.Actor.SequenceActionActorSetInertia.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorSetInertia", base.GetFieldProperties(), -2111259632, 2099625350);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actor_", 3434601855, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 280, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inertiaEnabled_", 1964925983, "bool", 464, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundDynamicFriction_", 3833903174, "float", 468, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("airResistance_", 741352331, "float", 472, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}