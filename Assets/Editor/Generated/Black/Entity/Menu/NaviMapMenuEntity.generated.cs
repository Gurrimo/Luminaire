using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class NaviMapMenuEntity : Black.Entity.Menu.SwfEntryEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float timeMorning_;
		public float timeNoon_;
		public float timeEvening_;
		public float timeNight_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NaviMapMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.NaviMapMenuEntity", 0, Black.Entity.Menu.NaviMapMenuEntity.ObjectType, Construct, properties, 0, 2304);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.NaviMapMenuEntity", base.GetFieldProperties(), 713013883, -1302053610);
            
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entitySearchLabelId_", 3840219358, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("menuFixID_", 107051205, "SQEX.Ebony.Std.Fixid", 256, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("swfEntryPackagePath_", 3946372377, "Ebony.Base.String", 272, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("timeMorning_", 1913114393, "float", 496, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeNoon_", 1078946483, "float", 500, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeEvening_", 2057905941, "float", 504, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeNight_", 3786577743, "float", 508, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new NaviMapMenuEntity();
        }
		
    }
}