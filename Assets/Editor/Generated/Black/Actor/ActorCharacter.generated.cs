using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor
{
    public partial class ActorCharacter : Black.Actor.ActorControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorCharacter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.ActorCharacter", 0, Black.Actor.ActorCharacter.ObjectType, null, properties, 60, 9184);
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

            fieldProperties = new PropertyContainer("Black.Actor.ActorCharacter", base.GetFieldProperties(), -1296431993, -1538686833);
            
			fieldProperties.AddIndirectlyProperty(new Property("baseScale_", 776470431, "float", 576, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("worldPosition_", 1278966829, "Black.Actor.Actor.DoubleVector4", 584, 32, 1, Property.PrimitiveType.DoubleVector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Black.Actor.Actor.VectorA", 624, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("scaling_", 3325430311, "Black.Actor.Actor.VectorA", 640, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("constraintInfo_", 739900775, "Black.Actor.Actor.ConstraintInfo", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("radius_", 2286360452, "float", 7000, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("height_", 2527956647, "float", 7004, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("eyeHeight_", 2345981490, "float", 7008, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("eyeHeightRatio_", 966492061, "float", 7012, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			
			
			return fieldProperties;
        }

		
    }
}