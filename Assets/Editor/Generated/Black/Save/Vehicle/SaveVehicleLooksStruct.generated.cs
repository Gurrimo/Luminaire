using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Vehicle
{
    public partial class SaveVehicleLooksStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Save.Vehicle.SaveVehicleMaterialStruct> material_= new List<Black.Save.Vehicle.SaveVehicleMaterialStruct>();
		public uint colorId_;
		public uint setStickerId_;
		public Black.Save.Vehicle.SaveVehicleStickerStruct sticker_;
		public bool isUseSticker_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveVehicleLooksStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Vehicle.SaveVehicleLooksStruct", 0, Black.Save.Vehicle.SaveVehicleLooksStruct.ObjectType, null, properties, 0, 280);
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

            fieldProperties = new PropertyContainer("Black.Save.Vehicle.SaveVehicleLooksStruct", null, 1576290877, -580518508);
            
			
			
			fieldProperties.AddProperty(new Property("material_", 1026806573, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleMaterialStruct >", 0, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("colorId_", 1217984206, "SQEX.Ebony.Std.Fixid", 16, 12, 3, Property.PrimitiveType.Fixid, 0, (char)8));
			fieldProperties.AddProperty(new Property("setStickerId_", 1622061076, "SQEX.Ebony.Std.Fixid", 28, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("sticker_", 4030219641, "Black.Save.Vehicle.SaveVehicleStickerStruct", 32, 240, 5, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("isUseSticker_", 1700759220, "bool", 272, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}