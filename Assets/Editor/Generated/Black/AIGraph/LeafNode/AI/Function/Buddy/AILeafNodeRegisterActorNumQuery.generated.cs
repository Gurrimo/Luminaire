using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function.Buddy
{
    public partial class AILeafNodeRegisterActorNumQuery : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt queryIndex;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum distType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum distTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat minDistance;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat maxDistance;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum angleType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum angleTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum startDirection;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat startAngle;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum endDirection;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat endAngle;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkEnemyA;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkEnemyB;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkEnemyC;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkEnemyD;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkNoctis;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkBuddy;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeRegisterActorNumQuery();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.Buddy.AILeafNodeRegisterActorNumQuery", 0, Black.AIGraph.LeafNode.AI.Function.Buddy.AILeafNodeRegisterActorNumQuery.ObjectType, Construct, properties, 0, 600);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.Buddy.AILeafNodeRegisterActorNumQuery", base.GetFieldProperties(), 2028584718, 64550806);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("queryIndex.propertyId_", 2834806126, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("queryIndex.indexOfLinkedProperty_", 1752543755, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("queryIndex.value_", 2186930207, "int", 80, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("distType.propertyId_", 552592934, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("distType.indexOfLinkedProperty_", 1248692995, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("distType.value_", 4280220935, "int", 112, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("distTarget.propertyId_", 1898585123, "int", 128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("distTarget.indexOfLinkedProperty_", 2916475596, "int", 132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("distTarget.value_", 317197080, "int", 144, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("minDistance.propertyId_", 2128237223, "int", 160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("minDistance.indexOfLinkedProperty_", 2410105176, "int", 164, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("minDistance.value_", 1914765588, "float", 176, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxDistance.propertyId_", 3100292897, "int", 192, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxDistance.indexOfLinkedProperty_", 3023754162, "int", 196, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxDistance.value_", 134739378, "float", 208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("angleType.propertyId_", 3048952231, "int", 224, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("angleType.indexOfLinkedProperty_", 1476435544, "int", 228, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("angleType.value_", 1514870292, "int", 240, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("angleTarget.propertyId_", 2097638214, "int", 256, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("angleTarget.indexOfLinkedProperty_", 4020614051, "int", 260, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("angleTarget.value_", 948316007, "int", 272, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startDirection.propertyId_", 1801482559, "int", 288, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startDirection.indexOfLinkedProperty_", 2718450928, "int", 292, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startDirection.value_", 2332871068, "int", 304, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startAngle.propertyId_", 1219217985, "int", 320, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startAngle.indexOfLinkedProperty_", 3894901970, "int", 324, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startAngle.value_", 3135562898, "float", 336, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endDirection.propertyId_", 1320840120, "int", 352, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endDirection.indexOfLinkedProperty_", 2679642221, "int", 356, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endDirection.value_", 4124193085, "int", 368, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endAngle.propertyId_", 2013044286, "int", 384, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endAngle.indexOfLinkedProperty_", 979574619, "int", 388, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endAngle.value_", 1406379279, "float", 400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkEnemyA.propertyId_", 1125974067, "int", 416, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkEnemyA.indexOfLinkedProperty_", 3579610268, "int", 420, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkEnemyA.value_", 235436616, "bool", 432, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkEnemyB.propertyId_", 2966743098, "int", 448, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkEnemyB.indexOfLinkedProperty_", 1780884079, "int", 452, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkEnemyB.value_", 3161819987, "bool", 464, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkEnemyC.propertyId_", 2936531277, "int", 480, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkEnemyC.indexOfLinkedProperty_", 345300646, "int", 484, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkEnemyC.value_", 1910304566, "bool", 496, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkEnemyD.propertyId_", 4080500220, "int", 512, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkEnemyD.indexOfLinkedProperty_", 456852617, "int", 516, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkEnemyD.value_", 1403766489, "bool", 528, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkNoctis.propertyId_", 1104110872, "int", 544, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkNoctis.indexOfLinkedProperty_", 1906492749, "int", 548, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkNoctis.value_", 1742890333, "bool", 560, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkBuddy.propertyId_", 2187558330, "int", 576, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkBuddy.indexOfLinkedProperty_", 1730248431, "int", 580, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkBuddy.value_", 912836563, "bool", 592, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("queryIndex", 2825235961, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("distType", 1816005345, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("distTarget", 2390028988, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("minDistance", 2940658544, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxDistance", 1654243094, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("angleType", 4161737328, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 216, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("angleTarget", 1930699009, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 248, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startDirection", 1384315384, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 280, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startAngle", 3663374774, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 312, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endDirection", 349937775, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 344, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endAngle", 2845693673, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 376, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkEnemyA", 3304042540, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 408, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkEnemyB", 3354375397, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 440, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkEnemyC", 3337597778, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 472, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkEnemyD", 3253709683, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 504, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkNoctis", 1212995023, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 536, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkBuddy", 651412069, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 568, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AILeafNodeRegisterActorNumQuery();
        }
		
    }
}