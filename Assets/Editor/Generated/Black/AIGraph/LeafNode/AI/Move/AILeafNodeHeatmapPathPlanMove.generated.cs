using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move
{
    public partial class AILeafNodeHeatmapPathPlanMove : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat arrivalDistance;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat failedDistance;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat moveSpeed;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat heatHeuristicPower;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid heatMapFixid_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid TPSfixid;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeHeatmapPathPlanMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.AILeafNodeHeatmapPathPlanMove", 0, Black.AIGraph.LeafNode.AI.Move.AILeafNodeHeatmapPathPlanMove.ObjectType, null, properties, 0, 776);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.AILeafNodeHeatmapPathPlanMove", base.GetFieldProperties(), -468951171, 1777268169);
            
			fieldProperties.AddProperty(new Property("arrivalDistance", 1703907641, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 568, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("failedDistance", 3021369375, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 600, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveSpeed", 1157950271, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 632, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("heatHeuristicPower", 3237631682, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 664, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("heatMapFixid_", 4252894468, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 696, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("TPSfixid", 4154234548, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 728, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}