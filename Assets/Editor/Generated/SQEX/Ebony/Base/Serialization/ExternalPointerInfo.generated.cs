using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Base.Serialization
{
    public partial class ExternalPointerInfo : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public short protocol_;
		public object pointerAddress_;
		public object paramsBuffer_;
		public IList<string> keys_= new List<string>();
		public bool isIntrusive_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ExternalPointerInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Base.Serialization.ExternalPointerInfo", 0, SQEX.Ebony.Base.Serialization.ExternalPointerInfo.ObjectType, null, properties, 0, 72);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Base.Serialization.ExternalPointerInfo", base.GetFieldProperties(), -1426701892, -61620564);
            
			
			
			fieldProperties.AddProperty(new Property("protocol_", 1241599838, "uint16_t", 8, 2, 1, Property.PrimitiveType.Int16, 0, (char)0));
			fieldProperties.AddProperty(new Property("pointerAddress_", 1778064711, "void", 16, 8, 1, Property.PrimitiveType.Pointer, 0, (char)0));
			fieldProperties.AddProperty(new Property("paramsBuffer_", 1733373602, "Memory.Buffer", 24, 24, 1, Property.PrimitiveType.Buffer, 0, (char)0));
			fieldProperties.AddProperty(new Property("keys_", 25918934, "SQEX.Ebony.Std.DynamicArray< Ebony.Base.String, MEMORY_CATEGORY_SERIALIZE >", 48, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("isIntrusive_", 485473083, "bool", 64, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}