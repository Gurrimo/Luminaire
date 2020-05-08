using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Bonamik
{
    public partial class BonamikControlActorTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int ctrlType_;
		public int selectGroup_;
		public int blendedFrames_;
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

            var dummy = new BonamikControlActorTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Bonamik.BonamikControlActorTrackItem", 0, Black.System.TimeLine.TrackItem.Bonamik.BonamikControlActorTrackItem.ObjectType, Construct, properties, 0, 160);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Bonamik.BonamikControlActorTrackItem", base.GetFieldProperties(), 1129742800, -542893927);
            
			fieldProperties.AddIndirectlyProperty(new Property("name_", 182823483, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startTime_", 140908163, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("duration_", 1282328598, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("ctrlType_", 1049466601, "Black.Physics.Bonamik.BonamikSimulationControlType", 88, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("selectGroup_", 307161457, "Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikControl.eBONAMIKSELECTGROUP", 92, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("blendedFrames_", 1011153196, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("animationBlendCoeff_", 2096144374, "float", 100, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("emissiveWindStr_", 1501641732, "float", 104, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("emissiveWaveAmp_", 978357880, "float", 108, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("emissiveWaveTime_", 4280936347, "float", 112, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("resetPose_", 1677554294, "bool", 116, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("coneStrScale_", 3297123490, "float", 120, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("localForceScale_", 26593156, "float", 124, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeStepScale_", 4255856945, "float", 128, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("preRoll_", 1753453378, "int", 132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("addMass_", 4288545305, "float", 136, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("stableMode_", 827061318, "bool", 140, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("subStep_", 1557708288, "int", 144, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("solverIter_", 2787567573, "int", 148, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("linkIter_", 3348301244, "int", 152, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("collIter_", 1937375478, "int", 156, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new BonamikControlActorTrackItem();
        }
		
    }
}