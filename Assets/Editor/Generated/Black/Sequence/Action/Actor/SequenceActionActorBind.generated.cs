using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionActorBind : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin bind_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin unBind_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public int filterLevel_;
		public bool isScopeEnd_;
		public bool isCollision_;
		public bool isBGCollisionDisable_;
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
		public float bgEnabledInterpolationTime_;
		public float bgEnabledSearchGroundLength_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorBind();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionActorBind", 0, Black.Sequence.Action.Actor.SequenceActionActorBind.ObjectType, Construct, properties, 0, 600);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionActorBind", base.GetFieldProperties(), -1408613984, -1123484212);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bind_.pinName_", 2067900774, "Base.String", 192, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bind_.name_", 3357607601, "Base.String", 208, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bind_.connections_", 3630162993, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 224, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("bind_.delayType_", 1938334795, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 256, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bind_.delayTime_", 2433850048, "float", 260, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bind_.delayMaxTime_", 907224522, "float", 264, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("unBind_.pinName_", 1100688085, "Base.String", 288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("unBind_.name_", 3221451856, "Base.String", 304, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("unBind_.connections_", 2521201694, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 320, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("unBind_.delayType_", 4287344076, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 352, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("unBind_.delayTime_", 3783003647, "float", 356, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("unBind_.delayMaxTime_", 30040711, "float", 360, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.pinName_", 1137295951, "Base.String", 384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.name_", 2182257194, "Base.String", 400, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.connections_", 2048532136, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 416, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayType_", 124432558, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 448, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayTime_", 3264366185, "float", 452, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayMaxTime_", 456551125, "float", 456, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actor_.pinName_", 3335040042, "Base.String", 480, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actor_.name_", 3822690741, "Base.String", 496, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actor_.connections_", 213149741, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 512, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("actor_.pinValueType_", 4068350780, "Base.String", 544, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("bind_", 960446179, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("unBind_", 2919297618, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 280, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 376, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actor_", 3434601855, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 472, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("filterLevel_", 124193320, "Black.Event.ActorBindFilterLevel", 560, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isScopeEnd_", 1299671061, "bool", 564, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCollision_", 2452954592, "bool", 565, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isBGCollisionDisable_", 934030259, "bool", 566, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isInashaDisable_", 3110863348, "bool", 567, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isResetMove_", 3144676678, "bool", 568, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isWeaponOff_", 3024394347, "bool", 569, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isTeleport_", 1855219043, "bool", 570, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isActiveMask_", 2173089452, "bool", 571, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isActiveCommandMask_", 629450569, "bool", 572, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isIkMask_", 2595679882, "bool", 573, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isResetAI_", 1558676307, "bool", 574, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isResetBody_", 1060739161, "bool", 575, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isResetAnim_", 1052104094, "bool", 576, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("noAnimBlend_", 1214469143, "bool", 577, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("resetMotionPlaybackRateScaler_", 2865889034, "bool", 578, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isResetBonamik_", 1527163942, "bool", 579, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bonamikPreRollStep_", 511136871, "int", 580, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("useMvBonamikPreRoll_", 2785373563, "bool", 584, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isTrajectoryAlignDisable_", 1347382276, "bool", 585, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isAnimRootFullControl_", 1046077531, "bool", 586, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isResetMasts_", 1831752999, "bool", 587, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isPresence_", 4177708497, "bool", 588, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("setCanUserCommand_", 2315174790, "bool", 589, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isSoundFootDisable_", 741122001, "bool", 590, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bgEnabledInterpolationTime_", 2832323711, "float", 592, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("bgEnabledSearchGroundLength_", 2791187141, "float", 596, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionActorBind();
        }
		
    }
}