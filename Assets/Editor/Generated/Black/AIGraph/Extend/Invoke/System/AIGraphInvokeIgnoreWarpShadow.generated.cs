using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.System
{
    public partial class AIGraphInvokeIgnoreWarpShadow : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool ignoreWarpShadow_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeIgnoreWarpShadow();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.System.AIGraphInvokeIgnoreWarpShadow", 0, Black.AIGraph.Extend.Invoke.System.AIGraphInvokeIgnoreWarpShadow.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.System.AIGraphInvokeIgnoreWarpShadow", base.GetFieldProperties(), 1731459421, 270772005);
            
			fieldProperties.AddProperty(new Property("ignoreWarpShadow_", 371436322, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}