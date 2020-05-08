using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Expression.Invoke
{
    public partial class AIGraphExpressionInvokeOnMessage : SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphExpressionInvokeOnMessage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeOnMessage", 0, SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeOnMessage.ObjectType, Construct, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Expression.Invoke.AIGraphExpressionInvokeOnMessage", base.GetFieldProperties(), -1469959673, 735262562);
            
			
			
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AIGraphExpressionInvokeOnMessage();
        }
		
    }
}