using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.TimeControl.TimeLine
{
    public partial class TimeLine : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float workAreaLeft_;
		public float workAreaRight_;
		public IList<SQEX.Ebony.Framework.Sequence.Action.TimeLine.Struct.TimeLineReferenceValue> subTimeLineList_= new List<SQEX.Ebony.Framework.Sequence.Action.TimeLine.Struct.TimeLineReferenceValue>();
		public IList<SQEX.Ebony.Framework.Sequence.Action.TimeLine.Struct.TimeLineReferenceValue> mainTimeLineList_= new List<SQEX.Ebony.Framework.Sequence.Action.TimeLine.Struct.TimeLineReferenceValue>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TimeLine();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.TimeControl.TimeLine.TimeLine", 0, SQEX.Ebony.Framework.TimeControl.TimeLine.TimeLine.ObjectType, Construct, properties, 0, 120);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.TimeControl.TimeLine.TimeLine", base.GetFieldProperties(), 1862539080, 1461767129);
            
			fieldProperties.AddIndirectlyProperty(new Property("childTrackList_", 2693454425, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.TimeControl.TimeLine.Track* >", 8, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			
			
			fieldProperties.AddProperty(new Property("workAreaLeft_", 123503249, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("workAreaRight_", 1736467130, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("subTimeLineList_", 3072916375, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Sequence.Action.TimeLine.Struct.TimeLineReferenceValue* >", 32, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("mainTimeLineList_", 861050676, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Sequence.Action.TimeLine.Struct.TimeLineReferenceValue* >", 48, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new TimeLine();
        }
		
    }
}