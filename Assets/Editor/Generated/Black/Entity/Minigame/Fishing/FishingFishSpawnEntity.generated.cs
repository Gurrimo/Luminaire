using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Minigame.Fishing
{
    public partial class FishingFishSpawnEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int spawnAreaType_;
		public float boxEllipseWidth_;
		public float boxEllipseDepth_;
		public float circleRadius_;
		public int spawnLevel_;
		public int spawnMaxCount_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new FishingFishSpawnEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Minigame.Fishing.FishingFishSpawnEntity", 0, Black.Entity.Minigame.Fishing.FishingFishSpawnEntity.ObjectType, null, properties, 0, 288);
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

            fieldProperties = new PropertyContainer("Black.Entity.Minigame.Fishing.FishingFishSpawnEntity", base.GetFieldProperties(), -1492454248, 2089582880);
            
			fieldProperties.AddProperty(new Property("spawnAreaType_", 2251559410, "Black.Entity.Minigame.Fishing.FishingFishSpawnEntity.AREA_TYPE", 256, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("boxEllipseWidth_", 2631172881, "float", 260, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("boxEllipseDepth_", 3548261702, "float", 264, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("circleRadius_", 3455069560, "float", 268, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("spawnLevel_", 1360392611, "Black.Entity.Minigame.Fishing.FishingFishSpawnEntity.AREA_LEVEL", 272, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("spawnMaxCount_", 464903854, "int", 276, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}