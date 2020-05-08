using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Buddy
{
    public partial class AIGraphInvokeEventScriptSetActionRecord : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int slotType_;
		public int actionType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeEventScriptSetActionRecord();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Buddy.AIGraphInvokeEventScriptSetActionRecord", 0, Black.AIGraph.Extend.Invoke.Buddy.AIGraphInvokeEventScriptSetActionRecord.ObjectType, Construct, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Buddy.AIGraphInvokeEventScriptSetActionRecord", base.GetFieldProperties(), -1108547880, -2060113100);
            
			
			
			fieldProperties.AddProperty(new Property("slotType_", 1228886674, "Black.AI.Recog.TARGET_SLOT_TYPE", 24, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("actionType_", 3416588776, "Black.Event.Script.ActionType", 28, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AIGraphInvokeEventScriptSetActionRecord();
        }
		
    }
}