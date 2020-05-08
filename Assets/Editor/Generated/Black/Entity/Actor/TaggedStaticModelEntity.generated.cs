using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Actor
{
    public partial class TaggedStaticModelEntity : Black.Entity.StaticModelEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> tags_= new List<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TaggedStaticModelEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Actor.TaggedStaticModelEntity", 0, Black.Entity.Actor.TaggedStaticModelEntity.ObjectType, null, properties, 0, 432);
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

            fieldProperties = new PropertyContainer("Black.Entity.Actor.TaggedStaticModelEntity", base.GetFieldProperties(), 1484455732, -2113033516);
            
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
			
			
			fieldProperties.AddProperty(new Property("tags_", 1058374253, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem* >", 416, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			
			
			return fieldProperties;
        }

		
    }
}