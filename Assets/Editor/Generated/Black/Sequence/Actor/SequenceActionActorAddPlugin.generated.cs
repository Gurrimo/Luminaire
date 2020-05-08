using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorAddPlugin : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public int pluginType_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetActorPin_;
		public float spearInjectionSpeed_;
		public float spearAcceslarateParam_;
		public float spearJumpTimingTime_;
		public float deleteTimer_;
		public float spearSoldierJumpTimingHomingInterpolationTime_;
		public float soldierInterpolationTime_;
		public float targetHitRadius_;
		public float waitLimit_;
		public int homingType_;
		public float anchorInjectionSpeed_;
		public float homingTimer_;
		public float homingEnableTimer_;
		public float homingLimitMaxDeg_;
		public float homingInterpolationTime_;
		public uint anchorRightElementId_;
		public uint anchorLeftElementId_;
		public uint targetRightElementId_;
		public uint targetLeftElementId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorAddPlugin();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorAddPlugin", 0, Black.Sequence.Actor.SequenceActionActorAddPlugin.ObjectType, Construct, properties, 0, 632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorAddPlugin", base.GetFieldProperties(), 1482449552, -2096577658);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.pinName_", 3330161590, "Base.String", 192, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.name_", 192292993, "Base.String", 208, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.connections_", 490033121, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 224, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayType_", 261766523, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 256, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayTime_", 1689218608, "float", 260, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayMaxTime_", 1529341114, "float", 264, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.pinName_", 1137295951, "Base.String", 288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.name_", 2182257194, "Base.String", 304, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.connections_", 2048532136, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 320, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayType_", 124432558, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 352, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayTime_", 3264366185, "float", 356, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayMaxTime_", 456551125, "float", 360, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actor_.pinName_", 3335040042, "Base.String", 384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actor_.name_", 3822690741, "Base.String", 400, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actor_.connections_", 213149741, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 416, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("actor_.pinValueType_", 4068350780, "Base.String", 448, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetActorPin_.pinName_", 1051229172, "Base.String", 480, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetActorPin_.name_", 188225807, "Base.String", 496, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetActorPin_.connections_", 2518678943, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 512, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("targetActorPin_.pinValueType_", 2604514834, "Base.String", 544, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 280, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actor_", 3434601855, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 376, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pluginType_", 2202943391, "Black.Sequence.Actor.SequenceActionActorAddPlugin.PluginType", 464, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetActorPin_", 422699493, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 472, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("spearInjectionSpeed_", 777962223, "float", 560, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("spearAcceslarateParam_", 2544555760, "float", 564, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("spearJumpTimingTime_", 1054543674, "float", 568, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("deleteTimer_", 860267372, "float", 572, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("spearSoldierJumpTimingHomingInterpolationTime_", 4056841594, "float", 576, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("soldierInterpolationTime_", 2951983433, "float", 580, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetHitRadius_", 1518236668, "float", 584, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("waitLimit_", 2952217428, "float", 588, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("homingType_", 1881802026, "uint32_t", 592, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("anchorInjectionSpeed_", 802559717, "float", 596, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("homingTimer_", 1400526203, "float", 600, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("homingEnableTimer_", 3795162708, "float", 604, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("homingLimitMaxDeg_", 2153925087, "float", 608, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("homingInterpolationTime_", 3474449757, "float", 612, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("anchorRightElementId_", 3810881484, "SQEX.Ebony.Std.Fixid", 616, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("anchorLeftElementId_", 705406159, "SQEX.Ebony.Std.Fixid", 620, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetRightElementId_", 1930300256, "SQEX.Ebony.Std.Fixid", 624, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetLeftElementId_", 2502182411, "SQEX.Ebony.Std.Fixid", 628, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionActorAddPlugin();
        }
		
    }
}