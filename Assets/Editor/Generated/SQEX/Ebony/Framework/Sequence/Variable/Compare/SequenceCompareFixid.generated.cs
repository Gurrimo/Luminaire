using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable.Compare
{
    public partial class SequenceCompareFixid : SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceCompareFixid();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareFixid", 0, SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareFixid.ObjectType, Construct, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareFixid", base.GetFieldProperties(), 1230227705, -1908724628);
            
			fieldProperties.AddIndirectlyProperty(new Property("pDependencyPin_", 1541179946, "void", 8, 8, 1, Property.PrimitiveType.Pointer, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("operator_", 305375494, "SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareBase.OperatorType", 24, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("value_.value_", 2391826589, "SQEX.Ebony.Std.Fixid", 40, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("value_", 273093519, "SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData", 32, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceCompareFixid();
        }
		
    }
}