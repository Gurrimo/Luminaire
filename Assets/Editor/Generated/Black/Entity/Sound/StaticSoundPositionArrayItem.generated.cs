using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Sound
{
    public partial class StaticSoundPositionArrayItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.Entity.Sound.StaticSoundEntitySourcePoint entityPointer_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new StaticSoundPositionArrayItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Sound.StaticSoundPositionArrayItem", 0, Black.Entity.Sound.StaticSoundPositionArrayItem.ObjectType, null, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("Black.Entity.Sound.StaticSoundPositionArrayItem", base.GetFieldProperties(), -237893668, 990950760);
            
			fieldProperties.AddProperty(new Property("entityPointer_", 3527687820, "Black.Entity.Sound.StaticSoundEntitySourcePoint", 8, 8, 1, Property.PrimitiveType.Pointer, 0, (char)1));
			
			
			return fieldProperties;
        }

		
    }
}