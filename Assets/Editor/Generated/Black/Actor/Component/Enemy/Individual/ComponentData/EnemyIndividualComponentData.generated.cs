using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Enemy.Individual.ComponentData
{
    public partial class EnemyIndividualComponentData : Black.Actor.Component.Enemy.Individual.ComponentData.EnemyIndividualComponentDataBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int individualType;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new EnemyIndividualComponentData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Enemy.Individual.ComponentData.EnemyIndividualComponentData", 0, Black.Actor.Component.Enemy.Individual.ComponentData.EnemyIndividualComponentData.ObjectType, Construct, properties, 0, 72);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Enemy.Individual.ComponentData.EnemyIndividualComponentData", base.GetFieldProperties(), 1200261717, 741176349);
            
			
			
			fieldProperties.AddProperty(new Property("individualType", 2226370006, "Black.Actor.Component.Enemy.Individual.ENEMY_INDIVIDUALITY_TYPE", 64, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new EnemyIndividualComponentData();
        }
		
    }
}