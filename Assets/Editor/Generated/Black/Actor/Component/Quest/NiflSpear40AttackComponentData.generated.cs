using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Quest
{
    public partial class NiflSpear40AttackComponentData : Black.Actor.Component.ActorComponentData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float velocity_;
		public float velocityOffset_;
		public float waitSecond_;
		public int attackerLimit_;
		public IList<Black.AI.StrongPoint.StrongPointArrayItem> dataItemList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NiflSpear40AttackComponentData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Quest.NiflSpear40AttackComponentData", 0, Black.Actor.Component.Quest.NiflSpear40AttackComponentData.ObjectType, null, properties, 0, 96);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Quest.NiflSpear40AttackComponentData", base.GetFieldProperties(), 1041022517, -1500853164);
            
			fieldProperties.AddProperty(new Property("velocity_", 3653812119, "float", 64, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("velocityOffset_", 3598638398, "float", 68, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("waitSecond_", 55112537, "float", 72, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("attackerLimit_", 214697958, "unsigned int", 76, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("dataItemList_", 1972886199, "SQEX.Ebony.Std.DynamicArray< Black.AI.StrongPoint.StrongPointArrayItem* >", 80, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}