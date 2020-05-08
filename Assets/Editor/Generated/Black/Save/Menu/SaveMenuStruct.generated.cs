using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Menu
{
    public partial class SaveMenuStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int version_;
		public uint activeQuestId_;
		public uint activeQuestDestId_;
		public IList<uint> discoveredLocations_= new List<uint>();
		public IList<Black.Save.Menu.SaveMenuFootprint> footPrints_= new List<Black.Save.Menu.SaveMenuFootprint>();
		public int userDestType_;
		public uint userDestId_;
		public SQEX.Luminous.Math.DoubleVector4 userDestLocation_;
		public int visibleFlag_;
		public IList<uint> battleItemOrderList_= new List<uint>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMenuStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Menu.SaveMenuStruct", 0, Black.Save.Menu.SaveMenuStruct.ObjectType, null, properties, 0, 128);
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

            fieldProperties = new PropertyContainer("Black.Save.Menu.SaveMenuStruct", null, -578333456, -1940980057);
            
			
			
			fieldProperties.AddProperty(new Property("version_", 2901812440, "uint32_t", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("activeQuestId_", 2514697095, "SQEX.Ebony.Std.Fixid", 4, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("activeQuestDestId_", 3596301019, "SQEX.Ebony.Std.Fixid", 8, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("discoveredLocations_", 3848122714, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Std.Fixid >", 16, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("footPrints_", 4033528686, "SQEX.Ebony.Std.DynamicArray< Black.Save.Menu.SaveMenuFootprint >", 48, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("userDestType_", 2802031991, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("userDestId_", 288269808, "SQEX.Ebony.Std.Fixid", 68, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("userDestLocation_", 295366426, "SQEX.Luminous.Math.DoubleVector4", 72, 32, 1, Property.PrimitiveType.DoubleVector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("visibleFlag_", 1733649548, "int", 104, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleItemOrderList_", 981168029, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Std.Fixid >", 112, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}