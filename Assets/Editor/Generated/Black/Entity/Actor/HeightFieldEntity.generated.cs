using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Actor
{
    public partial class HeightFieldEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string sourcePath_= string.Empty;
		public string sourcePathHighSpec_= string.Empty;
		public string materialPalettePath_= string.Empty;
		public string heightMapPath_= string.Empty;
		public string heightMapHighSpecPath_= string.Empty;
		public string additionalDisplacementTextureFilePath_= string.Empty;
		public float scaling_;
		public bool visible_;
		public bool forMulti_;
		public int cellX_;
		public int cellZ_;
		public int maxLODBinLevel_;
		public float minAltitude_;
		public float maxAltitude_;
		public bool useMeshCollision_;
		public int lodMeshCollision_;
		public float normalPowerPerMeter_;
		public bool isSea_;
		public string seaHeightMapPath_= string.Empty;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new HeightFieldEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Actor.HeightFieldEntity", 0, Black.Entity.Actor.HeightFieldEntity.ObjectType, Construct, properties, 0, 800);
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

            fieldProperties = new PropertyContainer("Black.Entity.Actor.HeightFieldEntity", base.GetFieldProperties(), -1070235521, -52094853);
            
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entitySearchLabelId_", 3840219358, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("sourcePath_", 341055184, "Ebony.Base.String", 256, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourcePathHighSpec_", 1009877713, "Ebony.Base.String", 272, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialPalettePath_", 1719454245, "Ebony.Base.String", 288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("heightMapPath_", 1876232188, "Ebony.Base.String", 304, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("heightMapHighSpecPath_", 2967590121, "Ebony.Base.String", 320, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("additionalDisplacementTextureFilePath_", 909069144, "Ebony.Base.String", 336, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("scaling_", 3325430311, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("visible_", 3296750298, "bool", 356, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("forMulti_", 1739446222, "bool", 357, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("cellX_", 3189742680, "int", 360, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("cellZ_", 4263804486, "int", 364, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxLODBinLevel_", 19312022, "int", 368, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("minAltitude_", 3404475618, "float", 372, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxAltitude_", 3726422252, "float", 376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("useMeshCollision_", 468627668, "bool", 380, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("lodMeshCollision_", 2108312696, "int", 384, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("normalPowerPerMeter_", 500297076, "float", 388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isSea_", 4101159321, "bool", 392, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("seaHeightMapPath_", 113663893, "Ebony.Base.String", 400, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new HeightFieldEntity();
        }
		
    }
}