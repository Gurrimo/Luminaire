using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Group
{
    public partial class SequenceGroupUserDefOnly : SQEX.Ebony.Framework.Sequence.Group.SequenceGroupBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceGroupUserDefOnly();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Group.SequenceGroupUserDefOnly", 0, SQEX.Ebony.Framework.Sequence.Group.SequenceGroupUserDefOnly.ObjectType, Construct, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Group.SequenceGroupUserDefOnly", base.GetFieldProperties(), -2017124847, -1586746641);
            
			
			
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceGroupUserDefOnly();
        }
		
    }
}