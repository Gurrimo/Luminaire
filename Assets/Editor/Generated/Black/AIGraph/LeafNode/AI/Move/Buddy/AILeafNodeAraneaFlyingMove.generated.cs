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

namespace Black.AIGraph.LeafNode.AI.Move.Buddy
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class AILeafNodeAraneaFlyingMove : Black.AIGraph.LeafNode.AI.Action.AILeafNodeSendMessageBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bUseTargetPosition_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector targetPosition_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector rotation_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat distance_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat speed_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat acceleration_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat maxSpeed_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat minSpeed_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat arrivalDistance_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeout_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bUseTarget_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum state_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat stuckDistance_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeAraneaFlyingMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.Buddy.AILeafNodeAraneaFlyingMove", 0, Black.AIGraph.LeafNode.AI.Move.Buddy.AILeafNodeAraneaFlyingMove.ObjectType, Construct, properties, 0, 816);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.Buddy.AILeafNodeAraneaFlyingMove", base.GetFieldProperties(), -310476700, 1497241839);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bodyMessage_", 2871992657, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bodyMessage_.propertyId_", 1665512566, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bodyMessage_.indexOfLinkedProperty_", 213968595, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bodyMessage_.value_", 3675438519, "SQEX.Ebony.Std.Fixid", 80, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animBBParamId_", 3184568821, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animBBParamId_.propertyId_", 693213610, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animBBParamId_.indexOfLinkedProperty_", 2512565471, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animBBParamId_.value_", 1511527907, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actionType_", 3416588776, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actionType_.propertyId_", 2216911823, "int", 128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actionType_.indexOfLinkedProperty_", 1950809856, "int", 132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actionType_.value_", 2585656972, "int", 144, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkBodyCanRecieveMessage_", 227899608, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkBodyCanRecieveMessage_.propertyId_", 36675359, "int", 160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkBodyCanRecieveMessage_.indexOfLinkedProperty_", 3905631440, "int", 164, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkBodyCanRecieveMessage_.value_", 1870054204, "bool", 176, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("messageTimer", 2433886869, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("messageTimer.propertyId_", 3655914442, "int", 192, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("messageTimer.indexOfLinkedProperty_", 4003235199, "int", 196, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("messageTimer.value_", 3411412931, "float", 208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bUseTargetPosition_.propertyId_", 280809168, "int", 232, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bUseTargetPosition_.indexOfLinkedProperty_", 1972139237, "int", 236, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bUseTargetPosition_.value_", 4209838373, "bool", 248, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetPosition_.propertyId_", 2390505235, "int", 264, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetPosition_.indexOfLinkedProperty_", 2148759292, "int", 268, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetPosition_.value_", 1942802280, "Luminous.Math.VectorA", 288, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_.propertyId_", 2849005399, "int", 328, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_.indexOfLinkedProperty_", 1664614408, "int", 332, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_.value_", 807424676, "Luminous.Math.VectorA", 352, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("distance_.propertyId_", 287175168, "int", 392, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("distance_.indexOfLinkedProperty_", 2625758549, "int", 396, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("distance_.value_", 1949025525, "float", 408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("speed_.propertyId_", 1693317426, "int", 424, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("speed_.indexOfLinkedProperty_", 2861919015, "int", 428, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("speed_.value_", 3685740667, "float", 440, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("acceleration_.propertyId_", 1231450065, "int", 456, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("acceleration_.indexOfLinkedProperty_", 1355990626, "int", 460, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("acceleration_.value_", 1734031234, "float", 472, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxSpeed_.propertyId_", 288994822, "int", 488, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxSpeed_.indexOfLinkedProperty_", 3182723683, "int", 492, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxSpeed_.value_", 111087143, "float", 504, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("minSpeed_.propertyId_", 1217587680, "int", 520, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("minSpeed_.indexOfLinkedProperty_", 1796651061, "int", 524, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("minSpeed_.value_", 476767765, "float", 536, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("arrivalDistance_.propertyId_", 652682765, "int", 552, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("arrivalDistance_.indexOfLinkedProperty_", 3634203494, "int", 556, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("arrivalDistance_.value_", 2532234486, "float", 568, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeout_.propertyId_", 476365610, "int", 584, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeout_.indexOfLinkedProperty_", 2241916255, "int", 588, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeout_.value_", 809447011, "float", 600, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bUseTarget_.propertyId_", 3832156337, "int", 616, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bUseTarget_.indexOfLinkedProperty_", 62067778, "int", 620, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bUseTarget_.value_", 1445103906, "bool", 632, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetSlotType_.propertyId_", 148178158, "int", 648, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetSlotType_.indexOfLinkedProperty_", 1898007691, "int", 652, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetSlotType_.value_", 340910751, "int", 664, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("state_.propertyId_", 2351031364, "int", 680, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("state_.indexOfLinkedProperty_", 1317310449, "int", 684, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("state_.value_", 1432533297, "int", 696, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("stuckDistance_.propertyId_", 2517810406, "int", 712, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("stuckDistance_.indexOfLinkedProperty_", 1053810371, "int", 716, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("stuckDistance_.value_", 1648606151, "float", 728, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("bUseTargetPosition_", 1228475831, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 224, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetPosition_", 3810869004, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector", 256, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotation_", 36328192, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector", 320, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("distance_", 3236486151, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 384, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("speed_", 1253745677, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 416, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("acceleration_", 3154509670, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 448, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxSpeed_", 3235919937, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 480, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("minSpeed_", 3377264999, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 512, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("arrivalDistance_", 1191306130, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 544, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeout_", 269585269, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 576, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bUseTarget_", 1216415302, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 608, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetSlotType_", 102733177, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 640, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("state_", 3732062219, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 672, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("stuckDistance_", 3212067361, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 704, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AILeafNodeAraneaFlyingMove();
        }
		
    }
}