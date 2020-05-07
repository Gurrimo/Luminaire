using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Vfx
{
    public partial class LmEnvironmentVFXElement : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string target_;
		public string path_;
		public float rate_;
		public IList<Black.Entity.Parameter.ParameterInt> externalInt_;
		public IList<Black.Entity.Parameter.ParameterFloat> externalFloat_;
		public IList<Black.Entity.Parameter.ParameterVector> externalVector_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LmEnvironmentVFXElement();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Vfx.LmEnvironmentVFXElement", 0, Black.Entity.Vfx.LmEnvironmentVFXElement.ObjectType, null, properties, 0, 128);
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

            fieldProperties = new PropertyContainer("Black.Entity.Vfx.LmEnvironmentVFXElement", base.GetFieldProperties(), -1572810957, 41920177);
            
			fieldProperties.AddProperty(new Property("target_", 1693858869, "Ebony.Base.String", 16, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("path_", 167697483, "Ebony.Base.String", 32, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("rate_", 4046384168, "float", 48, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("externalInt_", 318859364, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Parameter.ParameterInt* >", 56, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("externalFloat_", 608079525, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Parameter.ParameterFloat* >", 72, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("externalVector_", 2784381210, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Parameter.ParameterVector* >", 88, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}