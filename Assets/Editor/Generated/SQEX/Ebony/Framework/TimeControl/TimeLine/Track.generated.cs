using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.TimeControl.TimeLine
{
    public partial class Track : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string name_;
		public int trackType_;
		public int groupType_;
		public int trackDetailType_;
		public int trackItemType_;
		public bool isEnable_;
		public string activatePin_;
		public IList<SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem> trackItemList_;
		public IList<SQEX.Ebony.Framework.Sequence.SequenceActivatableNode> nodes_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new Track();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.TimeControl.TimeLine.Track", 0, SQEX.Ebony.Framework.TimeControl.TimeLine.Track.ObjectType, null, properties, 0, 184);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.TimeControl.TimeLine.Track", base.GetFieldProperties(), -632846832, -830786190);
            
			fieldProperties.AddProperty(new Property("name_", 182823483, "Ebony.Base.String", 24, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("trackType_", 16036337, "SQEX.Ebony.Framework.TimeControl.TimeLine.TrackType", 40, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupType_", 2996798561, "SQEX.Ebony.Framework.TimeControl.TimeLine.GroupType", 44, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("trackDetailType_", 1965630094, "SQEX.Ebony.Framework.TimeControl.TimeLine.TrackDetailType", 48, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("trackItemType_", 1172649212, "SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItemType", 52, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnable_", 4253513587, "bool", 56, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("activatePin_", 1654183488, "SQEX.Ebony.Base.String", 64, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("trackItemList_", 2107376044, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem* >", 80, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddProperty(new Property("nodes_", 61650911, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Sequence.SequenceActivatableNode* >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}