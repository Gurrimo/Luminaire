using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.FSM
{
    public partial class AIGraphNodeFSMRoot : SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMInterrupt> interruptNodes_= new List<SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMInterrupt>();
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool blockTreeDebugLogs;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeFSMRoot();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMRoot", 0, SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMRoot.ObjectType, Construct, properties, 0, 256);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMRoot", base.GetFieldProperties(), -985679196, -42135839);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("invokeListOnActivate_", 2823484654, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase*, MEMORY_CATEGORY_AI_GRAPH >", 56, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("invokeListOnDeactivate_", 2891137263, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase*, MEMORY_CATEGORY_AI_GRAPH >", 72, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("conditions_", 3387481400, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Data.ConditionData*, MEMORY_CATEGORY_AI_GRAPH >", 88, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddIndirectlyProperty(new Property("displayName_", 2066980907, "Ebony.Base.String", 104, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("displayNameJP_", 3614302633, "Ebony.Base.String", 120, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blockTreeDebugLogs.propertyId_", 108324877, "int", 216, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blockTreeDebugLogs.indexOfLinkedProperty_", 4293927270, "int", 220, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blockTreeDebugLogs.value_", 2798643958, "bool", 232, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("interruptNodes_", 1784887590, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMInterrupt*, MEMORY_CATEGORY_AI_GRAPH >", 192, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("blockTreeDebugLogs", 428688786, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 208, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AIGraphNodeFSMRoot();
        }
		
    }
}