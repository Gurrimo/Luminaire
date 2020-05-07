using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Monster
{
    public partial class AIGraphInvokeSetForceEmotion : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int emotion;
		public float duration_time;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetForceEmotion();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Monster.AIGraphInvokeSetForceEmotion", 0, Black.AIGraph.Extend.Invoke.Monster.AIGraphInvokeSetForceEmotion.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Monster.AIGraphInvokeSetForceEmotion", base.GetFieldProperties(), -1751885236, -193782961);
            
			fieldProperties.AddProperty(new Property("emotion", 1337504642, "int", 24, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("duration_time", 3065736271, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}