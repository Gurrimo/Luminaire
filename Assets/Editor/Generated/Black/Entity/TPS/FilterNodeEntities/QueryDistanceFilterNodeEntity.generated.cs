using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.TPS.FilterNodeEntities
{
    public partial class QueryDistanceFilterNodeEntity : Black.Entity.TPS.FilterDescriptorNodeEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int subject_;
		public bool useRadius_;
		public int allowAIGraphOverride_;
		public float maxDistance_;
		public float minDistance_;
		public float weight_;
		public int distanceType_;
		public float distance_;
		public bool invalidDistanceType_;
		public bool useMaxFlag_;
		public bool useMinFlag_;
		public bool useWeightFlag_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new QueryDistanceFilterNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.TPS.FilterNodeEntities.QueryDistanceFilterNodeEntity", 0, Black.Entity.TPS.FilterNodeEntities.QueryDistanceFilterNodeEntity.ObjectType, null, properties, 0, 344);
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

            fieldProperties = new PropertyContainer("Black.Entity.TPS.FilterNodeEntities.QueryDistanceFilterNodeEntity", base.GetFieldProperties(), 1037075594, 1325439846);
            
			fieldProperties.AddProperty(new Property("subject_", 3903058736, "Black.Entity.TPS.FallbackQueryDescriptorNodeEntity.SubjectType", 304, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("useRadius_", 1483850511, "bool", 308, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("allowAIGraphOverride_", 2548859529, "Black.Entity.TPS.FilterDescriptorNodeEntity.OverrideableInAIGraph", 312, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxDistance_", 2164793323, "float", 316, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("minDistance_", 462922493, "float", 320, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("weight_", 3537511442, "float", 324, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("distanceType_", 3462299575, "Black.Entity.TPS.FallbackQueryDescriptorNodeEntity.DistanceType", 328, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("distance_", 3236486151, "float", 332, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("invalidDistanceType_", 2646249060, "bool", 336, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("useMaxFlag_", 4190036249, "bool", 337, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("useMinFlag_", 2328612815, "bool", 338, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("useWeightFlag_", 4027223091, "bool", 339, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}