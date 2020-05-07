using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Sound
{
    public partial class SoundAroundEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float fadeTime_;
		public float fadeInTime_;
		public float fadeOutTime_;
		public string idxFilePath_;
		public float aroundRadius_;
		public int measureFrame_;
		public int peopleType_;
		public bool bDefaultPlay_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SoundAroundEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Sound.SoundAroundEntity", 0, Black.Entity.Sound.SoundAroundEntity.ObjectType, null, properties, 0, 208);
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

            fieldProperties = new PropertyContainer("Black.Entity.Sound.SoundAroundEntity", base.GetFieldProperties(), -397116247, -2134374313);
            
			fieldProperties.AddProperty(new Property("fadeTime_", 2176527919, "float", 64, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeInTime_", 46563890, "float", 68, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeOutTime_", 2822800001, "float", 72, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("idxFilePath_", 3786101086, "Ebony.Base.String", 80, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("aroundRadius_", 4128509911, "float", 96, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("measureFrame_", 3292393217, "unsigned int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("peopleType_", 3177329699, "Black.Entity.Sound.SoundAroundEntity.NOISEPEOPLE_TYPES", 104, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("bDefaultPlay_", 3949404829, "bool", 108, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}