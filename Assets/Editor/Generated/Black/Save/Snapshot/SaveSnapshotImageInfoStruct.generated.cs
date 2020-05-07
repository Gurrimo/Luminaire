using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Snapshot
{
    public partial class SaveSnapshotImageInfoStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int id_;
		public IList<uint> attributes_;
		public long time_;
		public uint photoLayerId_;
		public SQEX.Luminous.Math.DoubleVector4 worldPosition_;
		public sbyte importantType_;
		public sbyte phaseType_;
		public bool isMarked_;
		public uint photoJenre_;
		public uint targetIds_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveSnapshotImageInfoStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Snapshot.SaveSnapshotImageInfoStruct", 0, Black.Save.Snapshot.SaveSnapshotImageInfoStruct.ObjectType, null, properties, 0, 96);
        }
		
        public  ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected  PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Save.Snapshot.SaveSnapshotImageInfoStruct", null, -299908639, -1229791341);
            
			
			
			fieldProperties.AddProperty(new Property("id_", 2899315373, "uint32_t", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("attributes_", 2428960913, "Luminous.Std.DynamicArray< SQEX.Ebony.Std.Fixid >", 8, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("time_", 2171152225, "int64_t", 24, 8, 1, Property.PrimitiveType.Int64, 0, (char)0));
			fieldProperties.AddProperty(new Property("photoLayerId_", 3032227098, "SQEX.Ebony.Std.Fixid", 32, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("worldPosition_", 1278966829, "Luminous.Math.DoubleVector4", 40, 32, 1, Property.PrimitiveType.DoubleVector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("importantType_", 530293910, "uint8_t", 72, 1, 1, Property.PrimitiveType.Int8, 0, (char)0));
			fieldProperties.AddProperty(new Property("phaseType_", 3187536733, "uint8_t", 73, 1, 1, Property.PrimitiveType.Int8, 0, (char)0));
			fieldProperties.AddProperty(new Property("isMarked_", 3213040106, "bool", 74, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("photoJenre_", 4104625270, "SQEX.Ebony.Std.Fixid", 76, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetIds_", 481716855, "SQEX.Ebony.Std.Fixid", 80, 12, 3, Property.PrimitiveType.Fixid, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}