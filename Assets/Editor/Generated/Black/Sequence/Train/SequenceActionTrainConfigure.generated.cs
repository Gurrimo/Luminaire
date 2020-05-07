using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Train
{
    public partial class SequenceActionTrainConfigure : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinTrain_;
		public bool toConfigNavigation_;
		public bool autoFindNextCurve_;
		public int timerType_;
		public bool toConfigRoll_;
		public float rollMaxDegree_;
		public float rollScale_;
		public float rollAngularSpeed_;
		public float rollSmoothingCoeff_;
		public bool toConfigVibration_;
		public float vibrationMaxX_;
		public float vibrationMaxY_;
		public float vibrationFreq_;
		public float vibrationDuration_;
		public bool toConfigSimMovingPlat_;
		public bool smpEnableAsConnectionPortActor_;
		public bool toConfigOffsetOverRail_;
		public float offsetOverRailVertical_;
		public float offsetOverRailHorizontal_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTrainConfigure();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Train.SequenceActionTrainConfigure", 0, Black.Sequence.Train.SequenceActionTrainConfigure.ObjectType, null, properties, 0, 520);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Train.SequenceActionTrainConfigure", base.GetFieldProperties(), -1603701930, -153223531);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inPinTrain_", 115407762, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("toConfigNavigation_", 22046677, "bool", 456, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoFindNextCurve_", 167995288, "bool", 457, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("timerType_", 1026330487, "XPEC.Train.TimerType", 460, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("toConfigRoll_", 1753015382, "bool", 464, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rollMaxDegree_", 1535865389, "float", 468, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rollScale_", 3715060793, "float", 472, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rollAngularSpeed_", 4184172152, "float", 476, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rollSmoothingCoeff_", 4145740838, "float", 480, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("toConfigVibration_", 3078111297, "bool", 484, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("vibrationMaxX_", 2381098176, "float", 488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vibrationMaxY_", 2380951081, "float", 492, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vibrationFreq_", 3474710412, "float", 496, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vibrationDuration_", 843455906, "float", 500, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("toConfigSimMovingPlat_", 1192968527, "bool", 504, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("smpEnableAsConnectionPortActor_", 4011765701, "bool", 505, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("toConfigOffsetOverRail_", 838338456, "bool", 506, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetOverRailVertical_", 2944627455, "float", 508, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetOverRailHorizontal_", 3984869629, "float", 512, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}