using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity
{
    public partial class SkeletalModelEntity : Black.Entity.StaticModelEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string animModel_= string.Empty;
		public string animPack_= string.Empty;
		public string animGraph_= string.Empty;
		public string animClip_= string.Empty;
		public string bnmData_= string.Empty;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> clsnData_= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public int naviMeshUpdateType_;
		public bool umbraIsGate_;
		public string kineDriverData_= string.Empty;
		public string hairData_= string.Empty;
		public string hairWorksData_= string.Empty;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> hairWorksDataList_= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public string hairWorksMaterial_= string.Empty;
		public string hairWorksModelDirectPath_= string.Empty;
		public uint interactionParamId_;
		public uint interactionItemId_;
		public bool interactionMaskOff_;
		public uint interactionAttachBoneId_;
		public UnityEngine.Vector4 interactionAttachBoneOffset_;
		public int componentType_;
		public bool actorSlowEnabled_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SkeletalModelEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.SkeletalModelEntity", 0, Black.Entity.SkeletalModelEntity.ObjectType, null, properties, 0, 768);
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

            fieldProperties = new PropertyContainer("Black.Entity.SkeletalModelEntity", base.GetFieldProperties(), -2047471063, -1432273448);
            
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
			
			
			fieldProperties.AddProperty(new Property("animModel_", 1506932998, "Ebony.Base.String", 416, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("animPack_", 3062714746, "Ebony.Base.String", 432, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("animGraph_", 1402134577, "Ebony.Base.String", 448, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("animClip_", 2780642699, "Ebony.Base.String", 464, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmData_", 1116532569, "Ebony.Base.String", 480, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("clsnData_", 797135496, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 496, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("naviMeshUpdateType_", 2947277674, "Black.Entity.SkeletalModelEntity.NaviMeshUpdateType", 512, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("umbraIsGate_", 3965297522, "bool", 516, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("kineDriverData_", 1787284419, "Ebony.Base.String", 520, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("hairData_", 2086647970, "Ebony.Base.String", 536, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("hairWorksData_", 1452757742, "Ebony.Base.String", 552, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("hairWorksDataList_", 2689103450, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 568, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("hairWorksMaterial_", 3542579597, "Ebony.Base.String", 584, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("hairWorksModelDirectPath_", 4277343993, "Ebony.Base.String", 600, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionParamId_", 3572570526, "SQEX.Ebony.Std.Fixid", 616, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionItemId_", 4287093562, "SQEX.Ebony.Std.Fixid", 620, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionMaskOff_", 3728935017, "bool", 624, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionAttachBoneId_", 2647789846, "SQEX.Ebony.Std.Fixid", 628, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionAttachBoneOffset_", 2412011140, "Luminous.Math.VectorA", 640, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("componentType_", 2579083861, "Black.Actor.ActorComponentMap.ADDITIONAL_COMPONENT", 656, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorSlowEnabled_", 2911151581, "bool", 660, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}