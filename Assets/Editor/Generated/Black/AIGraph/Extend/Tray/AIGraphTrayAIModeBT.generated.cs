using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Tray
{
    public partial class AIGraphTrayAIModeBT : SQEX.Ebony.AIGraph.Tray.AIGraphTrayBT
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid aiModeId;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid aiSubModeId;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphTrayAIModeBT();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Tray.AIGraphTrayAIModeBT", 0, Black.AIGraph.Extend.Tray.AIGraphTrayAIModeBT.ObjectType, Construct, properties, 0, 272);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Tray.AIGraphTrayAIModeBT", base.GetFieldProperties(), 899296779, 643128411);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("nodes_", 61650911, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Node.AIGraphNodeBase*, MEMORY_CATEGORY_AI_GRAPH >", 48, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("properties_", 2753876537, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBase*, MEMORY_CATEGORY_AI_GRAPH >", 64, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("debug_BlockWarningRunningWithNoChildren_", 2490290986, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 80, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("debug_BlockWarningRunningWithNoChildren_.propertyId_", 1359588821, "int", 88, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("debug_BlockWarningRunningWithNoChildren_.indexOfLinkedProperty_", 1505766990, "int", 92, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("debug_BlockWarningRunningWithNoChildren_.value_", 1075728398, "bool", 104, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("aiModeId.propertyId_", 2147434906, "int", 184, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("aiModeId.indexOfLinkedProperty_", 3540163535, "int", 188, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("aiModeId.value_", 2369648371, "SQEX.Ebony.Std.Fixid", 200, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("aiSubModeId.propertyId_", 1098763542, "int", 216, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("aiSubModeId.indexOfLinkedProperty_", 2471779827, "int", 220, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("aiSubModeId.value_", 1471938711, "SQEX.Ebony.Std.Fixid", 232, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("aiModeId", 4169997125, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 176, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("aiSubModeId", 514721265, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 208, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AIGraphTrayAIModeBT();
        }
		
    }
}