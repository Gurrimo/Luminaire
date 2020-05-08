using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node.Corps
{
    public partial class ReinforceAppearPointEntity : Black.Entity.TransformGroupEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint appearWaitMessage;
		public uint appearSortieMessage;
		public int appearSpotNo_;
		public int appearLineNo_;
		public int appearProductionType_;
		public int reinforceGroup_;
		public int generatePriority;
		public float generateSpan_;
		public Black.Entity.RoutePoint.RouteEntity appearRoutePointEntity_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ReinforceAppearPointEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.Corps.ReinforceAppearPointEntity", 0, Black.Entity.Node.Corps.ReinforceAppearPointEntity.ObjectType, Construct, properties, 0, 400);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.Corps.ReinforceAppearPointEntity", base.GetFieldProperties(), -325723361, 1477425493);
            
			fieldProperties.AddIndirectlyProperty(new Property("entities_", 798990575, "SQEX.Ebony.Std.IntrusivePointerDynamicArray< SQEX.Ebony.Framework.Entity.Entity >", 64, 16, 1, Property.PrimitiveType.IntrusivePointerArray, 0, (char)5));
			fieldProperties.AddIndirectlyProperty(new Property("hasTransform_", 3096138238, "bool", 88, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 112, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("scaling_", 3325430311, "float", 128, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("canManipulate_", 3989276646, "bool", 132, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("appearWaitMessage", 857092468, "SQEX.Ebony.Std.Fixid", 224, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("appearSortieMessage", 2118578833, "SQEX.Ebony.Std.Fixid", 228, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("appearSpotNo_", 39315804, "int32_t", 232, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("appearLineNo_", 791590510, "int32_t", 236, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("appearProductionType_", 3307353368, "int32_t", 240, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("reinforceGroup_", 2242466742, "Black.AI.NihilSystem.Reinforcement.REINFORCEMENT_GENERATE_CATEGORY", 244, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("generatePriority", 3757563654, "uint32_t", 248, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("generateSpan_", 1909728471, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("appearRoutePointEntity_", 2802277375, "Black.Entity.RoutePoint.RouteEntity", 256, 8, 1, Property.PrimitiveType.Pointer, 0, (char)1));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new ReinforceAppearPointEntity();
        }
		
    }
}