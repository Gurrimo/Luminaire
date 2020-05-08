using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Material.ComponentData
{
    public partial class BodyMaterialComponentData : Black.Actor.Component.ActorComponentData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int createComponentType_;
		public IList<Black.Actor.Component.Material.ComponentData.BodyMaterialMaterialParamArrayItem> materials_= new List<Black.Actor.Component.Material.ComponentData.BodyMaterialMaterialParamArrayItem>();
		public float dirtyPowerByMoving_;
		public float dirtyPowerByDownTrigger_;
		public float dirtyPowerDuringRain_;
		public float dirtyPowerDuringSandSmall_;
		public float dirtyPowerDuringSandBig_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyMaterialComponentData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Material.ComponentData.BodyMaterialComponentData", 0, Black.Actor.Component.Material.ComponentData.BodyMaterialComponentData.ObjectType, Construct, properties, 0, 112);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Material.ComponentData.BodyMaterialComponentData", base.GetFieldProperties(), 354323975, 27954390);
            
			
			
			fieldProperties.AddProperty(new Property("createComponentType_", 789823869, "Black.Actor.Component.Material.ComponentData.BodyMaterialComponentData.CREATE_TYPE", 64, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("materials_", 3391624578, "SQEX.Ebony.Std.DynamicArray< Black.Actor.Component.Material.ComponentData.BodyMaterialMaterialParamArrayItem* >", 72, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("dirtyPowerByMoving_", 2645395828, "float", 88, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("dirtyPowerByDownTrigger_", 1601106112, "float", 92, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("dirtyPowerDuringRain_", 3602022480, "float", 96, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("dirtyPowerDuringSandSmall_", 608266795, "float", 100, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("dirtyPowerDuringSandBig_", 526933568, "float", 104, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new BodyMaterialComponentData();
        }
		
    }
}