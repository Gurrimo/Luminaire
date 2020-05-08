using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Render
{
    public partial class LightMapBakeEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string saveFolder_= string.Empty;
		public string uvSaveFolder_= string.Empty;
		public float texelPerMeter_;
		public int bounceCount_;
		public int rayBandleCount_;
		public int bakeSetNumber_;
		public bool doBake_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LightMapBakeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Render.LightMapBakeEntity", 0, Black.Entity.Render.LightMapBakeEntity.ObjectType, null, properties, 0, 128);
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

            fieldProperties = new PropertyContainer("Black.Entity.Render.LightMapBakeEntity", base.GetFieldProperties(), -921493706, -1709025812);
            
			
			
			fieldProperties.AddProperty(new Property("saveFolder_", 2684985225, "SQEX.Luminous.Core.String", 64, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("uvSaveFolder_", 358983676, "SQEX.Luminous.Core.String", 80, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("texelPerMeter_", 2267198880, "float", 96, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("bounceCount_", 2005441913, "uint32_t", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("rayBandleCount_", 2515586247, "uint32_t", 104, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("bakeSetNumber_", 1020725914, "int", 108, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("doBake_", 3759517666, "bool", 112, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}