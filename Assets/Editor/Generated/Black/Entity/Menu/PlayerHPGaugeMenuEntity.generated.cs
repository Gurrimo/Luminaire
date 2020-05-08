using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class PlayerHPGaugeMenuEntity : Black.Entity.Menu.SwfEntryEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 offset3d_;
		public UnityEngine.Vector4 offset2d_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PlayerHPGaugeMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.PlayerHPGaugeMenuEntity", 0, Black.Entity.Menu.PlayerHPGaugeMenuEntity.ObjectType, Construct, properties, 0, 608);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.PlayerHPGaugeMenuEntity", base.GetFieldProperties(), -1842106067, -1023257330);
            
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entitySearchLabelId_", 3840219358, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("menuFixID_", 107051205, "SQEX.Ebony.Std.Fixid", 256, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("swfEntryPackagePath_", 3946372377, "Ebony.Base.String", 272, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("offset3d_", 1591663190, "Luminous.Math.VectorA", 496, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("offset2d_", 838353761, "Luminous.Math.VectorA", 512, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new PlayerHPGaugeMenuEntity();
        }
		
    }
}