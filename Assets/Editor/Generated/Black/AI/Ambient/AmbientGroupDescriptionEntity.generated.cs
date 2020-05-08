using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Ambient
{
    public partial class AmbientGroupDescriptionEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.AI.Ambient.AmbientGroupMemberDescription> memberDescriptions_= new List<Black.AI.Ambient.AmbientGroupMemberDescription>();
		public int maxMembers_;
		public int maxCount_;
		public uint steeringMoveArchetype_;
		public uint interactionGroupId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AmbientGroupDescriptionEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Ambient.AmbientGroupDescriptionEntity", 0, Black.AI.Ambient.AmbientGroupDescriptionEntity.ObjectType, Construct, properties, 0, 104);
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

            fieldProperties = new PropertyContainer("Black.AI.Ambient.AmbientGroupDescriptionEntity", base.GetFieldProperties(), -115744571, -825519210);
            
			
			
			fieldProperties.AddProperty(new Property("memberDescriptions_", 2932430281, "SQEX.Ebony.Std.DynamicArray< Black.AI.Ambient.AmbientGroupMemberDescription* >", 64, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("maxMembers_", 250297609, "int", 80, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxCount_", 3764251533, "int", 84, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("steeringMoveArchetype_", 2716383479, "SQEX.Ebony.Std.Fixid", 88, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionGroupId_", 3697220080, "SQEX.Ebony.Std.Fixid", 92, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AmbientGroupDescriptionEntity();
        }
		
    }
}