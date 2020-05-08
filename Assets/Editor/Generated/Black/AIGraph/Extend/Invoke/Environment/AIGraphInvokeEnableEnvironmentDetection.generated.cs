using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Environment
{
    public partial class AIGraphInvokeEnableEnvironmentDetection : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool activate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeEnableEnvironmentDetection();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Environment.AIGraphInvokeEnableEnvironmentDetection", 0, Black.AIGraph.Extend.Invoke.Environment.AIGraphInvokeEnableEnvironmentDetection.ObjectType, Construct, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Environment.AIGraphInvokeEnableEnvironmentDetection", base.GetFieldProperties(), 1080681592, 1638970279);
            
			
			
			fieldProperties.AddProperty(new Property("activate_", 3319663101, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AIGraphInvokeEnableEnvironmentDetection();
        }
		
    }
}