using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.CharacterEntry
{
    public partial class SummonDirectionRaycastParameters : Black.Entity.Data.CharacterEntry.CharacterEntryArrayItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 src_;
		public UnityEngine.Vector4 tgt_;
		public float score_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SummonDirectionRaycastParameters();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.CharacterEntry.SummonDirectionRaycastParameters", 0, Black.Entity.Data.CharacterEntry.SummonDirectionRaycastParameters.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.CharacterEntry.SummonDirectionRaycastParameters", base.GetFieldProperties(), 686008555, -57269070);
            
			fieldProperties.AddProperty(new Property("src_", 517414690, "Luminous.Math.VectorA", 16, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("tgt_", 4226382741, "Luminous.Math.VectorA", 32, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("score_", 2866867710, "float", 48, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}