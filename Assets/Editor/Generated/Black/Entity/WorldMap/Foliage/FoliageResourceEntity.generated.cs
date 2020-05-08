using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.WorldMap.Foliage
{
    public partial class FoliageResourceEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Entity.WorldMap.Foliage.FoliageModelFilePathEntity> foliageModelFilePaths_= new List<Black.Entity.WorldMap.Foliage.FoliageModelFilePathEntity>();
		public string decorationSetFilePath_= string.Empty;
		public string decorationSetHighFilePath_= string.Empty;
		public float radius_;
		public bool loadWhenFly_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new FoliageResourceEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.WorldMap.Foliage.FoliageResourceEntity", 0, Black.Entity.WorldMap.Foliage.FoliageResourceEntity.ObjectType, Construct, properties, 0, 168);
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

            fieldProperties = new PropertyContainer("Black.Entity.WorldMap.Foliage.FoliageResourceEntity", base.GetFieldProperties(), 15273958, -1769805089);
            
			
			
			fieldProperties.AddProperty(new Property("foliageModelFilePaths_", 462606478, "SQEX.Ebony.Std.DynamicArray< Black.Entity.WorldMap.Foliage.FoliageModelFilePathEntity*, MEMORY_CATEGORY_WORLDMAP >", 64, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("decorationSetFilePath_", 145970333, "Ebony.Base.String", 80, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("decorationSetHighFilePath_", 2978482941, "Ebony.Base.String", 96, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("radius_", 2286360452, "float", 112, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("loadWhenFly_", 3269848743, "bool", 116, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new FoliageResourceEntity();
        }
		
    }
}