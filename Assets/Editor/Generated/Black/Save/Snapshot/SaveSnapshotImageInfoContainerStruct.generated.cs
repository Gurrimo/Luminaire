using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Snapshot
{
    public partial class SaveSnapshotImageInfoContainerStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Save.Snapshot.SaveSnapshotImageInfoStruct> snapshots_= new List<Black.Save.Snapshot.SaveSnapshotImageInfoStruct>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveSnapshotImageInfoContainerStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Snapshot.SaveSnapshotImageInfoContainerStruct", 0, Black.Save.Snapshot.SaveSnapshotImageInfoContainerStruct.ObjectType, null, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("Black.Save.Snapshot.SaveSnapshotImageInfoContainerStruct", null, -294219470, -338428046);
            
			
			
			fieldProperties.AddProperty(new Property("snapshots_", 3838243167, "Luminous.Std.DynamicArray< Black.Save.Snapshot.SaveSnapshotImageInfoStruct >", 0, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}