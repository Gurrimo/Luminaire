using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node.Corps
{
    public partial class ReinforcePointEntity : Black.Entity.Node.Corps.ReinforceAppearGroupEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint jointId_;
		public string reinforceLabel_= string.Empty;
		public uint reinforcePointLabel_;
		public bool isDebugDraw_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ReinforcePointEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.Corps.ReinforcePointEntity", 0, Black.Entity.Node.Corps.ReinforcePointEntity.ObjectType, null, properties, 0, 384);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.Corps.ReinforcePointEntity", base.GetFieldProperties(), 135583237, 1046699419);
            
			fieldProperties.AddIndirectlyProperty(new Property("entities_", 798990575, "SQEX.Ebony.Std.IntrusivePointerDynamicArray< SQEX.Ebony.Framework.Entity.Entity >", 64, 16, 1, Property.PrimitiveType.IntrusivePointerArray, 0, (char)5));
			fieldProperties.AddIndirectlyProperty(new Property("hasTransform_", 3096138238, "bool", 88, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 112, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("scaling_", 3325430311, "float", 128, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("canManipulate_", 3989276646, "bool", 132, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("priority", 2498028297, "uint32_t", 224, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("jointId_", 3429568351, "SQEX.Ebony.Std.Fixid", 288, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("reinforceLabel_", 22999053, "Ebony.Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("reinforcePointLabel_", 1520625023, "SQEX.Ebony.Std.Fixid", 312, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("isDebugDraw_", 1140229391, "bool", 316, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}