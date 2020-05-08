using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Buddy
{
    public partial class AIGraphInvokeSetHelpMission : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int state;
		public uint successAvoidMessage;
		public uint successBuddyMessage;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetHelpMission();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Buddy.AIGraphInvokeSetHelpMission", 0, Black.AIGraph.Extend.Invoke.Buddy.AIGraphInvokeSetHelpMission.ObjectType, Construct, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Buddy.AIGraphInvokeSetHelpMission", base.GetFieldProperties(), -1772948965, 837745865);
            
			
			
			fieldProperties.AddProperty(new Property("state", 2016490230, "Black.AIGraph.Extend.Invoke.Buddy.AIGraphInvokeSetHelpMission.HELP_MISSION_STATE", 24, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("successAvoidMessage", 3448325244, "SQEX.Ebony.Std.Fixid", 28, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("successBuddyMessage", 4056864087, "SQEX.Ebony.Std.Fixid", 32, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AIGraphInvokeSetHelpMission();
        }
		
    }
}