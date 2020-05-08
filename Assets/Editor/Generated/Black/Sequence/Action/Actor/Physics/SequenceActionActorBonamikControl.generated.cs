using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Physics
{
    public partial class SequenceActionActorBonamikControl : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startSimPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopSimPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pauseSimPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin resetSimPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin preRollPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOnAnimBlendPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOffAnimBlendPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin changeLocalForceParamsPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOnGroundPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOffGroundPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOnWindPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOffWindPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOnConePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOffConePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOnSphereConstraintPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOffSphereConstraintPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setGravityPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOnKinematicPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOffKinematicPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setEmissiveWindPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setDampingScalePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setInnerConeScalePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setOuterConeScalePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setLocalForceScalePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOnConeAnimationPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOffConeAnimationPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setAddMassPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reinitializePosePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin restoreParameterPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorsPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool ResetPose_;
		public float animationBlendCoeff_;
		public int preRollStep_;
		public int blendedFrames_;
		public UnityEngine.Vector4 gravity_;
		public int selectGroup_;
		public float addMass_;
		public float dampingScale_;
		public float innerConeScale_;
		public float outerConeScale_;
		public float localForceScale_;
		public float LocalForceOverallScale_;
		public float LocalForceCoeff_;
		public float DynamicParkRate_;
		public float MaxLocalTranslate_;
		public float emissiveWindStr_;
		public float emissiveWindWaveAmplitude_;
		public float emissiveWindWaveTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorBonamikControl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikControl", 0, Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikControl.ObjectType, Construct, properties, 0, 3248);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikControl", base.GetFieldProperties(), -1248098145, 813145794);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startSimPin_.pinName_", 1672002985, "Base.String", 192, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startSimPin_.name_", 3624977140, "Base.String", 208, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startSimPin_.connections_", 1022616138, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 224, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("startSimPin_.delayType_", 996820472, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 256, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startSimPin_.delayTime_", 269831219, "float", 260, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startSimPin_.delayMaxTime_", 3934689515, "float", 264, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("stopSimPin_.pinName_", 3038893435, "Base.String", 288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("stopSimPin_.name_", 201061750, "Base.String", 304, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("stopSimPin_.connections_", 1418961548, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 320, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("stopSimPin_.delayType_", 664539010, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 352, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("stopSimPin_.delayTime_", 2348969861, "float", 356, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("stopSimPin_.delayMaxTime_", 1642403617, "float", 360, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pauseSimPin_.pinName_", 4243420339, "Base.String", 384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pauseSimPin_.name_", 2274002398, "Base.String", 400, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pauseSimPin_.connections_", 2004620100, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 416, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pauseSimPin_.delayType_", 1663671594, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 448, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pauseSimPin_.delayTime_", 3082439677, "float", 452, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pauseSimPin_.delayMaxTime_", 1498807689, "float", 456, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resetSimPin_.pinName_", 3902238774, "Base.String", 480, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resetSimPin_.name_", 3601626625, "Base.String", 496, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resetSimPin_.connections_", 2597145697, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 512, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("resetSimPin_.delayType_", 2012595707, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 544, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resetSimPin_.delayTime_", 3440047792, "float", 548, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("resetSimPin_.delayMaxTime_", 2439668282, "float", 552, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("preRollPin_.pinName_", 3964922372, "Base.String", 576, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("preRollPin_.name_", 3110676511, "Base.String", 592, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("preRollPin_.connections_", 192004047, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 608, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("preRollPin_.delayType_", 2269086329, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 640, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("preRollPin_.delayTime_", 3424016830, "float", 644, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("preRollPin_.delayMaxTime_", 1597713108, "float", 648, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnAnimBlendPin_.pinName_", 2949675260, "Base.String", 672, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnAnimBlendPin_.name_", 3517378215, "Base.String", 688, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnAnimBlendPin_.connections_", 4258115175, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 704, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnAnimBlendPin_.delayType_", 652624545, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 736, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnAnimBlendPin_.delayTime_", 2957771798, "float", 740, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnAnimBlendPin_.delayMaxTime_", 1947407292, "float", 744, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffAnimBlendPin_.pinName_", 301067584, "Base.String", 768, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffAnimBlendPin_.name_", 3135998251, "Base.String", 784, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffAnimBlendPin_.connections_", 432347235, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 800, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffAnimBlendPin_.delayType_", 3590917837, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 832, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffAnimBlendPin_.delayTime_", 1530330714, "float", 836, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffAnimBlendPin_.delayMaxTime_", 3809016992, "float", 840, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changeLocalForceParamsPin_.pinName_", 3464088404, "Base.String", 864, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changeLocalForceParamsPin_.name_", 2014042287, "Base.String", 880, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changeLocalForceParamsPin_.connections_", 2407413695, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 896, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("changeLocalForceParamsPin_.delayType_", 157370473, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 928, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changeLocalForceParamsPin_.delayTime_", 2228089070, "float", 932, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("changeLocalForceParamsPin_.delayMaxTime_", 513775876, "float", 936, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnGroundPin_.pinName_", 4036726147, "Base.String", 960, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnGroundPin_.name_", 1217577006, "Base.String", 976, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnGroundPin_.connections_", 2648405364, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 992, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnGroundPin_.delayType_", 838969818, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1024, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnGroundPin_.delayTime_", 1331607213, "float", 1028, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnGroundPin_.delayMaxTime_", 2987288121, "float", 1032, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffGroundPin_.pinName_", 642558471, "Base.String", 1056, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffGroundPin_.name_", 1511869234, "Base.String", 1072, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffGroundPin_.connections_", 3867461280, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1088, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffGroundPin_.delayType_", 1118862262, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1120, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffGroundPin_.delayTime_", 1458387009, "float", 1124, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffGroundPin_.delayMaxTime_", 3892949277, "float", 1128, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnWindPin_.pinName_", 2194742920, "Base.String", 1152, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnWindPin_.name_", 1895612259, "Base.String", 1168, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnWindPin_.connections_", 1589638763, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1184, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnWindPin_.delayType_", 656803045, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1216, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnWindPin_.delayTime_", 1658620898, "float", 1220, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnWindPin_.delayMaxTime_", 1755551160, "float", 1224, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffWindPin_.pinName_", 154358908, "Base.String", 1248, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffWindPin_.name_", 726323495, "Base.String", 1264, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffWindPin_.connections_", 4217553383, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1280, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffWindPin_.delayType_", 2752334369, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1312, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffWindPin_.delayTime_", 762514326, "float", 1316, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffWindPin_.delayMaxTime_", 633390652, "float", 1320, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnConePin_.pinName_", 3749287195, "Base.String", 1344, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnConePin_.name_", 672081494, "Base.String", 1360, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnConePin_.connections_", 888659308, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1376, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnConePin_.delayType_", 2152027298, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1408, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnConePin_.delayTime_", 1264568613, "float", 1412, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnConePin_.delayMaxTime_", 1319296257, "float", 1416, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffConePin_.pinName_", 4252103167, "Base.String", 1440, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffConePin_.name_", 3887435546, "Base.String", 1456, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffConePin_.connections_", 442660792, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1472, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffConePin_.delayType_", 2791622654, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1504, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffConePin_.delayTime_", 762480761, "float", 1508, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffConePin_.delayMaxTime_", 3390462437, "float", 1512, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnSphereConstraintPin_.pinName_", 3276079176, "Base.String", 1536, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnSphereConstraintPin_.name_", 2475363875, "Base.String", 1552, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnSphereConstraintPin_.connections_", 3492554795, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1568, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnSphereConstraintPin_.delayType_", 3449761189, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1600, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnSphereConstraintPin_.delayTime_", 539389346, "float", 1604, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnSphereConstraintPin_.delayMaxTime_", 480798840, "float", 1608, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffSphereConstraintPin_.pinName_", 3797628284, "Base.String", 1632, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffSphereConstraintPin_.name_", 3820278823, "Base.String", 1648, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffSphereConstraintPin_.connections_", 3815224039, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1664, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffSphereConstraintPin_.delayType_", 2023920417, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1696, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffSphereConstraintPin_.delayTime_", 34100374, "float", 1700, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffSphereConstraintPin_.delayMaxTime_", 1703422268, "float", 1704, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setGravityPin_.pinName_", 3221680818, "Base.String", 1728, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setGravityPin_.name_", 2676914797, "Base.String", 1744, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setGravityPin_.connections_", 3350102357, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1760, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("setGravityPin_.delayType_", 2264196191, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1792, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setGravityPin_.delayTime_", 2147477580, "float", 1796, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setGravityPin_.delayMaxTime_", 715170166, "float", 1800, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnKinematicPin_.pinName_", 355522331, "Base.String", 1824, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnKinematicPin_.name_", 3135876182, "Base.String", 1840, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnKinematicPin_.connections_", 929120108, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1856, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnKinematicPin_.delayType_", 1642292898, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1888, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnKinematicPin_.delayTime_", 754834213, "float", 1892, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnKinematicPin_.delayMaxTime_", 445129473, "float", 1896, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffKinematicPin_.pinName_", 849976879, "Base.String", 1920, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffKinematicPin_.name_", 2371073994, "Base.String", 1936, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffKinematicPin_.connections_", 2820423368, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1952, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffKinematicPin_.delayType_", 492436110, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1984, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffKinematicPin_.delayTime_", 3632369737, "float", 1988, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffKinematicPin_.delayMaxTime_", 387789301, "float", 1992, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setEmissiveWindPin_.pinName_", 1983005969, "Base.String", 2016, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setEmissiveWindPin_.name_", 1779917516, "Base.String", 2032, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setEmissiveWindPin_.connections_", 542824274, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2048, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("setEmissiveWindPin_.delayType_", 2339658544, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2080, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setEmissiveWindPin_.delayTime_", 2480156187, "float", 2084, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setEmissiveWindPin_.delayMaxTime_", 1028682691, "float", 2088, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setDampingScalePin_.pinName_", 520726566, "Base.String", 2112, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setDampingScalePin_.name_", 504084081, "Base.String", 2128, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setDampingScalePin_.connections_", 2281790705, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2144, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("setDampingScalePin_.delayType_", 4268569611, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2176, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setDampingScalePin_.delayTime_", 851998336, "float", 2180, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setDampingScalePin_.delayMaxTime_", 3257736330, "float", 2184, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setInnerConeScalePin_.pinName_", 1154012839, "Base.String", 2208, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setInnerConeScalePin_.name_", 1244491154, "Base.String", 2224, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setInnerConeScalePin_.connections_", 3036130816, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2240, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("setInnerConeScalePin_.delayType_", 2132942038, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2272, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setInnerConeScalePin_.delayTime_", 749389025, "float", 2276, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setInnerConeScalePin_.delayMaxTime_", 4135250813, "float", 2280, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setOuterConeScalePin_.pinName_", 3351055668, "Base.String", 2304, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setOuterConeScalePin_.name_", 2440735567, "Base.String", 2320, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setOuterConeScalePin_.connections_", 2098418911, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2336, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("setOuterConeScalePin_.delayType_", 718231113, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2368, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setOuterConeScalePin_.delayTime_", 2322915534, "float", 2372, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setOuterConeScalePin_.delayMaxTime_", 4085839012, "float", 2376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setLocalForceScalePin_.pinName_", 1643640208, "Base.String", 2400, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setLocalForceScalePin_.name_", 1154947067, "Base.String", 2416, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setLocalForceScalePin_.connections_", 1615626899, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2432, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("setLocalForceScalePin_.delayType_", 2084759165, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2464, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setLocalForceScalePin_.delayTime_", 2233940810, "float", 2468, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setLocalForceScalePin_.delayMaxTime_", 1241645776, "float", 2472, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnConeAnimationPin_.pinName_", 1887633845, "Base.String", 2496, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnConeAnimationPin_.name_", 622247920, "Base.String", 2512, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnConeAnimationPin_.connections_", 1474383934, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2528, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnConeAnimationPin_.delayType_", 4068553516, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2560, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnConeAnimationPin_.delayTime_", 1841135327, "float", 2564, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOnConeAnimationPin_.delayMaxTime_", 4189820711, "float", 2568, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffConeAnimationPin_.pinName_", 3492581321, "Base.String", 2592, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffConeAnimationPin_.name_", 1564136916, "Base.String", 2608, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffConeAnimationPin_.connections_", 2103173674, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2624, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffConeAnimationPin_.delayType_", 1325248408, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2656, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffConeAnimationPin_.delayTime_", 173801683, "float", 2660, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnOffConeAnimationPin_.delayMaxTime_", 3323740619, "float", 2664, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setAddMassPin_.pinName_", 969045017, "Base.String", 2688, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setAddMassPin_.name_", 3047141156, "Base.String", 2704, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setAddMassPin_.connections_", 1546849242, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2720, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("setAddMassPin_.delayType_", 3491372552, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2752, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setAddMassPin_.delayTime_", 2267143363, "float", 2756, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setAddMassPin_.delayMaxTime_", 389586491, "float", 2760, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("reinitializePosePin_.pinName_", 4155578322, "Base.String", 2784, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("reinitializePosePin_.name_", 469065549, "Base.String", 2800, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("reinitializePosePin_.connections_", 3508969653, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2816, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("reinitializePosePin_.delayType_", 3661881727, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2848, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("reinitializePosePin_.delayTime_", 3586739820, "float", 2852, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("reinitializePosePin_.delayMaxTime_", 1186695638, "float", 2856, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("restoreParameterPin_.pinName_", 293552923, "Base.String", 2880, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("restoreParameterPin_.name_", 2640670806, "Base.String", 2896, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("restoreParameterPin_.connections_", 3576327020, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 2912, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("restoreParameterPin_.delayType_", 361083554, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 2944, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("restoreParameterPin_.delayTime_", 3768592165, "float", 2948, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("restoreParameterPin_.delayMaxTime_", 2117625601, "float", 2952, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actorsPin_.pinName_", 972756002, "Base.String", 2976, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actorsPin_.name_", 3502262173, "Base.String", 2992, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actorsPin_.connections_", 3123165861, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 3008, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("actorsPin_.pinValueType_", 1203937860, "Base.String", 3040, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.pinName_", 1137295951, "Base.String", 3064, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.name_", 2182257194, "Base.String", 3080, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.connections_", 2048532136, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 3096, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayType_", 124432558, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 3128, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayTime_", 3264366185, "float", 3132, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayMaxTime_", 456551125, "float", 3136, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("startSimPin_", 1294034958, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("stopSimPin_", 3631840148, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 280, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pauseSimPin_", 2978561724, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 376, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("resetSimPin_", 2395232083, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 472, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("preRollPin_", 3865747925, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 568, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOnAnimBlendPin_", 2425811133, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 664, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOffAnimBlendPin_", 2688168505, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 760, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("changeLocalForceParamsPin_", 3286972869, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 856, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOnGroundPin_", 2668560428, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 952, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOffGroundPin_", 4174190216, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1048, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOnWindPin_", 1402661009, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1144, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOffWindPin_", 164857661, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1240, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOnConePin_", 2820045364, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1336, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOffConePin_", 2206153296, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1432, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOnSphereConstraintPin_", 3260054225, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1528, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOffSphereConstraintPin_", 1130127933, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1624, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("setGravityPin_", 859585687, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1720, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOnKinematicPin_", 4160925748, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1816, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOffKinematicPin_", 2476999392, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1912, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("setEmissiveWindPin_", 952513414, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2008, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("setDampingScalePin_", 463985187, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2104, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("setInnerConeScalePin_", 2673966376, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2200, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("setOuterConeScalePin_", 2252916901, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2296, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("setLocalForceScalePin_", 1601672873, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2392, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOnConeAnimationPin_", 2207187506, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2488, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOffConeAnimationPin_", 3247098030, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2584, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("setAddMassPin_", 1346385566, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2680, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("reinitializePosePin_", 3287745847, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2776, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("restoreParameterPin_", 3006633012, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2872, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorsPin_", 3366497575, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2968, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 3056, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ResetPose_", 3696248214, "bool", 3152, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("animationBlendCoeff_", 2096144374, "float", 3156, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("preRollStep_", 2689838500, "int", 3160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("blendedFrames_", 1011153196, "int", 3164, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("gravity_", 3216807406, "Luminous.Math.VectorA", 3168, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("selectGroup_", 307161457, "Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikControl.eBONAMIKSELECTGROUP", 3184, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("addMass_", 4288545305, "float", 3188, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("dampingScale_", 1718241498, "float", 3192, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("innerConeScale_", 646225783, "float", 3196, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("outerConeScale_", 2935093024, "float", 3200, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("localForceScale_", 26593156, "float", 3204, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("LocalForceOverallScale_", 2076223703, "float", 3208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("LocalForceCoeff_", 1453812889, "float", 3212, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("DynamicParkRate_", 1732236129, "float", 3216, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("MaxLocalTranslate_", 3118428567, "float", 3220, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("emissiveWindStr_", 1501641732, "float", 3224, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("emissiveWindWaveAmplitude_", 3104106559, "float", 3228, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("emissiveWindWaveTime_", 665416441, "float", 3232, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionActorBonamikControl();
        }
		
    }
}