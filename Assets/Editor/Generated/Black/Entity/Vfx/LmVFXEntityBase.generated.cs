using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Vfx
{
    public partial class LmVFXEntityBase : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float baseScaling_;
		public bool enabled_;
		public IList<Black.Entity.Parameter.ParameterInt> externalInt_= new List<Black.Entity.Parameter.ParameterInt>();
		public IList<Black.Entity.Parameter.ParameterFloat> externalFloat_= new List<Black.Entity.Parameter.ParameterFloat>();
		public IList<Black.Entity.Parameter.ParameterVector> externalVector_= new List<Black.Entity.Parameter.ParameterVector>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LmVFXEntityBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Vfx.LmVFXEntityBase", 0, Black.Entity.Vfx.LmVFXEntityBase.ObjectType, null, properties, 0, 352);
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

            fieldProperties = new PropertyContainer("Black.Entity.Vfx.LmVFXEntityBase", base.GetFieldProperties(), 771960598, -524534967);
            
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entitySearchLabelId_", 3840219358, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("baseScaling_", 1550308934, "float", 264, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 268, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("externalInt_", 318859364, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Parameter.ParameterInt* >", 272, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("externalFloat_", 608079525, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Parameter.ParameterFloat* >", 288, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("externalVector_", 2784381210, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Parameter.ParameterVector* >", 304, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}