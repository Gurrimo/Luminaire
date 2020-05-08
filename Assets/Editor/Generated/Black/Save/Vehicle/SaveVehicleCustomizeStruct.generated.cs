using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Vehicle
{
    public partial class SaveVehicleCustomizeStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Save.Vehicle.SaveVehicleColorStruct> unlockedBodyColor_= new List<Black.Save.Vehicle.SaveVehicleColorStruct>();
		public IList<Black.Save.Vehicle.SaveVehicleColorStruct> unlockedInteriorColor_= new List<Black.Save.Vehicle.SaveVehicleColorStruct>();
		public IList<Black.Save.Vehicle.SaveVehicleColorStruct> unlockedTireColor_= new List<Black.Save.Vehicle.SaveVehicleColorStruct>();
		public IList<Black.Save.Vehicle.SaveVehicleUnlockStruct> unlockedSetSticker_= new List<Black.Save.Vehicle.SaveVehicleUnlockStruct>();
		public IList<Black.Save.Vehicle.SaveVehicleUnlockStruct> unlockedLeftSticker_= new List<Black.Save.Vehicle.SaveVehicleUnlockStruct>();
		public IList<Black.Save.Vehicle.SaveVehicleUnlockStruct> unlockedRightSticker_= new List<Black.Save.Vehicle.SaveVehicleUnlockStruct>();
		public IList<Black.Save.Vehicle.SaveVehicleUnlockStruct> unlockedTopSticker_= new List<Black.Save.Vehicle.SaveVehicleUnlockStruct>();
		public IList<Black.Save.Vehicle.SaveVehicleUnlockStruct> unlockedFrontSticker_= new List<Black.Save.Vehicle.SaveVehicleUnlockStruct>();
		public IList<Black.Save.Vehicle.SaveVehicleUnlockStruct> unlockedRearSticker_= new List<Black.Save.Vehicle.SaveVehicleUnlockStruct>();
		public IList<Black.Save.Vehicle.SaveVehiclePartsStruct> unlockedParts_= new List<Black.Save.Vehicle.SaveVehiclePartsStruct>();
		public int lastUnlockedBodyColorNum_;
		public int lastUnlockedInteriorColorNum_;
		public int lastUnlockedTireColorNum_;
		public int lastUnlockedSetStickerNum_;
		public int lastUnlockedLeftStickerNum_;
		public int lastUnlockedRightStickerNum_;
		public int lastUnlockedTopStickerNum_;
		public int lastUnlockedFrontStickerNum_;
		public int lastUnlockedRearStickerNum_;
		public int lastUnlockedPartsStickerNum_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveVehicleCustomizeStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Vehicle.SaveVehicleCustomizeStruct", 0, Black.Save.Vehicle.SaveVehicleCustomizeStruct.ObjectType, null, properties, 0, 200);
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

            fieldProperties = new PropertyContainer("Black.Save.Vehicle.SaveVehicleCustomizeStruct", null, -1995153951, 1857417584);
            
			
			
			fieldProperties.AddProperty(new Property("unlockedBodyColor_", 3917115184, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleColorStruct >", 0, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("unlockedInteriorColor_", 2201831860, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleColorStruct >", 16, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("unlockedTireColor_", 524124462, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleColorStruct >", 32, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("unlockedSetSticker_", 2365804548, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleUnlockStruct >", 48, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("unlockedLeftSticker_", 3156463473, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleUnlockStruct >", 64, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("unlockedRightSticker_", 1989736002, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleUnlockStruct >", 80, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("unlockedTopSticker_", 3937195671, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleUnlockStruct >", 96, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("unlockedFrontSticker_", 2032559179, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleUnlockStruct >", 112, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("unlockedRearSticker_", 2621735942, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleUnlockStruct >", 128, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("unlockedParts_", 1769477459, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehiclePartsStruct >", 144, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("lastUnlockedBodyColorNum_", 1107433002, "int", 160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("lastUnlockedInteriorColorNum_", 2511083822, "int", 164, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("lastUnlockedTireColorNum_", 2876887736, "int", 168, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("lastUnlockedSetStickerNum_", 1416634030, "int", 172, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("lastUnlockedLeftStickerNum_", 3653506109, "int", 176, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("lastUnlockedRightStickerNum_", 217067500, "int", 180, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("lastUnlockedTopStickerNum_", 980982483, "int", 184, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("lastUnlockedFrontStickerNum_", 2924902327, "int", 188, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("lastUnlockedRearStickerNum_", 2588551632, "int", 192, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("lastUnlockedPartsStickerNum_", 2657585660, "int", 196, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}