using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Mobhunt
{
    public partial class SaveMobhuntVDataStructNew
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int id_;
		public uint elementId_;
		public Black.Save.Mobhunt.SaveMobhuntPartsDataStruct partsDataArray_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMobhuntVDataStructNew();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Mobhunt.SaveMobhuntVDataStructNew", 0, Black.Save.Mobhunt.SaveMobhuntVDataStructNew.ObjectType, null, properties, 0, 88);
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

            fieldProperties = new PropertyContainer("Black.Save.Mobhunt.SaveMobhuntVDataStructNew", null, -89854037, -814090212);
            
			fieldProperties.AddProperty(new Property("id_", 2899315373, "int", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("elementId_", 1896981983, "SQEX.Ebony.Std.Fixid", 4, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("partsDataArray_", 2733104507, "Black.Save.Mobhunt.SaveMobhuntPartsDataStruct", 8, 80, 10, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}