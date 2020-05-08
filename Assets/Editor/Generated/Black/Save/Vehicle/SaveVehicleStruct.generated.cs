using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Vehicle
{
    public partial class SaveVehicleStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int version_;
		public Black.Save.Vehicle.SaveVehicleStatusStruct status_;
		public Black.Save.Vehicle.SaveVehicleCustomizeStruct customize_;
		public IList<int> reserve_= new List<int>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveVehicleStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Vehicle.SaveVehicleStruct", 0, Black.Save.Vehicle.SaveVehicleStruct.ObjectType, null, properties, 0, 1216);
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

            fieldProperties = new PropertyContainer("Black.Save.Vehicle.SaveVehicleStruct", null, 129730024, 1459156238);
            
			fieldProperties.AddIndirectlyProperty(new Property("status_.rideStatus_", 3045579495, "int32_t", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status_.pos_", 538340989, "double", 24, 24, 3, Property.PrimitiveType.Double, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status_.rotate_", 1210978258, "Luminous.Math.VectorA", 48, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status_.restFuel_", 996063977, "float", 64, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status_.totalDistance_", 2498156384, "float", 68, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status_.hp_", 715716439, "int", 72, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status_.maxHp_", 3571042961, "int", 76, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status_.roofState_", 979925638, "int", 80, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status_.visitedParkingList_", 205402253, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleVisitedParkingStruct >", 88, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status_.isFreeSelectDriveMode_", 394393184, "bool", 104, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status_.specLevel_", 3239199694, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleSpecStruct >", 112, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status_.looks_", 775820979, "Black.Save.Vehicle.SaveVehicleLooksStruct", 128, 840, 3, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status_.isAirCraft_", 4124827329, "bool", 968, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status_.albumId_", 2135093017, "SQEX.Ebony.Std.Fixid", 972, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status_.musicId_", 352475737, "SQEX.Ebony.Std.Fixid", 976, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.unlockedBodyColor_", 2530508364, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleColorStruct >", 992, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.unlockedInteriorColor_", 3078354224, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleColorStruct >", 1008, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.unlockedTireColor_", 4280528826, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleColorStruct >", 1024, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.unlockedSetSticker_", 4061469488, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleUnlockStruct >", 1040, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.unlockedLeftSticker_", 2621895061, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleUnlockStruct >", 1056, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.unlockedRightSticker_", 217345918, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleUnlockStruct >", 1072, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.unlockedTopSticker_", 766626323, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleUnlockStruct >", 1088, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.unlockedFrontSticker_", 2873556919, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleUnlockStruct >", 1104, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.unlockedRearSticker_", 452701410, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleUnlockStruct >", 1120, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.unlockedParts_", 3432457327, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehiclePartsStruct >", 1136, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.lastUnlockedBodyColorNum_", 961052086, "int", 1152, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.lastUnlockedInteriorColorNum_", 4127457578, "int", 1156, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.lastUnlockedTireColorNum_", 1864420132, "int", 1160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.lastUnlockedSetStickerNum_", 1175357114, "int", 1164, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.lastUnlockedLeftStickerNum_", 3960860705, "int", 1168, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.lastUnlockedRightStickerNum_", 2317037288, "int", 1172, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.lastUnlockedTopStickerNum_", 765447583, "int", 1176, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.lastUnlockedFrontStickerNum_", 1972162675, "int", 1180, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.lastUnlockedRearStickerNum_", 3672567372, "int", 1184, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("customize_.lastUnlockedPartsStickerNum_", 1346192000, "int", 1188, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("version_", 2901812440, "uint32_t", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("status_", 4107102736, "Black.Save.Vehicle.SaveVehicleStatusStruct", 16, 976, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("customize_", 902257093, "Black.Save.Vehicle.SaveVehicleCustomizeStruct", 992, 200, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserve_", 3115688060, "SQEX.Ebony.Std.DynamicArray< int >", 1192, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}