using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class ActorBindTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isCharCollisionDisable_;
		public bool isBGCollisionDisable_;
		public float bgEnabledInterpolationTime_;
		public float bgEnabledSearchGroundLength_;
		public bool isInashaDisable_;
		public bool isResetMove_;
		public bool isWeaponOff_;
		public bool isTeleport_;
		public bool isActiveMask_;
		public bool isActiveCommandMask_;
		public bool isIkMask_;
		public bool isResetAI_;
		public bool isResetBody_;
		public bool isResetAnim_;
		public bool noAnimBlend_;
		public bool resetMotionPlaybackRateScaler_;
		public bool isResetBonamik_;
		public int bonamikPreRollStep_;
		public bool useMvBonamikPreRoll_;
		public bool isTrajectoryAlignDisable_;
		public bool isAnimRootFullControl_;
		public bool isResetMasts_;
		public bool isPresence_;
		public bool setCanUserCommand_;
		public bool isSoundFootDisable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorBindTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.ActorBindTrackItem", 0, Black.System.TimeLine.TrackItem.ActorBindTrackItem.ObjectType, null, properties, 0, 128);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.ActorBindTrackItem", base.GetFieldProperties(), 630843904, -69983489);
            
			fieldProperties.AddProperty(new Property("isCharCollisionDisable_", 1068324914, "bool", 88, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isBGCollisionDisable_", 934030259, "bool", 89, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bgEnabledInterpolationTime_", 2832323711, "float", 92, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("bgEnabledSearchGroundLength_", 2791187141, "float", 96, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isInashaDisable_", 3110863348, "bool", 100, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isResetMove_", 3144676678, "bool", 101, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isWeaponOff_", 3024394347, "bool", 102, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isTeleport_", 1855219043, "bool", 103, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isActiveMask_", 2173089452, "bool", 104, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isActiveCommandMask_", 629450569, "bool", 105, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isIkMask_", 2595679882, "bool", 106, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isResetAI_", 1558676307, "bool", 107, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isResetBody_", 1060739161, "bool", 108, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isResetAnim_", 1052104094, "bool", 109, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("noAnimBlend_", 1214469143, "bool", 110, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("resetMotionPlaybackRateScaler_", 2865889034, "bool", 111, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isResetBonamik_", 1527163942, "bool", 112, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bonamikPreRollStep_", 511136871, "int", 116, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("useMvBonamikPreRoll_", 2785373563, "bool", 120, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isTrajectoryAlignDisable_", 1347382276, "bool", 121, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isAnimRootFullControl_", 1046077531, "bool", 122, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isResetMasts_", 1831752999, "bool", 123, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isPresence_", 4177708497, "bool", 124, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("setCanUserCommand_", 2315174790, "bool", 125, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isSoundFootDisable_", 741122001, "bool", 126, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}