using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Map
{
    public partial class NavigationOffMeshMultiLink : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Entity.Map.NavigationOffMeshMultiLinkPointAttr> linkDatas_= new List<Black.Entity.Map.NavigationOffMeshMultiLinkPointAttr>();
		public bool isBidirectional_;
		public int linkUser_;
		public uint archetype_;
		public int linkType_;
		public bool isDisabled_;
		public uint message_;
		public uint oppositeMessage_;
		public bool hasTimeScale_;
		public float speedScale_;
		public int blackUniqueKeyFixUp_;
		public int pointsPerSegment_;
		public bool enableDebugDrawing_;
		public bool isArrivalSpeedSet_;
		public float arrivalSpeed_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NavigationOffMeshMultiLink();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Map.NavigationOffMeshMultiLink", 0, Black.Entity.Map.NavigationOffMeshMultiLink.ObjectType, null, properties, 0, 384);
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

            fieldProperties = new PropertyContainer("Black.Entity.Map.NavigationOffMeshMultiLink", base.GetFieldProperties(), 816126815, -2023226518);
            
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entitySearchLabelId_", 3840219358, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("linkDatas_", 1782854419, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Map.NavigationOffMeshMultiLinkPointAttr* >", 256, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("isBidirectional_", 3856910237, "bool", 272, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("linkUser_", 2656796139, "Black.Entity.Map.LinkUser", 276, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("archetype_", 2517067113, "SQEX.Ebony.Std.Fixid", 280, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("linkType_", 2979162330, "Black.Recast.NavOffMeshLinkData.LinkType", 284, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isDisabled_", 1469758718, "bool", 288, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("message_", 3825450593, "SQEX.Ebony.Std.Fixid", 292, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("oppositeMessage_", 2179951696, "SQEX.Ebony.Std.Fixid", 296, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("hasTimeScale_", 4033564093, "bool", 300, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("speedScale_", 2243301447, "float", 304, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blackUniqueKeyFixUp_", 3415231837, "uint32_t", 308, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("pointsPerSegment_", 1145661963, "uint32_t", 312, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableDebugDrawing_", 841526986, "bool", 316, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isArrivalSpeedSet_", 2930709604, "bool", 317, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("arrivalSpeed_", 2124291374, "float", 320, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}