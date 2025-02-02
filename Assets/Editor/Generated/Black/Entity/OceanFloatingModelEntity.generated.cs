//----------------------
// <auto-generated>
// This file was automatically generated. Any changes to it will be lost if and when the file is regenerated.
// </auto-generated>
//----------------------
#pragma warning disable

using System;
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;
using CodeDom = System.CodeDom;

namespace Black.Entity
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class OceanFloatingModelEntity : Black.Entity.StaticModelEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool followOceanSurface_;
		public bool followOceanNormal_;
		public float damping_;
		[UnityEngine.SerializeReference] public List<Black.Entity.WaterExclusionBoxParameter> waterExclusionBoxParams_= new List<Black.Entity.WaterExclusionBoxParameter>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new OceanFloatingModelEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.OceanFloatingModelEntity", 0, Black.Entity.OceanFloatingModelEntity.ObjectType, Construct, properties, 0, 496);
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

            fieldProperties = new PropertyContainer("Black.Entity.OceanFloatingModelEntity", base.GetFieldProperties(), -2129348248, -834126960);
            
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entitySearchLabelId_", 3840219358, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sourcePath_", 341055184, "Ebony.Base.String", 256, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sourceHighSpecPath_", 2930328893, "Ebony.Base.String", 272, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("scaling_", 3325430311, "float", 288, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("visible_", 3296750298, "bool", 292, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("scriptVisibleOff_", 1178151850, "bool", 293, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lodLevelHold_", 1405210608, "bool", 294, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lodScaling_", 4277247494, "float", 296, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("linkAnimId_", 1980597938, "SQEX.Ebony.Std.Fixid", 300, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("casterShadow_", 1875170918, "bool", 304, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("receiveShadow_", 4251594463, "bool", 305, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("ignoreIndoorLightProbes_", 339085568, "bool", 306, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("depthOnly_", 2344384041, "bool", 307, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useMeshCollision_", 468627668, "bool", 308, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setMeshCollisionOff_", 1547327668, "bool", 309, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("MeshCollision_", 2780030513, "Ebony.Base.String", 312, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useMeshCollisionMovingTile_", 1615091370, "bool", 328, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useMeshCollisionAirMovingTile_", 4074814524, "bool", 329, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("naviMeshBuildType_", 455690061, "Black.Entity.StaticModelEntity.NaviMeshBuildType", 332, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("materialParamColor_", 3459353649, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Material.MaterialParameterColor* >", 336, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("materialParamValue1_", 636517702, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Material.MaterialParameterValue1* >", 352, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("materialParamValue4_", 3856878739, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Material.MaterialParameterValue4* >", 368, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isTerrainBakeEnabled_", 506619421, "bool", 384, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isFoliageCheckThrough_", 1457859362, "bool", 385, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turfBaseObject_", 1134715033, "bool", 386, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("umbraIsBakeTarget_", 4216184219, "bool", 387, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("umbraIsBakeTargetEvenIncludesTranslucent_", 1181221071, "bool", 388, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("followOceanSurface_", 26947686, "bool", 440, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("followOceanNormal_", 3447629734, "bool", 441, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("damping_", 3302352382, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("waterExclusionBoxParams_", 616124268, "SQEX.Ebony.Std.DynamicArray< Black.Entity.WaterExclusionBoxParameter*, MEMORY_CATEGORY_OCEAN >", 448, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new OceanFloatingModelEntity();
        }
		
    }
}