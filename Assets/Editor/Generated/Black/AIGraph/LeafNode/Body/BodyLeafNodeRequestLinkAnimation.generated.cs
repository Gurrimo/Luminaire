using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body
{
    public partial class BodyLeafNodeRequestLinkAnimation : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum status;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString sceneAssetPath_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat syncTime_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid ownerRole_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt ownerRoleIdx_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat ownerAnimationTransitionTime_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid target1Role_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt target1RoleIdx_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat target1AnimationTransitionTime_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid target2Role_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt target2RoleIdx_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat target2AnimationTransitionTime_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid target3Role_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt target3RoleIdx_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat target3AnimationTransitionTime_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid target4Role_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt target4RoleIdx_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat target4AnimationTransitionTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeRequestLinkAnimation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.BodyLeafNodeRequestLinkAnimation", 0, Black.AIGraph.LeafNode.Body.BodyLeafNodeRequestLinkAnimation.ObjectType, Construct, properties, 0, 696);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.BodyLeafNodeRequestLinkAnimation", base.GetFieldProperties(), 977277741, -1877427438);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.propertyId_", 1097509688, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.indexOfLinkedProperty_", 1329201901, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.value_", 3916200893, "int", 80, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sceneAssetPath_.propertyId_", 4260522564, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sceneAssetPath_.indexOfLinkedProperty_", 3270775281, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sceneAssetPath_.value_", 302889777, "Ebony.Base.String", 112, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("syncTime_.propertyId_", 3116227379, "int", 152, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("syncTime_.indexOfLinkedProperty_", 284806556, "int", 156, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("syncTime_.value_", 231834440, "float", 168, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("ownerRole_.propertyId_", 2618840430, "int", 184, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("ownerRole_.indexOfLinkedProperty_", 2246087179, "int", 188, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("ownerRole_.value_", 3981232159, "SQEX.Ebony.Std.Fixid", 200, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("ownerRoleIdx_.propertyId_", 2302495939, "int", 216, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("ownerRoleIdx_.indexOfLinkedProperty_", 1859761900, "int", 220, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("ownerRoleIdx_.value_", 1562249976, "int", 232, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("ownerAnimationTransitionTime_.propertyId_", 2256249706, "int", 248, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("ownerAnimationTransitionTime_.indexOfLinkedProperty_", 3260775839, "int", 252, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("ownerAnimationTransitionTime_.value_", 3840918179, "float", 264, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target1Role_.propertyId_", 2228609335, "int", 280, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target1Role_.indexOfLinkedProperty_", 4043657832, "int", 284, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target1Role_.value_", 1694935492, "SQEX.Ebony.Std.Fixid", 296, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target1RoleIdx_.propertyId_", 3855479068, "int", 312, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target1RoleIdx_.indexOfLinkedProperty_", 4072858793, "int", 316, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target1RoleIdx_.value_", 2634680377, "int", 328, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target1AnimationTransitionTime_.propertyId_", 1907292161, "int", 344, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target1AnimationTransitionTime_.indexOfLinkedProperty_", 780990098, "int", 348, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target1AnimationTransitionTime_.value_", 778331730, "float", 360, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target2Role_.propertyId_", 603535204, "int", 376, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target2Role_.indexOfLinkedProperty_", 288110737, "int", 380, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target2Role_.value_", 2867033617, "SQEX.Ebony.Std.Fixid", 392, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target2RoleIdx_.propertyId_", 1383071037, "int", 408, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target2RoleIdx_.indexOfLinkedProperty_", 2973796630, "int", 412, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target2RoleIdx_.value_", 2447359110, "int", 424, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target2AnimationTransitionTime_.propertyId_", 3488799268, "int", 440, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target2AnimationTransitionTime_.indexOfLinkedProperty_", 4007602513, "int", 444, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target2AnimationTransitionTime_.value_", 1550537169, "float", 456, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target3Role_.propertyId_", 3739397761, "int", 472, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target3Role_.indexOfLinkedProperty_", 1189502482, "int", 476, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target3Role_.value_", 1296887250, "SQEX.Ebony.Std.Fixid", 488, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target3RoleIdx_.propertyId_", 1244366610, "int", 504, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target3RoleIdx_.indexOfLinkedProperty_", 1021768967, "int", 508, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target3RoleIdx_.value_", 2617759003, "int", 520, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target3AnimationTransitionTime_.propertyId_", 5027887, "int", 536, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target3AnimationTransitionTime_.indexOfLinkedProperty_", 2125151840, "int", 540, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target3AnimationTransitionTime_.value_", 2513179180, "float", 552, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target4Role_.propertyId_", 28016078, "int", 568, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target4Role_.indexOfLinkedProperty_", 3992539499, "int", 572, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target4Role_.value_", 740361919, "SQEX.Ebony.Std.Fixid", 584, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target4RoleIdx_.propertyId_", 747547875, "int", 600, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target4RoleIdx_.indexOfLinkedProperty_", 855279756, "int", 604, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target4RoleIdx_.value_", 767860184, "int", 616, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target4AnimationTransitionTime_.propertyId_", 447820234, "int", 632, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target4AnimationTransitionTime_.indexOfLinkedProperty_", 1961971583, "int", 636, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("target4AnimationTransitionTime_.value_", 3062124995, "float", 648, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("status", 3125508079, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sceneAssetPath_", 1260398091, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString", 88, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("syncTime_", 3367664428, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 144, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ownerRole_", 923291129, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 176, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ownerRoleIdx_", 1838173916, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 208, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ownerAnimationTransitionTime_", 4235658805, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 240, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target1Role_", 3828449120, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 272, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target1RoleIdx_", 1351968659, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 304, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target1AnimationTransitionTime_", 327645942, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 336, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target2Role_", 1326223403, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 368, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target2RoleIdx_", 2877077090, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 400, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target2AnimationTransitionTime_", 3046173803, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 432, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target3Role_", 371423606, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 464, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target3RoleIdx_", 427794029, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 496, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target3AnimationTransitionTime_", 3752074824, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 528, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target4Role_", 1275470425, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 560, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target4RoleIdx_", 1475875836, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 592, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target4AnimationTransitionTime_", 2983651477, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 624, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new BodyLeafNodeRequestLinkAnimation();
        }
		
    }
}