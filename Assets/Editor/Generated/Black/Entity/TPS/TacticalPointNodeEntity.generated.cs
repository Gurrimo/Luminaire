using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.TPS
{
    public partial class TacticalPointNodeEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isDebugDraw_;
		public int groupId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TacticalPointNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.TPS.TacticalPointNodeEntity", 0, Black.Entity.TPS.TacticalPointNodeEntity.ObjectType, Construct, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.Entity.TPS.TacticalPointNodeEntity", base.GetFieldProperties(), -549509829, -463016054);
            
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entitySearchLabelId_", 3840219358, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("isDebugDraw_", 1140229391, "bool", 280, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupId_", 3701625562, "int", 284, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new TacticalPointNodeEntity();
        }
		
    }
}