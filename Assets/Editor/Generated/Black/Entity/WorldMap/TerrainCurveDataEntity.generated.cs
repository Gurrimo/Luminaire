using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.WorldMap
{
    public partial class TerrainCurveDataEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string curveDataFilePath_= string.Empty;
		public int curveCategory_;
		public bool isAbsorbable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TerrainCurveDataEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.WorldMap.TerrainCurveDataEntity", 0, Black.Entity.WorldMap.TerrainCurveDataEntity.ObjectType, Construct, properties, 0, 432);
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

            fieldProperties = new PropertyContainer("Black.Entity.WorldMap.TerrainCurveDataEntity", base.GetFieldProperties(), 1070906061, -180620989);
            
			
			
			fieldProperties.AddProperty(new Property("curveDataFilePath_", 3013718162, "Ebony.Base.String", 384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("curveCategory_", 1060782121, "Black.Entity.WorldMap.TerrainCurveDataEntity.CURVE_CATEGORY", 400, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isAbsorbable_", 653953453, "bool", 404, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new TerrainCurveDataEntity();
        }
		
    }
}