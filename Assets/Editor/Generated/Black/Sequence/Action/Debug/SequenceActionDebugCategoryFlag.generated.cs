using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class SequenceActionDebugCategoryFlag : SQEX.Ebony.Framework.Sequence.SequenceActivatableNode
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin succsessed_;
		public bool isConditionMission_;
		public bool isConditionQuest_;
		public bool isConditionDunsion_;
		public bool isConditionCombat_;
		public bool isConditionEvent_;
		public bool isConditionEnvironment_;
		public bool isConditionFreindAI_;
		public bool isConditionRpgSystem_;
		public bool isConditionTrainRpg_;
		public bool isConditionWorldMapSpecial_;
		public bool isConditionWorldMapNormal_;
		public bool isConditionSound_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugCategoryFlag();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.SequenceActionDebugCategoryFlag", 0, Black.Sequence.Action.Debug.SequenceActionDebugCategoryFlag.ObjectType, null, properties, 0, 280);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.SequenceActionDebugCategoryFlag", base.GetFieldProperties(), 1155028660, -1359049020);
            
			fieldProperties.AddProperty(new Property("succsessed_", 2113614169, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 168, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isConditionMission_", 3467808813, "bool", 264, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isConditionQuest_", 2785862901, "bool", 265, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isConditionDunsion_", 1544332081, "bool", 266, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isConditionCombat_", 122726711, "bool", 267, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isConditionEvent_", 2027987999, "bool", 268, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isConditionEnvironment_", 1548174540, "bool", 269, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isConditionFreindAI_", 4280736141, "bool", 270, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isConditionRpgSystem_", 4163707453, "bool", 271, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isConditionTrainRpg_", 3698761732, "bool", 272, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isConditionWorldMapSpecial_", 1189934448, "bool", 273, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isConditionWorldMapNormal_", 3795162448, "bool", 274, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isConditionSound_", 996394998, "bool", 275, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}