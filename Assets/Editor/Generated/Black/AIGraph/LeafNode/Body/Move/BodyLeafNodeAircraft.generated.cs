using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body.Move
{
    public partial class BodyLeafNodeAircraft : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt mode_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt actionType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat finishDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat targetUpdateDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat horizontalSpeed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat verticalSpeed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeOut_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeAircraft();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeAircraft", 0, Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeAircraft.ObjectType, Construct, properties, 0, 296);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeAircraft", base.GetFieldProperties(), -846461479, -593490724);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("mode_.propertyId_", 628687440, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("mode_.indexOfLinkedProperty_", 3820903269, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("mode_.value_", 2332053413, "int", 80, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actionType_.propertyId_", 2216911823, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actionType_.indexOfLinkedProperty_", 1950809856, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actionType_.value_", 2585656972, "int", 112, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishDistance_.propertyId_", 216417005, "int", 128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishDistance_.indexOfLinkedProperty_", 1648170438, "int", 132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishDistance_.value_", 2268939030, "float", 144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetUpdateDistance_.propertyId_", 3084599956, "int", 160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetUpdateDistance_.indexOfLinkedProperty_", 244990401, "int", 164, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetUpdateDistance_.value_", 3854978465, "float", 176, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("horizontalSpeed_.propertyId_", 2826997782, "int", 192, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("horizontalSpeed_.indexOfLinkedProperty_", 197107443, "int", 196, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("horizontalSpeed_.value_", 2019885463, "float", 208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("verticalSpeed_.propertyId_", 775641460, "int", 224, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("verticalSpeed_.indexOfLinkedProperty_", 2080546209, "int", 228, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("verticalSpeed_.value_", 2520592065, "float", 240, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeOut_.propertyId_", 1122890314, "int", 256, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeOut_.indexOfLinkedProperty_", 3737019647, "int", 260, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeOut_.value_", 1517881155, "float", 272, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("mode_", 2139822391, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actionType_", 3416588776, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("finishDistance_", 2199296114, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetUpdateDistance_", 3484581819, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("horizontalSpeed_", 4238817521, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("verticalSpeed_", 1553123099, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 216, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeOut_", 3487830293, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 248, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new BodyLeafNodeAircraft();
        }
		
    }
}