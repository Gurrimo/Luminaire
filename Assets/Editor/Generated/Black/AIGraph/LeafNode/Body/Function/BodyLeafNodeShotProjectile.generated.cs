using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body.Function
{
    public partial class BodyLeafNodeShotProjectile : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid attackID;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isUseMessage;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isUseRecoiling;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum recoilAimControlID_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeShotProjectile();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.Function.BodyLeafNodeShotProjectile", 0, Black.AIGraph.LeafNode.Body.Function.BodyLeafNodeShotProjectile.ObjectType, Construct, properties, 0, 192);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.Function.BodyLeafNodeShotProjectile", base.GetFieldProperties(), -501115536, -142222817);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("attackID.propertyId_", 2048315567, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("attackID.indexOfLinkedProperty_", 4055505888, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("attackID.value_", 1468043180, "SQEX.Ebony.Std.Fixid", 80, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isUseMessage.propertyId_", 2265908940, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isUseMessage.indexOfLinkedProperty_", 1903470681, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isUseMessage.value_", 3959357257, "bool", 112, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isUseRecoiling.propertyId_", 1616429673, "int", 128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isUseRecoiling.indexOfLinkedProperty_", 4092066234, "int", 132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isUseRecoiling.value_", 3657043594, "bool", 144, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("recoilAimControlID_.propertyId_", 1670953406, "int", 160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("recoilAimControlID_.indexOfLinkedProperty_", 2039283163, "int", 164, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("recoilAimControlID_.value_", 3664831375, "int", 176, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("attackID", 3386253000, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseMessage", 322328995, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseRecoiling", 3232321390, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("recoilAimControlID_", 385632873, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new BodyLeafNodeShotProjectile();
        }
		
    }
}