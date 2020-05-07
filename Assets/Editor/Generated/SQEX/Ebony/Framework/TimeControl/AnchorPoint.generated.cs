using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.TimeControl
{
    public partial class AnchorPoint : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float time_;
		public float value_;
		public float ySplit_;
		public UnityEngine.Vector4 control0_;
		public UnityEngine.Vector4 control1_;
		public int leftCurveType_;
		public int curveType_;
		public bool isSplitted_;
		public bool isSplittedControlPoint_;
		public bool hasExpandableHandles_;
		public bool hasBalanceHandles_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AnchorPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.TimeControl.AnchorPoint", 0, SQEX.Ebony.Framework.TimeControl.AnchorPoint.ObjectType, null, properties, 0, 80);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.TimeControl.AnchorPoint", base.GetFieldProperties(), 1092863664, 891530735);
            
			fieldProperties.AddProperty(new Property("time_", 2171152225, "float", 8, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("value_", 273093519, "float", 12, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ySplit_", 4033478601, "float", 16, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("control0_", 34077423, "Luminous.Math.VectorA", 32, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("control1_", 34224518, "Luminous.Math.VectorA", 48, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("leftCurveType_", 3489890052, "SQEX.Ebony.Framework.TimeControl.AnchorPoint.CurveType", 64, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("curveType_", 1783861753, "SQEX.Ebony.Framework.TimeControl.AnchorPoint.CurveType", 68, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isSplitted_", 3026870537, "bool", 72, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isSplittedControlPoint_", 170671862, "bool", 73, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("hasExpandableHandles_", 2610992435, "bool", 74, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("hasBalanceHandles_", 3329006705, "bool", 75, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}