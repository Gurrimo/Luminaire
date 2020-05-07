using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Physics
{
    public partial class ApexDestructionDataEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint destructionId_;
		public string sourcePath_;
		public float density_;
		public float damageInverseScaling_;
		public bool buildNavMesh_;
		public uint vfx1LeafId_;
		public bool sound1Enabled_;
		public int sound1Id_;
		public float sound1Volume_;
		public uint vfxOrigin1LeafId_;
		public int vfxOrigin1Count_;
		public uint vfx2LeafId_;
		public bool sound2Enabled_;
		public int sound2Id_;
		public float sound2Volume_;
		public uint vfxOrigin2LeafId_;
		public int vfxOrigin2Count_;
		public uint vfx3LeafId_;
		public bool sound3Enabled_;
		public int sound3Id_;
		public float sound3Volume_;
		public uint vfxOrigin3LeafId_;
		public int vfxOrigin3Count_;
		public uint vfxCLeafId_;
		public bool soundCEnabled_;
		public int soundCId_;
		public float soundCVolume_;
		public float contactEventThreshold_;
		public float contactEventPlayCountMax_;
		public float contactEventCountMax_;
		public string materialApexName0_;
		public string materialMigName0_;
		public string materialApexName1_;
		public string materialMigName1_;
		public string materialApexName2_;
		public string materialMigName2_;
		public string materialApexName3_;
		public string materialMigName3_;
		public string materialApexName4_;
		public string materialMigName4_;
		public string materialApexName5_;
		public string materialMigName5_;
		public string materialApexName6_;
		public string materialMigName6_;
		public string materialApexName7_;
		public string materialMigName7_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ApexDestructionDataEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Physics.ApexDestructionDataEntity", 0, Black.Entity.Data.Physics.ApexDestructionDataEntity.ObjectType, null, properties, 0, 472);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Physics.ApexDestructionDataEntity", base.GetFieldProperties(), 1908653875, 1645597304);
            
			fieldProperties.AddProperty(new Property("destructionId_", 3960157027, "SQEX.Ebony.Std.Fixid", 64, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourcePath_", 341055184, "Ebony.Base.String", 72, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("density_", 1564742540, "float", 88, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("damageInverseScaling_", 968770666, "float", 92, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("buildNavMesh_", 1409300218, "bool", 96, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("vfx1LeafId_", 3436723716, "SQEX.Ebony.Std.Fixid", 100, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("sound1Enabled_", 2949356705, "bool", 104, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("sound1Id_", 2774614007, "SeadSoundID", 108, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("sound1Volume_", 3924683090, "float", 112, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vfxOrigin1LeafId_", 3461416630, "SQEX.Ebony.Std.Fixid", 116, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("vfxOrigin1Count_", 1043317680, "int", 120, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("vfx2LeafId_", 3692301731, "SQEX.Ebony.Std.Fixid", 124, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("sound2Enabled_", 931389536, "bool", 128, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("sound2Id_", 3584655456, "SeadSoundID", 132, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("sound2Volume_", 3975859857, "float", 136, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vfxOrigin2LeafId_", 3005437825, "SQEX.Ebony.Std.Fixid", 140, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("vfxOrigin2Count_", 803640333, "int", 144, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("vfx3LeafId_", 2857715882, "SQEX.Ebony.Std.Fixid", 148, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("sound3Enabled_", 1135669459, "bool", 152, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("sound3Id_", 3031937709, "SeadSoundID", 156, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("sound3Volume_", 67156592, "float", 160, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vfxOrigin3LeafId_", 2710822464, "SQEX.Ebony.Std.Fixid", 164, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("vfxOrigin3Count_", 1544228286, "int", 168, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("vfxCLeafId_", 807770746, "SQEX.Ebony.Std.Fixid", 172, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("soundCEnabled_", 3451637123, "bool", 176, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("soundCId_", 2623898301, "SeadSoundID", 180, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("soundCVolume_", 2973611136, "float", 184, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("contactEventThreshold_", 1530636033, "float", 188, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("contactEventPlayCountMax_", 1003836653, "float", 192, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("contactEventCountMax_", 3966243835, "float", 196, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialApexName0_", 3664082182, "Ebony.Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialMigName0_", 527876185, "Ebony.Base.String", 216, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialApexName1_", 3663935087, "Ebony.Base.String", 232, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialMigName1_", 3749222960, "Ebony.Base.String", 248, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialApexName2_", 2590020376, "Ebony.Base.String", 264, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialMigName2_", 528170375, "Ebony.Base.String", 280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialApexName3_", 2589873281, "Ebony.Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialMigName3_", 528317470, "Ebony.Base.String", 312, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialApexName4_", 3663493802, "Ebony.Base.String", 328, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialMigName4_", 527184637, "Ebony.Base.String", 344, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialApexName5_", 2589579091, "Ebony.Base.String", 360, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialMigName5_", 3748634580, "Ebony.Base.String", 376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialApexName6_", 2589431996, "Ebony.Base.String", 392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialMigName6_", 3748781675, "Ebony.Base.String", 408, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialApexName7_", 3662949349, "Ebony.Base.String", 424, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialMigName7_", 527729090, "Ebony.Base.String", 440, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}