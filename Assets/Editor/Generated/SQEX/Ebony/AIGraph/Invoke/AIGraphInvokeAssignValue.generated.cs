using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Invoke
{
    public partial class AIGraphInvokeAssignValue : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string compiledExpression_= string.Empty;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeAssignValue();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeAssignValue", 0, SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeAssignValue.ObjectType, Construct, properties, 0, 136);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeAssignValue", base.GetFieldProperties(), -696634918, 430917582);
            
			
			
			fieldProperties.AddProperty(new Property("compiledExpression_", 1854894313, "SQEX.Ebony.Base.String", 24, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AIGraphInvokeAssignValue();
        }
		
    }
}