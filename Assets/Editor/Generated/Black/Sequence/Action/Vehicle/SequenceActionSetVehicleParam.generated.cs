using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vehicle
{
    public partial class SequenceActionSetVehicleParam : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public float chassisMass_;
		public float wheelMass_;
		public int frontTireType_;
		public int rearTireType_;
		public float frontBrakeTorque_;
		public float rearBrakeTorque_;
		public float frontHandBrakeTorque_;
		public float rearHandBrakeTorque_;
		public float frontMaxSteer_;
		public float rearMaxSteer_;
		public float suspensionShimHeight_;
		public float suspentionMaxCompression_;
		public float suspentionMaxDroop_;
		public float suspentionSpringStrength_;
		public float suspentionSpringDamperRate_;
		public float enginePeakTorque_;
		public float engineMaxRotationSpeed_;
		public float accelOffSpeed_;
		public int differentialType_;
		public float gearsSwitchTime_;
		public float gearsRatioR_;
		public float gearsRatio1_;
		public float gearsRatio2_;
		public float gearsRatio3_;
		public float gearsRatio4_;
		public float gearsRatio5_;
		public float autoGearsUpRatioR_;
		public float autoGearsUpRatioN_;
		public float autoGearsUpRatio1_;
		public float autoGearsUpRatio2_;
		public float autoGearsUpRatio3_;
		public float autoGearsUpRatio4_;
		public float autoGearsDownRatio1_;
		public float autoGearsDownRatio2_;
		public float autoGearsDownRatio3_;
		public float autoGearsDownRatio4_;
		public float autoGearsDownRatio5_;
		public float clutchStrength_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVehicleParam();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vehicle.SequenceActionSetVehicleParam", 0, Black.Sequence.Action.Vehicle.SequenceActionSetVehicleParam.ObjectType, null, properties, 0, 520);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vehicle.SequenceActionSetVehicleParam", base.GetFieldProperties(), 1933791690, -1436126389);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("chassisMass_", 2848429924, "float", 368, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("wheelMass_", 259514225, "float", 372, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frontTireType_", 3480613379, "Black.Sequence.Action.Vehicle.SequenceActionSetVehicleParam.TireType", 376, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("rearTireType_", 2954656742, "Black.Sequence.Action.Vehicle.SequenceActionSetVehicleParam.TireType", 380, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("frontBrakeTorque_", 2377895474, "float", 384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rearBrakeTorque_", 1992312137, "float", 388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frontHandBrakeTorque_", 1909375447, "float", 392, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rearHandBrakeTorque_", 473595092, "float", 396, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("frontMaxSteer_", 3983024828, "float", 400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rearMaxSteer_", 131263949, "float", 404, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suspensionShimHeight_", 3942024559, "float", 408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suspentionMaxCompression_", 2122010784, "float", 412, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suspentionMaxDroop_", 345414766, "float", 416, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suspentionSpringStrength_", 4233387368, "float", 420, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suspentionSpringDamperRate_", 1560040198, "float", 424, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enginePeakTorque_", 4226057191, "float", 428, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("engineMaxRotationSpeed_", 1256109797, "float", 432, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("accelOffSpeed_", 1501149484, "float", 436, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("differentialType_", 4109733081, "Black.Sequence.Action.Vehicle.SequenceActionSetVehicleParam.DiffType", 440, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("gearsSwitchTime_", 1267099243, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("gearsRatioR_", 2422347021, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("gearsRatio1_", 2438353778, "float", 452, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("gearsRatio2_", 3511680109, "float", 456, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("gearsRatio3_", 3511827204, "float", 460, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("gearsRatio4_", 2438898231, "float", 464, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("gearsRatio5_", 3512812942, "float", 468, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoGearsUpRatioR_", 375333089, "float", 472, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoGearsUpRatioN_", 376024637, "float", 476, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoGearsUpRatio1_", 391443014, "float", 480, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoGearsUpRatio2_", 3612201409, "float", 484, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoGearsUpRatio3_", 3612348504, "float", 488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoGearsUpRatio4_", 3611804051, "float", 492, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoGearsDownRatio1_", 546135289, "float", 496, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoGearsDownRatio2_", 546576574, "float", 500, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoGearsDownRatio3_", 546429479, "float", 504, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoGearsDownRatio4_", 1619358452, "float", 508, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoGearsDownRatio5_", 545443741, "float", 512, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("clutchStrength_", 2140554826, "float", 516, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}