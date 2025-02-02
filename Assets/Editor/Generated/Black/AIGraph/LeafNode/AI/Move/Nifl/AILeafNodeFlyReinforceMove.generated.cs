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

namespace Black.AIGraph.LeafNode.AI.Move.Nifl
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class AILeafNodeFlyReinforceMove : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat goalHeightOffset_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat goalOffsetHorizonal_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat destinationUpdateTime_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool forceUseReinforceDestination_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool noUpdateReinfoceDestination_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid queryFixid_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat descendingPointLockDistance_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat destinationRefreshTime_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat destinationRefreshDistance_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt combatEnemiesObservationModeCount_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt();
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool ignoreObservationMode_= new SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeFlyReinforceMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeFlyReinforceMove", 0, Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeFlyReinforceMove.ObjectType, Construct, properties, 0, 1136);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeFlyReinforceMove", base.GetFieldProperties(), 247789990, -1131115834);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("urgency", 4087552372, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("urgency.propertyId_", 3859855947, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("urgency.indexOfLinkedProperty_", 1213480276, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("urgency.value_", 1928198832, "int", 80, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("desiredMoveSpeed", 1691109583, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("desiredMoveSpeed.propertyId_", 1552181272, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("desiredMoveSpeed.indexOfLinkedProperty_", 3227436621, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("desiredMoveSpeed.value_", 1428956765, "int", 112, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxMoveSpeed", 2868419347, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxMoveSpeed.propertyId_", 1129499804, "int", 128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxMoveSpeed.indexOfLinkedProperty_", 1696924457, "int", 132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxMoveSpeed.value_", 4233070265, "int", 144, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxMoveSpeedDetailed", 493539667, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxMoveSpeedDetailed.propertyId_", 2466999644, "int", 160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxMoveSpeedDetailed.indexOfLinkedProperty_", 2823671017, "int", 164, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxMoveSpeedDetailed.value_", 1210693497, "float", 176, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("desiredArrivalSpeed", 2631783413, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("desiredArrivalSpeed.propertyId_", 2503386026, "int", 192, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("desiredArrivalSpeed.indexOfLinkedProperty_", 640312031, "int", 196, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("desiredArrivalSpeed.value_", 3105375203, "int", 208, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("arrivalMoveSpeed", 4172512298, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 216, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("arrivalMoveSpeed.propertyId_", 4162717397, "int", 224, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("arrivalMoveSpeed.indexOfLinkedProperty_", 1277206862, "int", 228, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("arrivalMoveSpeed.value_", 1496056590, "float", 240, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("atLocationRequirement", 1164093018, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 248, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("atLocationRequirement.propertyId_", 1153851813, "int", 256, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("atLocationRequirement.indexOfLinkedProperty_", 2070188382, "int", 260, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("atLocationRequirement.value_", 195269758, "int", 272, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isUseLookAtTarget", 1074173611, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 280, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isUseLookAtTarget.propertyId_", 3031201252, "int", 288, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isUseLookAtTarget.indexOfLinkedProperty_", 1857910801, "int", 292, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isUseLookAtTarget.value_", 4074624401, "bool", 304, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lookAtTargetSlotType", 2064526498, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 312, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lookAtTargetSlotType.propertyId_", 4259419645, "int", 320, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lookAtTargetSlotType.indexOfLinkedProperty_", 1440127958, "int", 324, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lookAtTargetSlotType.value_", 1151447110, "int", 336, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeout", 2549515144, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 344, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeout.propertyId_", 1014648559, "int", 352, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeout.indexOfLinkedProperty_", 311787552, "int", 356, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeout.value_", 3546920172, "float", 368, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moveReleaseDelay", 1525506060, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 376, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moveReleaseDelay.propertyId_", 372934675, "int", 384, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moveReleaseDelay.indexOfLinkedProperty_", 108302844, "int", 388, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moveReleaseDelay.value_", 3319868008, "int", 400, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moveMode", 494186615, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 408, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moveMode.propertyId_", 2296314128, "int", 416, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moveMode.indexOfLinkedProperty_", 1535183141, "int", 420, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moveMode.value_", 4253764965, "int", 432, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("excludeTargetForAvoidance", 2730651779, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 440, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("excludeTargetForAvoidance.propertyId_", 1302905516, "int", 448, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("excludeTargetForAvoidance.indexOfLinkedProperty_", 450960697, "int", 452, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("excludeTargetForAvoidance.value_", 2335317993, "bool", 464, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("avoidOnIdle", 3264340485, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 472, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("avoidOnIdle.propertyId_", 2993586394, "int", 480, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("avoidOnIdle.indexOfLinkedProperty_", 78938895, "int", 484, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("avoidOnIdle.value_", 1308321843, "int", 496, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("goalHeightOffset_.propertyId_", 1180047248, "int", 576, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("goalHeightOffset_.indexOfLinkedProperty_", 97052837, "int", 580, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("goalHeightOffset_.value_", 3511962853, "float", 592, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("goalOffsetHorizonal_.propertyId_", 1365120221, "int", 608, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("goalOffsetHorizonal_.indexOfLinkedProperty_", 2546484406, "int", 612, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("goalOffsetHorizonal_.value_", 1049836646, "float", 624, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("destinationUpdateTime_.propertyId_", 3524598799, "int", 640, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("destinationUpdateTime_.indexOfLinkedProperty_", 3083237952, "int", 644, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("destinationUpdateTime_.value_", 3684090316, "float", 656, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("forceUseReinforceDestination_.propertyId_", 1883833802, "int", 672, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("forceUseReinforceDestination_.indexOfLinkedProperty_", 1341123455, "int", 676, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("forceUseReinforceDestination_.value_", 409202115, "bool", 688, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("noUpdateReinfoceDestination_.propertyId_", 706165084, "int", 704, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("noUpdateReinfoceDestination_.indexOfLinkedProperty_", 3896185065, "int", 708, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("noUpdateReinfoceDestination_.value_", 2088631161, "bool", 720, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("queryFixid_.propertyId_", 1196039163, "int", 736, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("queryFixid_.indexOfLinkedProperty_", 2585005892, "int", 740, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("queryFixid_.value_", 1101753728, "SQEX.Ebony.Std.Fixid", 752, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("descendingPointLockDistance_.propertyId_", 748466591, "int", 768, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("descendingPointLockDistance_.indexOfLinkedProperty_", 2786136144, "int", 772, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("descendingPointLockDistance_.value_", 1686552252, "float", 784, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("destinationRefreshTime_.propertyId_", 3691982731, "int", 800, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("destinationRefreshTime_.indexOfLinkedProperty_", 2653952660, "int", 804, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("destinationRefreshTime_.value_", 3697347056, "float", 816, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("destinationRefreshDistance_.propertyId_", 2905276317, "int", 832, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("destinationRefreshDistance_.indexOfLinkedProperty_", 3715696246, "int", 836, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("destinationRefreshDistance_.value_", 1259325990, "float", 848, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("combatEnemiesObservationModeCount_.propertyId_", 2739073663, "int", 864, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("combatEnemiesObservationModeCount_.indexOfLinkedProperty_", 1730803248, "int", 868, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("combatEnemiesObservationModeCount_.value_", 3511679452, "int", 880, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("ignoreObservationMode_.propertyId_", 3892364542, "int", 896, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("ignoreObservationMode_.indexOfLinkedProperty_", 3439218971, "int", 900, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("ignoreObservationMode_.value_", 4043993295, "bool", 912, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("goalHeightOffset_", 2639828727, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 568, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("goalOffsetHorizonal_", 1465071618, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 600, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("destinationUpdateTime_", 3239339432, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 632, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("forceUseReinforceDestination_", 2599091349, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 664, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noUpdateReinfoceDestination_", 787242323, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 696, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("queryFixid_", 264473220, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 728, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("descendingPointLockDistance_", 1466274648, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 760, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("destinationRefreshTime_", 2947351604, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 792, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("destinationRefreshDistance_", 641800514, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 824, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("combatEnemiesObservationModeCount_", 2954933688, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 856, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ignoreObservationMode_", 1763367721, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 888, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AILeafNodeFlyReinforceMove();
        }
		
    }
}