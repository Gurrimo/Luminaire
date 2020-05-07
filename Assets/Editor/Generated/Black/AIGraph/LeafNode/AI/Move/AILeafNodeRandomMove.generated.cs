using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move
{
    public partial class AILeafNodeRandomMove : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat randRadiusOuter_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat randRadiusInner_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat arrivalDistance;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat moveSpeed;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool ignoreRadiusForArrival;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeRandomMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.AILeafNodeRandomMove", 0, Black.AIGraph.LeafNode.AI.Move.AILeafNodeRandomMove.ObjectType, null, properties, 0, 768);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.AILeafNodeRandomMove", base.GetFieldProperties(), 1328902660, -410654504);
            
			fieldProperties.AddProperty(new Property("randRadiusOuter_", 2601551056, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 568, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("randRadiusInner_", 3955115281, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 600, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("arrivalDistance", 1703907641, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 632, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveSpeed", 1157950271, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 664, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ignoreRadiusForArrival", 2200509057, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 696, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}