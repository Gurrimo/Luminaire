using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.TPS.FilterNodeEntities
{
    public partial class NearAmbientRegionFilterNodeEntity : Black.Entity.TPS.FilterDescriptorNodeEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float distance_;
		public int subject_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NearAmbientRegionFilterNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.TPS.FilterNodeEntities.NearAmbientRegionFilterNodeEntity", 0, Black.Entity.TPS.FilterNodeEntities.NearAmbientRegionFilterNodeEntity.ObjectType, Construct, properties, 0, 312);
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

            fieldProperties = new PropertyContainer("Black.Entity.TPS.FilterNodeEntities.NearAmbientRegionFilterNodeEntity", base.GetFieldProperties(), 940961709, 277887175);
            
			
			
			fieldProperties.AddProperty(new Property("distance_", 3236486151, "float", 304, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("subject_", 3903058736, "Black.Entity.TPS.FallbackQueryDescriptorNodeEntity.SubjectType", 308, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new NearAmbientRegionFilterNodeEntity();
        }
		
    }
}