using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Combat
{
    public partial class AIGraphInvokeSetDamageDirection : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int targetType;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetDamageDirection();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Combat.AIGraphInvokeSetDamageDirection", 0, Black.AIGraph.Extend.Invoke.Combat.AIGraphInvokeSetDamageDirection.ObjectType, Construct, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Combat.AIGraphInvokeSetDamageDirection", base.GetFieldProperties(), -658351862, 494371970);
            
			
			
			fieldProperties.AddProperty(new Property("targetType", 414363200, "Black.AI.Recog.TARGET_SLOT_TYPE", 24, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AIGraphInvokeSetDamageDirection();
        }
		
    }
}