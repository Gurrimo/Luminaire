using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Diner
{
    public partial class SaveDinerStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint currentDinerId_;
		public IList<Black.Save.Diner.SaveDinerDataStruct> dataLists_= new List<Black.Save.Diner.SaveDinerDataStruct>();
		public IList<Black.Save.Diner.SaveDinerInformationStruct> informationLists_= new List<Black.Save.Diner.SaveDinerInformationStruct>();
		public IList<Black.Save.Diner.SaveDinerPlaceStruct> placeLists_= new List<Black.Save.Diner.SaveDinerPlaceStruct>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveDinerStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Diner.SaveDinerStruct", 0, Black.Save.Diner.SaveDinerStruct.ObjectType, null, properties, 0, 56);
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

            fieldProperties = new PropertyContainer("Black.Save.Diner.SaveDinerStruct", null, -1730978843, -1347547320);
            
			
			
			fieldProperties.AddProperty(new Property("currentDinerId_", 3144816060, "SQEX.Ebony.Std.Fixid", 0, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("dataLists_", 1324438219, "SQEX.Ebony.Std.DynamicArray< Black.Save.Diner.SaveDinerDataStruct >", 8, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("informationLists_", 3101435611, "SQEX.Ebony.Std.DynamicArray< Black.Save.Diner.SaveDinerInformationStruct >", 24, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("placeLists_", 2050659134, "SQEX.Ebony.Std.DynamicArray< Black.Save.Diner.SaveDinerPlaceStruct >", 40, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}