using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.RoutePoint
{
    public partial class RoutePoint : Black.Actor.Node.ActorNodePoint
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new RoutePoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.RoutePoint.RoutePoint", 0, Black.AI.RoutePoint.RoutePoint.ObjectType, Construct, properties, 0, 1072);
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

            fieldProperties = new PropertyContainer("Black.AI.RoutePoint.RoutePoint", base.GetFieldProperties(), 1622111573, -774833011);
            
			fieldProperties.AddIndirectlyProperty(new Property("baseScale_", 776470431, "float", 576, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("worldPosition_", 1278966829, "Black.Actor.Actor.DoubleVector4", 584, 32, 1, Property.PrimitiveType.DoubleVector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Black.Actor.Actor.VectorA", 624, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("scaling_", 3325430311, "Black.Actor.Actor.VectorA", 640, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("constraintInfo_", 739900775, "Black.Actor.Actor.ConstraintInfo", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new RoutePoint();
        }
		
    }
}