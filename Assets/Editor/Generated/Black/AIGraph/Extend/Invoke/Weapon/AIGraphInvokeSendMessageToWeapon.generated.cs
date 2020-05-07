using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Weapon
{
    public partial class AIGraphInvokeSendMessageToWeapon : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint animMsg;
		public int sendMessageAnySide;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSendMessageToWeapon();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Weapon.AIGraphInvokeSendMessageToWeapon", 0, Black.AIGraph.Extend.Invoke.Weapon.AIGraphInvokeSendMessageToWeapon.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Weapon.AIGraphInvokeSendMessageToWeapon", base.GetFieldProperties(), -640709422, 669528891);
            
			fieldProperties.AddProperty(new Property("animMsg", 2005261249, "SQEX.Ebony.Std.Fixid", 24, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("sendMessageAnySide", 232889723, "Black.AIGraph.Extend.Invoke.Weapon.AIGraphInvokeSendMessageToWeapon.SEND_MESSAGE_SIDE", 28, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}