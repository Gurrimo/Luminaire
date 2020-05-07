using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity
{
    public partial class StaticModelEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string sourcePath_;
		public string sourceHighSpecPath_;
		public float scaling_;
		public bool visible_;
		public bool scriptVisibleOff_;
		public bool lodLevelHold_;
		public float lodScaling_;
		public uint linkAnimId_;
		public bool casterShadow_;
		public bool receiveShadow_;
		public bool ignoreIndoorLightProbes_;
		public bool depthOnly_;
		public bool useMeshCollision_;
		public bool setMeshCollisionOff_;
		public string MeshCollision_;
		public bool useMeshCollisionMovingTile_;
		public bool useMeshCollisionAirMovingTile_;
		public int naviMeshBuildType_;
		public IList<Black.Entity.Material.MaterialParameterColor> materialParamColor_;
		public IList<Black.Entity.Material.MaterialParameterValue1> materialParamValue1_;
		public IList<Black.Entity.Material.MaterialParameterValue4> materialParamValue4_;
		public bool isTerrainBakeEnabled_;
		public bool isFoliageCheckThrough_;
		public bool turfBaseObject_;
		public bool umbraIsBakeTarget_;
		public bool umbraIsBakeTargetEvenIncludesTranslucent_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new StaticModelEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.StaticModelEntity", 0, Black.Entity.StaticModelEntity.ObjectType, null, properties, 0, 416);
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

            fieldProperties = new PropertyContainer("Black.Entity.StaticModelEntity", base.GetFieldProperties(), -1890832539, 1835478383);
            
			fieldProperties.AddProperty(new Property("sourcePath_", 341055184, "Ebony.Base.String", 256, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourceHighSpecPath_", 2930328893, "Ebony.Base.String", 272, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("scaling_", 3325430311, "float", 288, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("visible_", 3296750298, "bool", 292, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("scriptVisibleOff_", 1178151850, "bool", 293, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("lodLevelHold_", 1405210608, "bool", 294, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("lodScaling_", 4277247494, "float", 296, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("linkAnimId_", 1980597938, "SQEX.Ebony.Std.Fixid", 300, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("casterShadow_", 1875170918, "bool", 304, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("receiveShadow_", 4251594463, "bool", 305, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("ignoreIndoorLightProbes_", 339085568, "bool", 306, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("depthOnly_", 2344384041, "bool", 307, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("useMeshCollision_", 468627668, "bool", 308, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("setMeshCollisionOff_", 1547327668, "bool", 309, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("MeshCollision_", 2780030513, "Ebony.Base.String", 312, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("useMeshCollisionMovingTile_", 1615091370, "bool", 328, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("useMeshCollisionAirMovingTile_", 4074814524, "bool", 329, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("naviMeshBuildType_", 455690061, "Black.Entity.StaticModelEntity.NaviMeshBuildType", 332, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialParamColor_", 3459353649, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Material.MaterialParameterColor* >", 336, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialParamValue1_", 636517702, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Material.MaterialParameterValue1* >", 352, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialParamValue4_", 3856878739, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Material.MaterialParameterValue4* >", 368, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("isTerrainBakeEnabled_", 506619421, "bool", 384, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isFoliageCheckThrough_", 1457859362, "bool", 385, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("turfBaseObject_", 1134715033, "bool", 386, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("umbraIsBakeTarget_", 4216184219, "bool", 387, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("umbraIsBakeTargetEvenIncludesTranslucent_", 1181221071, "bool", 388, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}