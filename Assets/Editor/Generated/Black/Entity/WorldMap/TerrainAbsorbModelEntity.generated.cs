using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.WorldMap
{
    public partial class TerrainAbsorbModelEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string sourcePath_;
		public float scaling_;
		public bool visible_;
		public bool isAbsorbTarget_;
		public float interpolationRange_;
		public int interpolationType_;
		public int interpolationFunction_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TerrainAbsorbModelEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.WorldMap.TerrainAbsorbModelEntity", 0, Black.Entity.WorldMap.TerrainAbsorbModelEntity.ObjectType, null, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("Black.Entity.WorldMap.TerrainAbsorbModelEntity", base.GetFieldProperties(), 1093032320, 2027689440);
            
			fieldProperties.AddProperty(new Property("sourcePath_", 341055184, "Ebony.Base.String", 256, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("scaling_", 3325430311, "float", 272, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("visible_", 3296750298, "bool", 276, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isAbsorbTarget_", 2906746346, "bool", 277, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("interpolationRange_", 807353103, "float", 280, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("interpolationType_", 3048484094, "Black.Entity.WorldMap.TerrainAbsorbModelEntity.InterpolationType", 284, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("interpolationFunction_", 1282943386, "Black.Entity.WorldMap.TerrainAbsorbModelEntity.InterpolationFunction", 288, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}