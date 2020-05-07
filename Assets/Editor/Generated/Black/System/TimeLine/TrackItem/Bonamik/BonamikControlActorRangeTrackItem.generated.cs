using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Bonamik
{
    public partial class BonamikControlActorRangeTrackItem : Black.System.TimeLine.TrackItem.BlendTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int ctrlType_;
		public int selectGroup_;
		public float animationBlendCoeff_;
		public float emissiveWindStr_;
		public float emissiveWaveAmp_;
		public float emissiveWaveTime_;
		public bool resetPose_;
		public float coneStrScale_;
		public float localForceScale_;
		public float timeStepScale_;
		public int preRoll_;
		public float addMass_;
		public bool stableMode_;
		public int subStep_;
		public int solverIter_;
		public int linkIter_;
		public int collIter_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BonamikControlActorRangeTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Bonamik.BonamikControlActorRangeTrackItem", 0, Black.System.TimeLine.TrackItem.Bonamik.BonamikControlActorRangeTrackItem.ObjectType, null, properties, 0, 248);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Bonamik.BonamikControlActorRangeTrackItem", base.GetFieldProperties(), 1107179332, -390636217);
            
			fieldProperties.AddProperty(new Property("ctrlType_", 1049466601, "Black.Physics.Bonamik.BonamikSimulationControlType", 176, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("selectGroup_", 307161457, "Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikControl.eBONAMIKSELECTGROUP", 180, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("animationBlendCoeff_", 2096144374, "float", 184, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("emissiveWindStr_", 1501641732, "float", 188, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("emissiveWaveAmp_", 978357880, "float", 192, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("emissiveWaveTime_", 4280936347, "float", 196, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("resetPose_", 1677554294, "bool", 200, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("coneStrScale_", 3297123490, "float", 204, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("localForceScale_", 26593156, "float", 208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeStepScale_", 4255856945, "float", 212, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("preRoll_", 1753453378, "int", 216, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("addMass_", 4288545305, "float", 220, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("stableMode_", 827061318, "bool", 224, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("subStep_", 1557708288, "int", 228, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("solverIter_", 2787567573, "int", 232, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("linkIter_", 3348301244, "int", 236, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("collIter_", 1937375478, "int", 240, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}