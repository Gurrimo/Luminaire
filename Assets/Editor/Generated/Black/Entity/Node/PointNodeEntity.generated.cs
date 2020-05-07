using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class PointNodeEntity : Black.Entity.Node.PointNodeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool scriptVisible_;
		public int pointType_;
		public uint paramId_;
		public uint interactionParamId_;
		public uint interactionItemId_;
		public int positionAttribute_;
		public int warpAutoTurnMode_;
		public int warpPostCameraMode_;
		public int warpPostCameraBlendMode_;
		public float warpPostCameraBlendTime_;
		public float warpPostCameraBlendSpeed_;
		public uint warpGroupId_;
		public float magicThunderDamageRangeRadius_;
		public float wallCoverRangeRadius_;
		public int wallCoverDirection_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PointNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.PointNodeEntity", 0, Black.Entity.Node.PointNodeEntity.ObjectType, null, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.PointNodeEntity", base.GetFieldProperties(), 996580910, -808608432);
            
			fieldProperties.AddProperty(new Property("scriptVisible_", 3997823017, "bool", 288, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("pointType_", 3734080690, "Black.Actor.Node.ActorNodePoint.PointType", 292, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("paramId_", 69034432, "SQEX.Ebony.Std.Fixid", 296, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionParamId_", 3572570526, "SQEX.Ebony.Std.Fixid", 300, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionItemId_", 4287093562, "SQEX.Ebony.Std.Fixid", 304, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("positionAttribute_", 2920331307, "Black.Actor.Node.ActorNodePoint.PositionAttribute", 308, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("warpAutoTurnMode_", 154831017, "Black.Actor.Node.ActorNodePoint.WarpAutoTurnMode", 312, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("warpPostCameraMode_", 2909596714, "Black.Actor.Node.ActorNodePoint.WarpPostCameraMode", 316, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("warpPostCameraBlendMode_", 3357062819, "Black.Camera.BlendModeType", 320, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("warpPostCameraBlendTime_", 425628309, "float", 324, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("warpPostCameraBlendSpeed_", 1662977097, "float", 328, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("warpGroupId_", 1673879260, "SQEX.Ebony.Std.Fixid", 332, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("magicThunderDamageRangeRadius_", 143671363, "float", 336, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("wallCoverRangeRadius_", 530834660, "float", 340, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("wallCoverDirection_", 1107488746, "Black.Actor.Node.ActorNodeWallCoverPoint.DirectionType", 344, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}