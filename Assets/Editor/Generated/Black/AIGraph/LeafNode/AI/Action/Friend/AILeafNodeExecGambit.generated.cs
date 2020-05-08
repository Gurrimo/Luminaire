using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action.Friend
{
    public partial class AILeafNodeExecGambit : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum channel;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bDebugLog;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isTargetNotExist;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isGambitNotExist;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeout;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bReset;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bUseCautionTargetWhenCheckMotionCancel;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeExecGambit();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.Friend.AILeafNodeExecGambit", 0, Black.AIGraph.LeafNode.AI.Action.Friend.AILeafNodeExecGambit.ObjectType, Construct, properties, 0, 344);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.Friend.AILeafNodeExecGambit", base.GetFieldProperties(), -2041570298, 414688347);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetSlotType.propertyId_", 1957557891, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetSlotType.indexOfLinkedProperty_", 2720815276, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetSlotType.value_", 913738680, "int", 80, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("channel.propertyId_", 1194587163, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("channel.indexOfLinkedProperty_", 725464548, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("channel.value_", 1367158496, "int", 112, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDebugLog.propertyId_", 2160590197, "int", 128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDebugLog.indexOfLinkedProperty_", 44347118, "int", 132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDebugLog.value_", 1731295214, "bool", 144, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isTargetNotExist.propertyId_", 4081864399, "int", 160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isTargetNotExist.indexOfLinkedProperty_", 3386308608, "int", 164, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isTargetNotExist.value_", 1154332556, "bool", 176, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isGambitNotExist.propertyId_", 2580058840, "int", 192, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isGambitNotExist.indexOfLinkedProperty_", 4294596877, "int", 196, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isGambitNotExist.value_", 3273475357, "bool", 208, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeout.propertyId_", 1014648559, "int", 224, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeout.indexOfLinkedProperty_", 311787552, "int", 228, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeout.value_", 3546920172, "float", 240, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bReset.propertyId_", 3216742551, "int", 256, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bReset.indexOfLinkedProperty_", 205294152, "int", 260, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bReset.value_", 348185060, "bool", 272, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bUseCautionTargetWhenCheckMotionCancel.propertyId_", 2038416751, "int", 288, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bUseCautionTargetWhenCheckMotionCancel.indexOfLinkedProperty_", 1909073824, "int", 292, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bUseCautionTargetWhenCheckMotionCancel.value_", 1608350828, "bool", 304, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("targetSlotType", 999269404, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("channel", 566383268, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bDebugLog", 2782900938, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isTargetNotExist", 3305430248, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isGambitNotExist", 485988623, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeout", 2549515144, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 216, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bReset", 1803019200, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 248, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bUseCautionTargetWhenCheckMotionCancel", 1523597832, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 280, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AILeafNodeExecGambit();
        }
		
    }
}