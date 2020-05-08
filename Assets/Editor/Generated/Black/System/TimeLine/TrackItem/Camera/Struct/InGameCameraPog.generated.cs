using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraPog : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int lockOnType_;
		public int actorBaseType_;
		public int lockOnActorOffsetType_;
		public uint boneId_;
		public int coordInterpType_;
		public float pogInterpTime_;
		public int pogTimeInterpMode_;
		public float pogVelocity_;
		public bool isUpdateYDirectly_;
		public float pogDirectionYVelocity_;
		public int matrixType_;
		public int offsetType_;
		public UnityEngine.Vector4 pogOffset_;
		public bool isUseAddOffsetXByProjectionBetweenPCandTarget_;
		public float addOffsetXSabunMultiplyRate_;
		public float addOffsetXMaxLimit_;
		public bool isUpdateXEveryFrame_;
		public bool isUpdateYEveryFrame__;
		public bool isUpdateZEveryFrame_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraPog();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPog", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPog.ObjectType, Construct, properties, 0, 112);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPog", base.GetFieldProperties(), -2009302530, 1169079133);
            
			
			
			fieldProperties.AddProperty(new Property("lockOnType_", 1417918068, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnType", 8, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorBaseType_", 3300297616, "Black.Camera.SeamlessInGameActorBaseType", 12, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("lockOnActorOffsetType_", 142195356, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnActorOffsetType", 16, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("boneId_", 2693567367, "SQEX.Ebony.Std.Fixid", 20, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("coordInterpType_", 702223873, "Black.Camera.CoordInterpType", 24, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("pogInterpTime_", 1016810007, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("pogTimeInterpMode_", 3934416474, "SQEX.Ebony.Framework.TimeControl.InterpMode", 32, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("pogVelocity_", 2289512791, "float", 36, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("isUpdateYDirectly_", 4025580790, "bool", 40, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("pogDirectionYVelocity_", 3695418067, "float", 44, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("matrixType_", 2625693249, "Black.Camera.MatrixType", 48, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetType_", 296891151, "Black.Camera.SeamlessInGameOffsetType", 52, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("pogOffset_", 2266260815, "Luminous.Math.VectorA", 64, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddProperty(new Property("isUseAddOffsetXByProjectionBetweenPCandTarget_", 3904137768, "bool", 96, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("addOffsetXSabunMultiplyRate_", 2909979513, "float", 100, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("addOffsetXMaxLimit_", 527312485, "float", 104, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("isUpdateXEveryFrame_", 3087219209, "bool", 108, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUpdateYEveryFrame__", 4146338457, "bool", 109, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUpdateZEveryFrame_", 2447887599, "bool", 110, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new InGameCameraPog();
        }
		
    }
}