using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Wind
{
    public partial class BonamikWindEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float scaling_;
		public bool isEnable_;
		public bool isEnableDraw_;
		public bool enableWeather_;
		public float windMultiplier_;
		public float speedMultiplier_;
		public float charaWindScale_;
		public float grassWindScale_;
		public float treeWindScale_;
		public int windType_;
		public int areaType_;
		public bool globalAddition_;
		public float areaRadius_;
		public float cylinderLength_;
		public UnityEngine.Vector4 boxSize_;
		public string bnmwndPath_= string.Empty;
		public float customWavePeriodMultiplication_;
		public UnityEngine.Vector4 windForce_;
		public UnityEngine.Vector4 randomRange_;
		public float randomTime_;
		public UnityEngine.Vector4 waveAmp_;
		public UnityEngine.Vector4 waveFreq_;
		public UnityEngine.Vector4 waveAmpOffset_;
		public UnityEngine.Vector4 waveFreqOffset_;
		public float waveTime_;
		public float tornadoStrength_;
		public float tornadoRadius_;
		public float blastStrength_;
		public float blastRange_;
		public float blastPeakInRange_;
		public float blastSpeed_;
		public bool blastIsLoop_;
		public int blastLoop_;
		public float windScale_;
		public bool isGlobalWindForGrass_;
		public float noiseMapSize_;
		public float noiseMapSpeed_;
		public float phaseShiftMapSize_;
		public float travelWindSpeed_;
		public float travelWindStrength_;
		public float maxWindStrength_;
		public bool enableGrassInteraction_;
		public float characterStr_;
		public float grassGscale_;
		public float grassBscale_;
		public float treeGscale_;
		public float treeBscale_;
		public float treeLODdistance1_;
		public float treeLODdistance2_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BonamikWindEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Wind.BonamikWindEntity", 0, Black.Entity.Data.Wind.BonamikWindEntity.ObjectType, null, properties, 0, 592);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Wind.BonamikWindEntity", base.GetFieldProperties(), -1920326348, -65371055);
            
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entitySearchLabelId_", 3840219358, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("scaling_", 3325430311, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnable_", 4253513587, "bool", 260, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnableDraw_", 4123602325, "bool", 261, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableWeather_", 1384777099, "bool", 262, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("windMultiplier_", 3079316601, "float", 264, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("speedMultiplier_", 2153469272, "float", 268, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("charaWindScale_", 2870214141, "float", 272, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("grassWindScale_", 1037521248, "float", 276, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("treeWindScale_", 688018168, "float", 280, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("windType_", 2345646048, "Black.Entity.Data.Wind.BonamikWindEntity.eWINDENTITYTYPE", 284, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("areaType_", 3864051017, "Black.Entity.Data.Wind.BonamikWindEntity.eAREATYPE", 288, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("globalAddition_", 3085034019, "bool", 292, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("areaRadius_", 2202752319, "float", 296, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("cylinderLength_", 2449573152, "float", 300, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("boxSize_", 4023026188, "Luminous.Math.VectorA", 304, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwndPath_", 3836444225, "Ebony.Base.String", 320, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("customWavePeriodMultiplication_", 1787587545, "float", 336, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("windForce_", 2667354487, "Luminous.Math.VectorA", 352, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("randomRange_", 413357744, "Luminous.Math.VectorA", 368, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("randomTime_", 3343243252, "float", 384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("waveAmp_", 1543521767, "Luminous.Math.VectorA", 400, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("waveFreq_", 2287883555, "Luminous.Math.VectorA", 416, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("waveAmpOffset_", 932232334, "Luminous.Math.VectorA", 432, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("waveFreqOffset_", 3818481490, "Luminous.Math.VectorA", 448, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("waveTime_", 1517405438, "float", 464, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tornadoStrength_", 2076725148, "float", 468, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tornadoRadius_", 3477316341, "float", 472, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blastStrength_", 3407531385, "float", 476, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blastRange_", 3397672251, "float", 480, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blastPeakInRange_", 4011029651, "float", 484, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blastSpeed_", 4214185697, "float", 488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blastIsLoop_", 3430654936, "bool", 492, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("blastLoop_", 2367890936, "int", 496, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("windScale_", 3638455848, "float", 500, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isGlobalWindForGrass_", 789497400, "bool", 504, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("noiseMapSize_", 1047980257, "float", 508, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("noiseMapSpeed_", 1703328389, "float", 512, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("phaseShiftMapSize_", 428290956, "float", 516, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("travelWindSpeed_", 1074659827, "float", 520, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("travelWindStrength_", 2101416731, "float", 524, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxWindStrength_", 2229176699, "float", 528, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableGrassInteraction_", 1255553369, "bool", 532, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("characterStr_", 2284051584, "float", 536, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("grassGscale_", 341145033, "float", 540, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("grassBscale_", 4025274098, "float", 544, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("treeGscale_", 3925913681, "float", 548, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("treeBscale_", 3952333274, "float", 552, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("treeLODdistance1_", 4055744075, "float", 556, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("treeLODdistance2_", 4055596980, "float", 560, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}