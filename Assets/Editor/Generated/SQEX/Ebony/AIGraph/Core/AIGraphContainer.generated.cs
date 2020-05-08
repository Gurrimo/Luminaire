using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Core
{
    public partial class AIGraphContainer : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<SQEX.Ebony.AIGraph.Node.AIGraphNodeEntryPoint> entryPoint_= new List<SQEX.Ebony.AIGraph.Node.AIGraphNodeEntryPoint>();
		public IList<SQEX.Ebony.AIGraph.Tray.AIGraphTrayBase> trays_= new List<SQEX.Ebony.AIGraph.Tray.AIGraphTrayBase>();
		public IList<SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase> leafs_= new List<SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase>();
		public int layer_;
		public IList<SQEX.Ebony.AIGraph.Data.ConstantValue.ConstantValueData> constantValueList_= new List<SQEX.Ebony.AIGraph.Data.ConstantValue.ConstantValueData>();
		public IList<SQEX.Ebony.AIGraph.Core.AIGraphCompiledExpression> compiledExpressionCacheList_= new List<SQEX.Ebony.AIGraph.Core.AIGraphCompiledExpression>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphContainer();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Core.AIGraphContainer", 0, SQEX.Ebony.AIGraph.Core.AIGraphContainer.ObjectType, null, properties, 0, 224);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Core.AIGraphContainer", base.GetFieldProperties(), -1622162244, 1428221721);
            
			
			
			fieldProperties.AddProperty(new Property("entryPoint_", 2166272460, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Node.AIGraphNodeEntryPoint*, MEMORY_CATEGORY_AI_GRAPH >", 80, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("trays_", 1952740799, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Tray.AIGraphTrayBase*, MEMORY_CATEGORY_AI_GRAPH >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddProperty(new Property("leafs_", 1592513527, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase*, MEMORY_CATEGORY_AI_GRAPH >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddProperty(new Property("layer_", 3015166475, "SQEX.Ebony.AIGraph.AIGRAPH_LAYER", 128, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("constantValueList_", 3663812283, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Data.ConstantValue.ConstantValueData*, MEMORY_CATEGORY_AI_GRAPH >", 136, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("compiledExpressionCacheList_", 2746055031, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Core.AIGraphCompiledExpression*, MEMORY_CATEGORY_AI_GRAPH >", 152, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}