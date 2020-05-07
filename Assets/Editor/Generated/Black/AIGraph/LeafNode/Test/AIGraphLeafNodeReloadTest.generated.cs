using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Test
{
    public partial class AIGraphLeafNodeReloadTest : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString resourceType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphLeafNodeReloadTest();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeReloadTest", 0, Black.AIGraph.LeafNode.Test.AIGraphLeafNodeReloadTest.ObjectType, null, properties, 0, 128);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeReloadTest", base.GetFieldProperties(), 1095435414, 2115217668);
            
			fieldProperties.AddProperty(new Property("resourceType_", 3635199238, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString", 56, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}