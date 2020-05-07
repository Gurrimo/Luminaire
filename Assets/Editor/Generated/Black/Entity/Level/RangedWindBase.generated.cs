using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Level
{
    public partial class RangedWindBase : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool m_Enabled;
		public bool m_MayaLightDirection;
		public int m_VolumeType;
		public float m_Flap;
		public float m_TotalTime;
		public float m_Power;
		public float m_Offset;
		public float m_WaveLength;
		public float m_RandomPower;
		public float m_RandomOffset;
		public float m_XAxisWaveDifference;
		public float m_YAxisWaveDifference;
		public float m_RandomTime;
		public float m_RandomCycleTime;
		public float m_GravityCoefficient;
		public UnityEngine.Vector4 m_Power3;
		public UnityEngine.Vector4 m_Offset3;
		public UnityEngine.Vector4 m_WaveLength3;
		public UnityEngine.Vector4 m_PhaseDifference3;
		public UnityEngine.Vector4 m_RandomPower3;
		public UnityEngine.Vector4 m_RandomOffset3;
		public UnityEngine.Vector4 m_FrequencyMultiply3;
		public int m_WindSockDistance;
		public int m_WindSockRange;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new RangedWindBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Level.RangedWindBase", 0, Black.Entity.Level.RangedWindBase.ObjectType, null, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("Black.Entity.Level.RangedWindBase", base.GetFieldProperties(), -1439393236, -646339722);
            
			fieldProperties.AddProperty(new Property("m_Enabled", 2851480862, "bool", 257, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_MayaLightDirection", 3208406760, "bool", 258, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_VolumeType", 3825660439, "Black.Entity.Level.RangedWindBase.VOLUMETYPE", 260, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_Flap", 144286158, "float", 264, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_TotalTime", 3107528252, "float", 268, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_Power", 2409683142, "float", 272, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_Offset", 2204732490, "float", 276, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_WaveLength", 893262488, "float", 280, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_RandomPower", 4064287187, "float", 284, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_RandomOffset", 1119909317, "float", 288, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_XAxisWaveDifference", 1517924268, "float", 292, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_YAxisWaveDifference", 275196815, "float", 296, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_RandomTime", 3983167843, "float", 300, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_RandomCycleTime", 3670278589, "float", 304, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_GravityCoefficient", 3540403826, "float", 308, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_Power3", 255166895, "Luminous.Math.VectorA", 320, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_Offset3", 1479025275, "Luminous.Math.VectorA", 336, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_WaveLength3", 2076441393, "Luminous.Math.VectorA", 352, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_PhaseDifference3", 2332223304, "Luminous.Math.VectorA", 368, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_RandomPower3", 988330912, "Luminous.Math.VectorA", 384, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_RandomOffset3", 184136258, "Luminous.Math.VectorA", 400, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_FrequencyMultiply3", 3309424846, "Luminous.Math.VectorA", 416, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_WindSockDistance", 4162190120, "int32_t", 432, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_WindSockRange", 453021956, "int32_t", 436, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}