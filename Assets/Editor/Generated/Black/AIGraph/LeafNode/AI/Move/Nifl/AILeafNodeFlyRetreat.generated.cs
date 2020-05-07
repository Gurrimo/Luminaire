using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move.Nifl
{
    public partial class AILeafNodeFlyRetreat : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat enableRetretDistanceOutsideCamera;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat enableRetretDistanceInsideCamera;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat enableRetreatMinimumAngle_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat fadeOutTime;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeFlyRetreat();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeFlyRetreat", 0, Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeFlyRetreat.ObjectType, null, properties, 0, 704);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeFlyRetreat", base.GetFieldProperties(), 599278891, -35487988);
            
			fieldProperties.AddProperty(new Property("enableRetretDistanceOutsideCamera", 3068757265, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 568, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableRetretDistanceInsideCamera", 981182216, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 600, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableRetreatMinimumAngle_", 702863731, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 632, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeOutTime", 1028999236, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 664, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}