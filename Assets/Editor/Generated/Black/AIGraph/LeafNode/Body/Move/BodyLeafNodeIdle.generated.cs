//----------------------
// <auto-generated>
// This file was automatically generated. Any changes to it will be lost if and when the file is regenerated.
// </auto-generated>
//----------------------
#pragma warning disable

using System;
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;
using CodeDom = System.CodeDom;

namespace Black.AIGraph.LeafNode.Body.Move
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class BodyLeafNodeIdle : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeForMaskingNextTurn= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeForMaskingMove= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat thresholdMoveBeginVelocity= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeIdle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeIdle", 0, Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeIdle.ObjectType, Construct, properties, 0, 160);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeIdle", base.GetFieldProperties(), -1416090386, 740873848);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeForMaskingNextTurn.propertyId_", 1562248644, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeForMaskingNextTurn.indexOfLinkedProperty_", 1249407089, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeForMaskingNextTurn.value_", 2103802289, "float", 80, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeForMaskingMove.propertyId_", 1767157295, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeForMaskingMove.indexOfLinkedProperty_", 1167233120, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeForMaskingMove.value_", 2354766892, "float", 112, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("thresholdMoveBeginVelocity.propertyId_", 3955689554, "int", 128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("thresholdMoveBeginVelocity.indexOfLinkedProperty_", 3367714887, "int", 132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("thresholdMoveBeginVelocity.value_", 1532774747, "float", 144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("timeForMaskingNextTurn", 480647563, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeForMaskingMove", 2652107848, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("thresholdMoveBeginVelocity", 452706093, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new BodyLeafNodeIdle();
        }
		
    }
}