using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class StrongPointMissionNodeEntity : Black.Entity.Node.StrongPointNodeEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.AI.StrongPoint.StrongPointArrayItem> dataItemList_;
		public int numSoldier_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new StrongPointMissionNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.StrongPointMissionNodeEntity", 0, Black.Entity.Node.StrongPointMissionNodeEntity.ObjectType, null, properties, 0, 336);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.StrongPointMissionNodeEntity", base.GetFieldProperties(), 516426026, 640272338);
            
			fieldProperties.AddProperty(new Property("dataItemList_", 1972886199, "SQEX.Ebony.Std.DynamicArray< Black.AI.StrongPoint.StrongPointArrayItem* >", 304, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("numSoldier_", 1240002468, "int", 320, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}