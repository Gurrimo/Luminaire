using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body.Layer
{
    public partial class BodyLeafNodeActivateLayerAnimation : Black.AIGraph.LeafNode.Body.Layer.BodyLeafNodeRequestLayerAnimation
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString graphId;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat beginBlendTime;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isMirrored;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum matchTrigger_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum rootRotationType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum rootTranslationType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool freezeSource_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool freezeTarget_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool noAnimFacingRecompute_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool noAnimOriginRecompute_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool lockAnimFacing_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool lockAnimOrigin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeActivateLayerAnimation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.Layer.BodyLeafNodeActivateLayerAnimation", 0, Black.AIGraph.LeafNode.Body.Layer.BodyLeafNodeActivateLayerAnimation.ObjectType, Construct, properties, 0, 688);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.Layer.BodyLeafNodeActivateLayerAnimation", base.GetFieldProperties(), -1151088719, 419368791);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isMessagePassThrough", 3038903938, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isMessagePassThrough.propertyId_", 3402240861, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isMessagePassThrough.indexOfLinkedProperty_", 1434567734, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isMessagePassThrough.value_", 1881529318, "bool", 80, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animMsg", 2005261249, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animMsg.propertyId_", 1752564102, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animMsg.indexOfLinkedProperty_", 2920181987, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animMsg.value_", 3947388071, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animLayer", 382561877, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animLayer.propertyId_", 3891205898, "int", 128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animLayer.indexOfLinkedProperty_", 1976640447, "int", 132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animLayer.value_", 1792715523, "SQEX.Ebony.Std.Fixid", 144, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isLayerFinishWithAnimFinish", 2423494943, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isLayerFinishWithAnimFinish.propertyId_", 1264499592, "int", 160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isLayerFinishWithAnimFinish.indexOfLinkedProperty_", 3680796285, "int", 164, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isLayerFinishWithAnimFinish.value_", 1896907629, "bool", 176, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("IsUseMessage", 2247550531, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("IsUseMessage.propertyId_", 2290329324, "int", 192, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("IsUseMessage.indexOfLinkedProperty_", 2432086137, "int", 196, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("IsUseMessage.value_", 3423182121, "bool", 208, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("deleteBlendTime", 2824128872, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 216, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("deleteBlendTime.propertyId_", 1125159759, "int", 224, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("deleteBlendTime.indexOfLinkedProperty_", 4000135552, "int", 228, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("deleteBlendTime.value_", 1671993612, "float", 240, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("graphId.propertyId_", 2378301397, "int", 280, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("graphId.indexOfLinkedProperty_", 3457217614, "int", 284, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("graphId.value_", 1276220942, "Ebony.Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("beginBlendTime.propertyId_", 2107965811, "int", 336, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("beginBlendTime.indexOfLinkedProperty_", 3063406812, "int", 340, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("beginBlendTime.value_", 1040469640, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isMirrored.propertyId_", 2634188876, "int", 368, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isMirrored.indexOfLinkedProperty_", 1610983641, "int", 372, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isMirrored.value_", 655810505, "bool", 384, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("matchTrigger_.propertyId_", 939113980, "int", 400, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("matchTrigger_.indexOfLinkedProperty_", 3879453833, "int", 404, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("matchTrigger_.value_", 1241286361, "int", 416, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rootRotationType_.propertyId_", 1616580303, "int", 432, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rootRotationType_.indexOfLinkedProperty_", 2238789632, "int", 436, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rootRotationType_.value_", 3914856332, "int", 448, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rootTranslationType_.propertyId_", 2765684710, "int", 464, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rootTranslationType_.indexOfLinkedProperty_", 3528564675, "int", 468, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rootTranslationType_.value_", 3546496199, "int", 480, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("freezeSource_.propertyId_", 2594799351, "int", 496, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("freezeSource_.indexOfLinkedProperty_", 3328841256, "int", 500, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("freezeSource_.value_", 970210948, "bool", 512, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("freezeTarget_.propertyId_", 3934794123, "int", 528, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("freezeTarget_.indexOfLinkedProperty_", 2481352852, "int", 532, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("freezeTarget_.value_", 909500400, "bool", 544, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("noAnimFacingRecompute_.propertyId_", 1318003685, "int", 560, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("noAnimFacingRecompute_.indexOfLinkedProperty_", 3273607070, "int", 564, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("noAnimFacingRecompute_.value_", 393476798, "bool", 576, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("noAnimOriginRecompute_.propertyId_", 1551677653, "int", 592, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("noAnimOriginRecompute_.indexOfLinkedProperty_", 3706947406, "int", 596, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("noAnimOriginRecompute_.value_", 786000142, "bool", 608, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lockAnimFacing_.propertyId_", 1433610937, "int", 624, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lockAnimFacing_.indexOfLinkedProperty_", 3887737418, "int", 628, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lockAnimFacing_.value_", 3858243706, "bool", 640, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lockAnimOrigin_.propertyId_", 4223003945, "int", 656, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lockAnimOrigin_.indexOfLinkedProperty_", 274580858, "int", 660, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lockAnimOrigin_.value_", 4245827402, "bool", 672, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("graphId", 3376006442, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString", 272, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("beginBlendTime", 1166606572, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 328, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isMirrored", 1314853667, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 360, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("matchTrigger_", 4001753971, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 392, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rootRotationType_", 739220712, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 424, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rootTranslationType_", 3221812513, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 456, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("freezeSource_", 3813934752, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 488, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("freezeTarget_", 38250036, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 520, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noAnimFacingRecompute_", 3561541146, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 552, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noAnimOriginRecompute_", 3545419306, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 584, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lockAnimFacing_", 4015675870, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 616, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lockAnimOrigin_", 4232392878, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 648, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new BodyLeafNodeActivateLayerAnimation();
        }
		
    }
}