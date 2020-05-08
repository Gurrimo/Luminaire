using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Physics
{
    public partial class VehicleDataEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint entryId_;
		public int vehicleType_;
		public float enginePeakTorque_;
		public float engineMaxRotationSpeed_;
		public IList<Black.Entity.Data.Physics.VehicleTorqueCurveDataItem> torqueCurve_= new List<Black.Entity.Data.Physics.VehicleTorqueCurveDataItem>();
		public float frontBrakeTorque_;
		public float rearBrakeTorque_;
		public float frontHandBrakeTorque_;
		public float rearHandBrakeTorque_;
		public float frontMaxSteer_;
		public float rearMaxSteer_;
		public IList<Black.Entity.Data.Physics.VehicleSteeringPerSpeedCurveDataItem> steerPerSpeedCurve_= new List<Black.Entity.Data.Physics.VehicleSteeringPerSpeedCurveDataItem>();
		public float frontMaxSteerUTurn_;
		public float rearMaxSteerUTurn_;
		public float suspensionMaxCompression_;
		public float suspensionMaxDroop_;
		public float suspensionSpringStrength_;
		public float suspensionSpringDamperRate_;
		public float suspensionSpringDamperRateRear_;
		public float suspensionAdditionalRaycastLength_;
		public float suspensionMaxCompressionLimit_;
		public float suspensionMaxDroopLimit_;
		public float suspMaxDisplacement_;
		public bool bNeedKineDriverUpdate_;
		public int differentialType_;
		public IList<Black.Entity.Data.Physics.VehicleGearDataItem> gearData_= new List<Black.Entity.Data.Physics.VehicleGearDataItem>();
		public float gearFinalRatio_;
		public float gearSwitchTime_;
		public float clutchStrength_;
		public uint frontTireId_;
		public uint rearTireId_;
		public float maxTargetSpeed_;
		public float targetSpeedRevisionRate_;
		public float targetSpeedRevisionAdd_;
		public float checkTargetSpeedMargin_;
		public float checkTargetSteerMargin_;
		public float switchAssistDriveTime_;
		public float maxApproachAngle_;
		public float maxAutoApproachAngle_;
		public float maxApproachDeltaWidth_;
		public float targetLeftLane_;
		public float maxLeftLane_;
		public bool isUsePassing_;
		public float startPassingDeltaSpeed_;
		public float startPassingLowSpeed_;
		public float followBehindDistance_;
		public float followBehindDistanceOnStopped_;
		public float blendRateSteer_;
		public float blendRateAccelBrake_;
		public float yOffsetOnLod1_;
		public float assistOffsetZ_;
		public float minSpeedForHuman_;
		public float switchManualToAutoDriveTime_;
		public float delayTimeReSearchPathWhenVehicleLeavePath_;
		public float timeIntervalSearchPathWhenReverseRun_;
		public bool isUseTireJoint_;
		public bool isRearTireFour_;
		public bool isUseHandleJoint_;
		public bool isUseMeterJoint_;
		public bool isUseWindowJoint_;
		public float frontWindowOpeningWidth_;
		public float rearWindowOpeningWidth_;
		public float fonrtWindowPillarOpeningWidth_;
		public bool isUpdateIdleMotion_;
		public bool isCheckChangeMotion_;
		public uint openMotionId_;
		public uint closeMotionId_;
		public uint startWiperMotionId_;
		public uint stopWiperMotionId_;
		public uint openEngineCoverMotionId_;
		public uint closeEngineCoverMotionId_;
		public int allCoverBonnetBBValue_;
		public int leftEngineCoverBBValue_;
		public int rightEngineCoverBBValue_;
		public int leftBonnetBBValue_;
		public int rightBonnetBBValue_;
		public uint openBonnetMotionId_;
		public uint closeBonnetMotionId_;
		public bool useFuelConsumption_;
		public float fuelTank_;
		public float fuelConsumption_;
		public bool isUseProcedualSound_;
		public int procedualSoundPriority_;
		public uint soundId_;
		public uint soundGroundId_;
		public uint soundWeatherId_;
		public uint soundContactId_;
		public uint soundEngineSimulateId_;
		public float engineLoopStartFade_;
		public float engineLoopStopFade_;
		public float engineLoopPitchMin_;
		public float engineLoopPitchMax_;
		public float engineLoopVolumeMin_;
		public float engineLoopVolumeMax_;
		public float brakeDecelerationMax_;
		public float brakeVolumeMin_;
		public float brakeVolumeMax_;
		public float tireLoopSpeedMax_;
		public float tireLoopPitchMin_;
		public float tireLoopPitchMax_;
		public float tireLoopVolumeMin_;
		public float tireLoopVolumeMax_;
		public float turnLoopSpeedMax_;
		public float turnLoopAbsSpeedMin_;
		public float turnLoopAbsSpeedMax_;
		public float turnLoopPitchMin_;
		public float turnLoopPitchMax_;
		public float turnLoopVolumeMin_;
		public float turnLoopVolumeMax_;
		public float suspensionVolumeMin_;
		public float suspensionVolumeMax_;
		public float suspensionForceMin_;
		public float suspensionForceMax_;
		public bool isUseVfx_;
		public uint vfxId_;
		public uint vfxGroundId_;
		public uint vfxWeatherId_;
		public uint vfxMarkWeatherId_;
		public uint vfxFoliageId_;
		public bool isUseMaterial_;
		public uint materialId_;
		public uint materialWeatherSetId_;
		public uint materialContactSetId_;
		public uint materialCustomizeSetId_;
		public uint materialTransformedId_;
		public float frontTireRadius_;
		public float frontTireWidth_;
		public float rearTireRadius_;
		public float rearTireWidth_;
		public UnityEngine.Vector4 frontTireOffset_;
		public UnityEngine.Vector4 rearTireOffset_;
		public UnityEngine.Vector4 frontTireDrawOffset_;
		public UnityEngine.Vector4 rearTireDrawOffset_;
		public float chassisWidth_;
		public float chassisHeight_;
		public float chassisDepth_;
		public UnityEngine.Vector4 chassisOffset_;
		public UnityEngine.Vector4 chassisCMOffset_;
		public float chassisRoofHeight_;
		public float chassisRoofDepthFromFront_;
		public float chassisRoofDepthFromRear_;
		public float chassisFrontBumperDepth_;
		public float chassisFrontBumperFromSide_;
		public float chassisRearBumperDepth_;
		public float chassisRearDumperFromSide_;
		public float chassisRoofExtraHeight_;
		public float chassisBottomHeight_;
		public float chassisBottomDepressionSide_;
		public float chassisBottomDepressionDepth_;
		public float rigidBodyScale_;
		public int characterSize_;
		public float chassisMass_;
		public float wheelMass_;
		public uint shipParamId_;
		public bool useOceanWave_;
		public float waveNormalRate_;
		public float waveNormalRateOfMaxSpeed_;
		public float nextDirRate_;
		public float nextRotRate_;
		public float lengthToBow_;
		public float offsetCOMOfmaxSpeed_;
		public float freeFallHeight_;
		public float airResistent_;
		public float waterResistentFoward_;
		public float waterResistentCenter_;
		public UnityEngine.Vector4 angularCoverageTime_;
		public UnityEngine.Vector4 angularSpeedResistance_;
		public float maxRollAngle_;
		public float beginAvoidDistance_;
		public float endAvoidDistance_;
		public float targetAvoidLane_;
		public float whileAvoidSpeed_;
		public float maxDeltaMoveLane_;
		public float shipPitchPower_;
		public IList<Black.Entity.WaterExclusionBoxParameter> waterExclusionBoxParams_= new List<Black.Entity.WaterExclusionBoxParameter>();
		public float skiParamTorqueForSteering1_;
		public float skiParamTorqueForSteering2_;
		public bool isEnableFreeDrive_;
		public float yawRotationSpeedInAir_;
		public uint vehicleSpeedByGroundAttribute_;
		public uint freeDriveAttackSetId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VehicleDataEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Physics.VehicleDataEntity", 0, Black.Entity.Data.Physics.VehicleDataEntity.ObjectType, Construct, properties, 0, 960);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Physics.VehicleDataEntity", base.GetFieldProperties(), 739638239, 1992925650);
            
			
			
			fieldProperties.AddProperty(new Property("entryId_", 3698228211, "SQEX.Ebony.Std.Fixid", 64, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("vehicleType_", 1194594424, "Black.Physics.Vehicle.VehicleType", 68, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("enginePeakTorque_", 4226057191, "float", 72, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("engineMaxRotationSpeed_", 1256109797, "float", 76, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("torqueCurve_", 4201121559, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.Physics.VehicleTorqueCurveDataItem* >", 80, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("frontBrakeTorque_", 2377895474, "float", 96, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rearBrakeTorque_", 1992312137, "float", 100, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frontHandBrakeTorque_", 1909375447, "float", 104, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rearHandBrakeTorque_", 473595092, "float", 108, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frontMaxSteer_", 3983024828, "float", 112, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rearMaxSteer_", 131263949, "float", 116, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("steerPerSpeedCurve_", 45348812, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.Physics.VehicleSteeringPerSpeedCurveDataItem* >", 120, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("frontMaxSteerUTurn_", 2917971282, "float", 136, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rearMaxSteerUTurn_", 83300713, "float", 140, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suspensionMaxCompression_", 643655585, "float", 144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suspensionMaxDroop_", 634708559, "float", 148, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suspensionSpringStrength_", 1501363305, "float", 152, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suspensionSpringDamperRate_", 3919520723, "float", 156, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suspensionSpringDamperRateRear_", 591367465, "float", 160, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suspensionAdditionalRaycastLength_", 280301733, "float", 164, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suspensionMaxCompressionLimit_", 1004072696, "float", 168, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suspensionMaxDroopLimit_", 3646579506, "float", 172, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suspMaxDisplacement_", 3276241644, "float", 176, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("bNeedKineDriverUpdate_", 49972832, "bool", 180, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("differentialType_", 4109733081, "Black.Entity.Data.Physics.VehicleDataEntity.DifferentialType", 184, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("gearData_", 3112695811, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.Physics.VehicleGearDataItem* >", 192, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("gearFinalRatio_", 3546212946, "float", 208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("gearSwitchTime_", 3565377328, "float", 212, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("clutchStrength_", 2140554826, "float", 216, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frontTireId_", 3567966212, "SQEX.Ebony.Std.Fixid", 220, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("rearTireId_", 1510337565, "SQEX.Ebony.Std.Fixid", 224, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxTargetSpeed_", 1496807944, "float", 228, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetSpeedRevisionRate_", 586576141, "float", 232, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetSpeedRevisionAdd_", 2200281442, "float", 236, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkTargetSpeedMargin_", 484330884, "float", 240, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkTargetSteerMargin_", 1531707266, "float", 244, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("switchAssistDriveTime_", 2590595376, "float", 248, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxApproachAngle_", 4053555173, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxAutoApproachAngle_", 3896007162, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxApproachDeltaWidth_", 3938639356, "float", 260, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetLeftLane_", 569900796, "float", 264, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxLeftLane_", 3500639971, "float", 268, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUsePassing_", 342616916, "bool", 272, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("startPassingDeltaSpeed_", 2861029604, "float", 276, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("startPassingLowSpeed_", 4273798800, "float", 280, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("followBehindDistance_", 3313354776, "float", 284, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("followBehindDistanceOnStopped_", 4240520176, "float", 288, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blendRateSteer_", 2436175568, "float", 292, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blendRateAccelBrake_", 895324858, "float", 296, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("yOffsetOnLod1_", 3799362917, "float", 300, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("assistOffsetZ_", 312330578, "float", 304, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("minSpeedForHuman_", 3153186395, "float", 308, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("switchManualToAutoDriveTime_", 1756767339, "float", 312, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("delayTimeReSearchPathWhenVehicleLeavePath_", 258821588, "float", 316, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeIntervalSearchPathWhenReverseRun_", 2343721306, "float", 320, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseTireJoint_", 2149563387, "bool", 324, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isRearTireFour_", 1113589166, "bool", 325, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseHandleJoint_", 3329769147, "bool", 326, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseMeterJoint_", 2010980272, "bool", 327, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseWindowJoint_", 1640096401, "bool", 328, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("frontWindowOpeningWidth_", 3110668573, "float", 332, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rearWindowOpeningWidth_", 123570828, "float", 336, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fonrtWindowPillarOpeningWidth_", 1936426755, "float", 340, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUpdateIdleMotion_", 2883767609, "bool", 344, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCheckChangeMotion_", 1038043546, "bool", 345, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("openMotionId_", 1367910131, "SQEX.Ebony.Std.Fixid", 348, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("closeMotionId_", 576936705, "SQEX.Ebony.Std.Fixid", 352, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("startWiperMotionId_", 1672646174, "SQEX.Ebony.Std.Fixid", 356, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("stopWiperMotionId_", 2589710076, "SQEX.Ebony.Std.Fixid", 360, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("openEngineCoverMotionId_", 851416058, "SQEX.Ebony.Std.Fixid", 364, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("closeEngineCoverMotionId_", 3546965864, "SQEX.Ebony.Std.Fixid", 368, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("allCoverBonnetBBValue_", 1385167199, "int", 372, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("leftEngineCoverBBValue_", 1902208467, "int", 376, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("rightEngineCoverBBValue_", 1652613544, "int", 380, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("leftBonnetBBValue_", 676250024, "int", 384, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("rightBonnetBBValue_", 105254437, "int", 388, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("openBonnetMotionId_", 55058357, "SQEX.Ebony.Std.Fixid", 392, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("closeBonnetMotionId_", 2925726683, "SQEX.Ebony.Std.Fixid", 396, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("useFuelConsumption_", 4199342480, "bool", 400, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("fuelTank_", 2231120458, "float", 404, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fuelConsumption_", 3092547081, "float", 408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseProcedualSound_", 3496288537, "bool", 412, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("procedualSoundPriority_", 2927603886, "Black.Physics.Vehicle.ProcedualPriority", 416, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("soundId_", 475718802, "SQEX.Ebony.Std.Fixid", 420, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("soundGroundId_", 663467823, "SQEX.Ebony.Std.Fixid", 424, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("soundWeatherId_", 101810046, "SQEX.Ebony.Std.Fixid", 428, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("soundContactId_", 306070910, "SQEX.Ebony.Std.Fixid", 432, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("soundEngineSimulateId_", 166304042, "SQEX.Ebony.Std.Fixid", 436, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("engineLoopStartFade_", 1506279950, "float", 440, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("engineLoopStopFade_", 2105288080, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("engineLoopPitchMin_", 447465560, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("engineLoopPitchMax_", 2173456626, "float", 452, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("engineLoopVolumeMin_", 2135221358, "float", 456, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("engineLoopVolumeMax_", 639424364, "float", 460, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("brakeDecelerationMax_", 1775219476, "float", 464, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("brakeVolumeMin_", 3337593259, "float", 468, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("brakeVolumeMax_", 805765569, "float", 472, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tireLoopSpeedMax_", 1008318719, "float", 476, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tireLoopPitchMin_", 3116494032, "float", 480, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tireLoopPitchMax_", 1389811418, "float", 484, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tireLoopVolumeMin_", 1722451878, "float", 488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tireLoopVolumeMax_", 1074068212, "float", 492, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnLoopSpeedMax_", 3416215132, "float", 496, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnLoopAbsSpeedMin_", 1938915134, "float", 500, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnLoopAbsSpeedMax_", 437895260, "float", 504, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnLoopPitchMin_", 2665085887, "float", 508, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnLoopPitchMax_", 3311601245, "float", 512, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnLoopVolumeMin_", 2097804467, "float", 516, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnLoopVolumeMax_", 3598132793, "float", 520, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suspensionVolumeMin_", 3393425791, "float", 524, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suspensionVolumeMax_", 4081414685, "float", 528, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suspensionForceMin_", 3736688018, "float", 532, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suspensionForceMax_", 942049048, "float", 536, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseVfx_", 81144485, "bool", 540, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("vfxId_", 2738991511, "SQEX.Ebony.Std.Fixid", 544, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("vfxGroundId_", 3347386870, "SQEX.Ebony.Std.Fixid", 548, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("vfxWeatherId_", 3239975033, "SQEX.Ebony.Std.Fixid", 552, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("vfxMarkWeatherId_", 1071372488, "SQEX.Ebony.Std.Fixid", 556, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("vfxFoliageId_", 2941419816, "SQEX.Ebony.Std.Fixid", 560, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseMaterial_", 1416252086, "bool", 564, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialId_", 3076764230, "SQEX.Ebony.Std.Fixid", 568, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialWeatherSetId_", 1822919666, "SQEX.Ebony.Std.Fixid", 572, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialContactSetId_", 3977948370, "SQEX.Ebony.Std.Fixid", 576, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialCustomizeSetId_", 561588193, "SQEX.Ebony.Std.Fixid", 580, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialTransformedId_", 1927288661, "SQEX.Ebony.Std.Fixid", 584, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("frontTireRadius_", 1821591129, "float", 588, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frontTireWidth_", 2853274735, "float", 592, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rearTireRadius_", 1561414996, "float", 596, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rearTireWidth_", 3346635664, "float", 600, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frontTireOffset_", 2160415666, "Luminous.Math.VectorA", 608, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("rearTireOffset_", 3893008319, "Luminous.Math.VectorA", 624, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("frontTireDrawOffset_", 703109340, "Luminous.Math.VectorA", 640, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("rearTireDrawOffset_", 3180292317, "Luminous.Math.VectorA", 656, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("chassisWidth_", 3278720106, "float", 672, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("chassisHeight_", 1983867469, "float", 676, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("chassisDepth_", 374784613, "float", 680, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("chassisOffset_", 367710689, "Luminous.Math.VectorA", 688, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("chassisCMOffset_", 1312059621, "Luminous.Math.VectorA", 704, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("chassisRoofHeight_", 1433787299, "float", 720, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("chassisRoofDepthFromFront_", 703741750, "float", 724, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("chassisRoofDepthFromRear_", 3963169069, "float", 728, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("chassisFrontBumperDepth_", 3691125835, "float", 732, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("chassisFrontBumperFromSide_", 105270503, "float", 736, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("chassisRearBumperDepth_", 2468313440, "float", 740, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("chassisRearDumperFromSide_", 3445014160, "float", 744, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("chassisRoofExtraHeight_", 3135588199, "float", 748, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("chassisBottomHeight_", 38606412, "float", 752, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("chassisBottomDepressionSide_", 1236780648, "float", 756, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("chassisBottomDepressionDepth_", 3331374234, "float", 760, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rigidBodyScale_", 3939934671, "float", 764, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("characterSize_", 3961098362, "int", 768, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("chassisMass_", 2848429924, "float", 772, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("wheelMass_", 259514225, "float", 776, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("shipParamId_", 3357264186, "SQEX.Ebony.Std.Fixid", 780, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("useOceanWave_", 2377031044, "bool", 784, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("waveNormalRate_", 2394599526, "float", 788, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("waveNormalRateOfMaxSpeed_", 3283791738, "float", 792, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("nextDirRate_", 3010855950, "float", 796, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("nextRotRate_", 3767939144, "float", 800, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lengthToBow_", 3587584365, "float", 804, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetCOMOfmaxSpeed_", 937826292, "float", 808, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("freeFallHeight_", 5741610, "float", 812, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("airResistent_", 196133495, "float", 816, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("waterResistentFoward_", 1119863115, "float", 820, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("waterResistentCenter_", 3725747655, "float", 824, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("angularCoverageTime_", 3956764411, "Luminous.Math.VectorA", 832, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("angularSpeedResistance_", 1200665986, "Luminous.Math.VectorA", 848, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxRollAngle_", 1168496130, "float", 864, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("beginAvoidDistance_", 2692834317, "float", 868, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("endAvoidDistance_", 3549263769, "float", 872, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetAvoidLane_", 1497152368, "float", 876, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("whileAvoidSpeed_", 73078087, "float", 880, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxDeltaMoveLane_", 2262035211, "float", 884, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("shipPitchPower_", 386438265, "float", 888, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("waterExclusionBoxParams_", 616124268, "SQEX.Ebony.Std.DynamicArray< Black.Entity.WaterExclusionBoxParameter* >", 896, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("skiParamTorqueForSteering1_", 3755746607, "float", 912, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("skiParamTorqueForSteering2_", 2681831896, "float", 916, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnableFreeDrive_", 1120446625, "bool", 920, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("yawRotationSpeedInAir_", 2259125739, "float", 924, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vehicleSpeedByGroundAttribute_", 1875718265, "SQEX.Ebony.Std.Fixid", 928, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("freeDriveAttackSetId_", 3736068119, "SQEX.Ebony.Std.Fixid", 932, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new VehicleDataEntity();
        }
		
    }
}