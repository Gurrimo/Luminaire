using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable.Compare
{
    public partial class SequenceCompareCollectionString : SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareCollectionBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareString> conditions_= new List<SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareString>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceCompareCollectionString();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareCollectionString", 0, SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareCollectionString.ObjectType, Construct, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareCollectionString", base.GetFieldProperties(), -717148122, 1495215250);
            
			
			
			fieldProperties.AddProperty(new Property("conditions_", 3387481400, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareString* >", 8, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceCompareCollectionString();
        }
		
    }
}