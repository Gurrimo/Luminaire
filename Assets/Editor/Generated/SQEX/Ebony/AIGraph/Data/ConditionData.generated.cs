using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Data
{
    public partial class ConditionData : SQEX.Luminous.Core.Object.Object
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int type_;
		public string condition_= string.Empty;
		public string compiledCondition_= string.Empty;
		public int conditionIdxInContainerCache_;
		public bool bDebugLog_;
		public bool bDebugConditionWatch_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ConditionData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Data.ConditionData", 0, SQEX.Ebony.AIGraph.Data.ConditionData.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Data.ConditionData", base.GetFieldProperties(), 286990604, 480872431);
            
			
			
			fieldProperties.AddProperty(new Property("type_", 3554705238, "SQEX.Ebony.AIGraph.Data.CONDITION_TYPE", 16, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("condition_", 2497769523, "Ebony.Base.String", 24, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("compiledCondition_", 2239119596, "Ebony.Base.String", 40, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("conditionIdxInContainerCache_", 2320057898, "int", 56, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("bDebugLog_", 3022397583, "bool", 60, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bDebugConditionWatch_", 187318605, "bool", 61, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}