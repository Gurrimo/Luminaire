using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Monster
{
    public partial class AIGraphInvokeSetBerserk : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool bEnable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetBerserk();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Monster.AIGraphInvokeSetBerserk", 0, Black.AIGraph.Extend.Invoke.Monster.AIGraphInvokeSetBerserk.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Monster.AIGraphInvokeSetBerserk", base.GetFieldProperties(), 2045797917, 673746214);
            
			fieldProperties.AddProperty(new Property("bEnable_", 3281370179, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}