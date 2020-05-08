using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.VFX
{
    public partial class AIGraphInvokePlayLuminousVFX : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint VlinkID;
		public int WeaponOption;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokePlayLuminousVFX();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.VFX.AIGraphInvokePlayLuminousVFX", 0, Black.AIGraph.Extend.Invoke.VFX.AIGraphInvokePlayLuminousVFX.ObjectType, Construct, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.VFX.AIGraphInvokePlayLuminousVFX", base.GetFieldProperties(), 1093475309, -2037500446);
            
			
			
			fieldProperties.AddProperty(new Property("VlinkID", 241610760, "SQEX.Ebony.Std.Fixid", 24, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("WeaponOption", 1785740048, "Black.AIGraph.Extend.Invoke.VFX.AIGraphInvokePlayLuminousVFX.WEAPON_VFX_TYPE", 28, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AIGraphInvokePlayLuminousVFX();
        }
		
    }
}