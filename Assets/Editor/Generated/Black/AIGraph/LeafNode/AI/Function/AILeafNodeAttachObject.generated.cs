using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AILeafNodeAttachObject : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat offsetX_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat offsetY_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat offsetZ_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat rotationX_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat rotationY_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat rotationZ_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid joint_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool localRotationFlag_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool releaseOnDetach_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool useParentScale_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool linkMessage_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeAttachObject();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AILeafNodeAttachObject", 0, Black.AIGraph.LeafNode.AI.Function.AILeafNodeAttachObject.ObjectType, Construct, properties, 0, 440);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AILeafNodeAttachObject", base.GetFieldProperties(), 2052133254, -1005811823);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetSlotType_.propertyId_", 148178158, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetSlotType_.indexOfLinkedProperty_", 1898007691, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetSlotType_.value_", 340910751, "int", 80, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("offsetX_.propertyId_", 2846478564, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("offsetX_.indexOfLinkedProperty_", 648298769, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("offsetX_.value_", 2710593169, "float", 112, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("offsetY_.propertyId_", 3390165469, "int", 128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("offsetY_.indexOfLinkedProperty_", 1556382646, "int", 132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("offsetY_.value_", 3933322086, "float", 144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("offsetZ_.propertyId_", 2915881666, "int", 160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("offsetZ_.indexOfLinkedProperty_", 2676164599, "int", 164, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("offsetZ_.value_", 1729720491, "float", 176, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotationX_.propertyId_", 1437832233, "int", 192, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotationX_.indexOfLinkedProperty_", 3338883706, "int", 196, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotationX_.value_", 2676653130, "float", 208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotationY_.propertyId_", 170491504, "int", 224, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotationY_.indexOfLinkedProperty_", 4113961861, "int", 228, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotationY_.value_", 2444147845, "float", 240, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotationZ_.propertyId_", 3719388119, "int", 256, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotationZ_.indexOfLinkedProperty_", 1882532232, "int", 260, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotationZ_.value_", 3126336548, "float", 272, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("joint_.propertyId_", 255704639, "int", 288, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("joint_.indexOfLinkedProperty_", 1549251568, "int", 292, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("joint_.value_", 3960633500, "SQEX.Ebony.Std.Fixid", 304, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("localRotationFlag_.propertyId_", 2870293490, "int", 320, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("localRotationFlag_.indexOfLinkedProperty_", 225703399, "int", 324, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("localRotationFlag_.value_", 840041275, "bool", 336, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("releaseOnDetach_.propertyId_", 74983610, "int", 352, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("releaseOnDetach_.indexOfLinkedProperty_", 1340782575, "int", 356, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("releaseOnDetach_.value_", 2810298579, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useParentScale_.propertyId_", 2441800004, "int", 384, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useParentScale_.indexOfLinkedProperty_", 962586353, "int", 388, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useParentScale_.value_", 3869921329, "bool", 400, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("linkMessage_.propertyId_", 511544050, "int", 416, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("linkMessage_.indexOfLinkedProperty_", 772608743, "int", 420, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("linkMessage_.value_", 2876891195, "bool", 432, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("targetSlotType_", 102733177, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetX_", 1096147371, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetY_", 2170062082, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetZ_", 2169620797, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotationX_", 3350366126, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotationY_", 128916183, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 216, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotationZ_", 3349968768, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 248, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("joint_", 603379448, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 280, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("localRotationFlag_", 1404997709, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 312, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("releaseOnDetach_", 950754661, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 344, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("useParentScale_", 2444743947, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 376, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("linkMessage_", 3469055821, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 408, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AILeafNodeAttachObject();
        }
		
    }
}