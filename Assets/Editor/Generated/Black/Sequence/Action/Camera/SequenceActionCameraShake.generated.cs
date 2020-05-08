using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera
{
    public partial class SequenceActionCameraShake : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cameraActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sourceActorPin_;
		public bool enableRandomShakeOffset_;
		public int shakeRandomFactorRangeMode_;
		public bool enableRandomRollZ_;
		public int rollZRandomFactorRangeMode_;
		public bool enableRandomUndampedDistance_;
		public int undampedDistanceRandomFactorRangeMode_;
		public bool enableRandomEndAttenuationDistance_;
		public int endAttenuationDistanceRandomFactorRangeMode_;
		public float activeTime_;
		public bool enableRandomShakeTimeWidth_;
		public Black.System.TimeLine.TrackItem.Camera.CameraShakeNodeTrackItem shakeParameter_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraShake();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.SequenceActionCameraShake", 0, Black.Sequence.Action.Camera.SequenceActionCameraShake.ObjectType, Construct, properties, 0, 1120);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.SequenceActionCameraShake", base.GetFieldProperties(), 217117542, -3787018);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enable_.pinName_", 4270245062, "Base.String", 376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enable_.name_", 3233852753, "Base.String", 392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enable_.connections_", 620504401, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 408, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("enable_.delayType_", 2298283947, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 440, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enable_.delayTime_", 646367136, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enable_.delayMaxTime_", 1143749866, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("disable_.pinName_", 1281388507, "Base.String", 472, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("disable_.name_", 2292768278, "Base.String", 488, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("disable_.connections_", 104452908, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 504, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("disable_.delayType_", 2882399586, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 536, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("disable_.delayTime_", 2377718501, "float", 540, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("disable_.delayMaxTime_", 1879485633, "float", 544, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.pinName_", 1137295951, "Base.String", 568, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.name_", 2182257194, "Base.String", 584, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.connections_", 2048532136, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 600, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayType_", 124432558, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 632, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayTime_", 3264366185, "float", 636, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("out_.delayMaxTime_", 456551125, "float", 640, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finished_.pinName_", 649611931, "Base.String", 664, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finished_.name_", 1803835094, "Base.String", 680, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finished_.connections_", 2429315820, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 696, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("finished_.delayType_", 108840482, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 728, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finished_.delayTime_", 3516349093, "float", 732, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finished_.delayMaxTime_", 1581096321, "float", 736, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cameraActorPin_.pinName_", 1110337782, "Base.String", 760, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cameraActorPin_.name_", 3328430017, "Base.String", 776, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cameraActorPin_.connections_", 3699365665, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 792, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("cameraActorPin_.pinValueType_", 3273162808, "Base.String", 824, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sourceActorPin_.pinName_", 3652086852, "Base.String", 848, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sourceActorPin_.name_", 3448383583, "Base.String", 864, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sourceActorPin_.connections_", 713081871, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 880, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("sourceActorPin_.pinValueType_", 4150069154, "Base.String", 912, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("shakeParameter_.name_", 1248593239, "Ebony.Base.String", 984, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("shakeParameter_.startTime_", 2645890295, "float", 1000, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("shakeParameter_.duration_", 3962950482, "float", 1004, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("shakeParameter_.shakeOffset_", 1724596683, "Luminous.Math.VectorA", 1072, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("shakeParameter_.rollZ_", 2029046205, "float", 1088, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("shakeParameter_.undampedDistance_", 3001015987, "float", 1092, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("shakeParameter_.endAttenuationDistance_", 3742773598, "float", 1096, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("shakeParameter_.randomShakeTimeWidth_", 1516338116, "float", 1100, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("shakeParameter_.randomShakeScale_", 745131783, "float", 1104, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			
			
			fieldProperties.AddProperty(new Property("enable_", 3925052483, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("disable_", 1760805492, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("finished_", 3052293812, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cameraActorPin_", 1707765395, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 752, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourceActorPin_", 3706314901, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 840, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableRandomShakeOffset_", 2141515243, "bool", 928, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("shakeRandomFactorRangeMode_", 3554902946, "Black.System.TimeLine.TrackItem.Camera.CameraShakeTrackItem.RandomRangeFactorMode", 932, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableRandomRollZ_", 3790358621, "bool", 936, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rollZRandomFactorRangeMode_", 2285221795, "Black.System.TimeLine.TrackItem.Camera.CameraShakeTrackItem.RandomRangeFactorMode", 940, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableRandomUndampedDistance_", 1957369555, "bool", 944, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("undampedDistanceRandomFactorRangeMode_", 3310127673, "Black.System.TimeLine.TrackItem.Camera.CameraShakeTrackItem.RandomRangeFactorMode", 948, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableRandomEndAttenuationDistance_", 3566532670, "bool", 952, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("endAttenuationDistanceRandomFactorRangeMode_", 109627262, "Black.System.TimeLine.TrackItem.Camera.CameraShakeTrackItem.RandomRangeFactorMode", 956, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("activeTime_", 3298494899, "float", 960, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableRandomShakeTimeWidth_", 3135282409, "bool", 964, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("shakeParameter_", 1134684621, "Black.System.TimeLine.TrackItem.Camera.CameraShakeNodeTrackItem", 976, 144, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionCameraShake();
        }
		
    }
}