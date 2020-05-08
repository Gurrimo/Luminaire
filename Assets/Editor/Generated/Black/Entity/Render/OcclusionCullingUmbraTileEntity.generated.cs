using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Render
{
    public partial class OcclusionCullingUmbraTileEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string umbraFilePath_= string.Empty;
		public bool shadowEnable_;
		public bool useDefaultParameters_;
		public float smallestHole_;
		public float occlusionRadius_;
		public float smallestOccluder_;
		public float backfaceLimit_;
		public bool useDefaultViewVolume_;
		public UnityEngine.Vector4 viewVolumeMin_;
		public UnityEngine.Vector4 viewVolumeMax_;
		public bool autoAdjustViewVolume_;
		public UnityEngine.Vector4 viewVolumeSizeOffset_;
		public bool useTile_;
		public UnityEngine.Vector4 tileSize_;
		public int idForGlobalIdentify_;
		public bool outputSceneFile_;
		public bool deleteUsdlFile_;
		public bool triggerEnable_;
		public int triggerType_;
		public float triggerRadius_;
		public float triggerHeight_;
		public float triggerWidth_;
		public float triggerDepth_;
		public float unloadMargin_;
		public UnityEngine.Vector4 triggerOffset_;
		public int nextLoadTileNum_;
		public int priority_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new OcclusionCullingUmbraTileEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Render.OcclusionCullingUmbraTileEntity", 0, Black.Entity.Render.OcclusionCullingUmbraTileEntity.ObjectType, Construct, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Entity.Render.OcclusionCullingUmbraTileEntity", base.GetFieldProperties(), -1135407434, 1274491350);
            
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entitySearchLabelId_", 3840219358, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("umbraFilePath_", 2204803364, "SQEX.Luminous.Base.String", 256, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowEnable_", 3171565903, "bool", 272, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("useDefaultParameters_", 4146892662, "bool", 273, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("smallestHole_", 3033479275, "float", 276, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("occlusionRadius_", 624255869, "float", 280, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("smallestOccluder_", 1571744808, "float", 284, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("backfaceLimit_", 4125758587, "float", 288, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("useDefaultViewVolume_", 2457634203, "bool", 292, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("viewVolumeMin_", 3937238403, "LM_NS_MATH.VectorA", 304, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("viewVolumeMax_", 2169567465, "LM_NS_MATH.VectorA", 320, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoAdjustViewVolume_", 38331111, "bool", 336, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("viewVolumeSizeOffset_", 121698109, "LM_NS_MATH.VectorA", 352, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("useTile_", 684158509, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("tileSize_", 3300634565, "LM_NS_MATH.VectorA", 384, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("idForGlobalIdentify_", 3620700973, "uint32_t", 400, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputSceneFile_", 670573903, "bool", 404, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("deleteUsdlFile_", 1779096161, "bool", 405, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerEnable_", 1412487753, "bool", 406, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerType_", 1915532364, "Black.Entity.Area.MapPackage.MapLoadTriggerType", 408, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerRadius_", 1726467370, "float", 412, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerHeight_", 3110277449, "float", 416, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerWidth_", 2849620798, "float", 420, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerDepth_", 123604937, "float", 424, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("unloadMargin_", 3851656225, "float", 428, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerOffset_", 315293853, "SQEX.Luminous.Math.VectorA", 432, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("nextLoadTileNum_", 3767674525, "int", 448, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("priority_", 3125928034, "int", 452, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new OcclusionCullingUmbraTileEntity();
        }
		
    }
}