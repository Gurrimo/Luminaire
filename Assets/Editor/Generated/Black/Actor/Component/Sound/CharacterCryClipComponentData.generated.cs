using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Sound
{
    public partial class CharacterCryClipComponentData : Black.Actor.Component.ActorComponentData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string idxFilePath_= string.Empty;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CharacterCryClipComponentData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Sound.CharacterCryClipComponentData", 0, Black.Actor.Component.Sound.CharacterCryClipComponentData.ObjectType, Construct, properties, 0, 104);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Sound.CharacterCryClipComponentData", base.GetFieldProperties(), -205557197, -992620204);
            
			
			
			fieldProperties.AddProperty(new Property("idxFilePath_", 3786101086, "Ebony.Base.String", 64, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new CharacterCryClipComponentData();
        }
		
    }
}