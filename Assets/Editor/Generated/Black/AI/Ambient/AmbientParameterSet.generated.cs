using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Ambient
{
    public partial class AmbientParameterSet : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float chatterMaxActivationDistance_;
		public float chatterMinSustainDistance_;
		public float chatterCoolDown_;
		public float individualChatterCoolDown_;
		public uint chatterScriptGroup_;
		public int numberOfActors_;
		public float spawnPointCameraZfar_;
		public float maxSpawnRadius_;
		public float minDespawnDistance_;
		public float spawnScoreHysteresis_;
		public float inCameraScoreMultiplier_;
		public float spawnAttemptInterval_;
		public float minAliveTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AmbientParameterSet();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Ambient.AmbientParameterSet", 0, Black.AI.Ambient.AmbientParameterSet.ObjectType, null, properties, 0, 120);
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

            fieldProperties = new PropertyContainer("Black.AI.Ambient.AmbientParameterSet", base.GetFieldProperties(), -1422824044, 288541398);
            
			fieldProperties.AddProperty(new Property("chatterMaxActivationDistance_", 3407824396, "float", 64, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("chatterMinSustainDistance_", 2731205729, "float", 68, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("chatterCoolDown_", 3239235320, "float", 72, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("individualChatterCoolDown_", 716481563, "float", 76, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("chatterScriptGroup_", 1062066449, "SQEX.Ebony.Std.Fixid", 80, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("numberOfActors_", 1255873960, "int", 84, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("spawnPointCameraZfar_", 2945979395, "float", 88, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxSpawnRadius_", 392024495, "float", 92, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("minDespawnDistance_", 1955185169, "float", 96, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("spawnScoreHysteresis_", 1659287178, "float", 100, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("inCameraScoreMultiplier_", 1003220131, "float", 104, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("spawnAttemptInterval_", 2269038825, "float", 108, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("minAliveTime_", 3670056986, "float", 112, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}