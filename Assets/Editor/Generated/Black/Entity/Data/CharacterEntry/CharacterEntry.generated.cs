using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.CharacterEntry
{
    public partial class CharacterEntry : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint EntryId;
		public string DisplayName= string.Empty;
		public bool IsVisible;
		public int ActorType_;
		public bool UseCharaParamId;
		public uint CharaParamId;
		public uint OverwriteParameterID_;
		public bool UseCharaParamId1;
		public uint CharaParamId1;
		public uint AIParamId;
		public uint LinkAnimId;
		public string ModelDirectPath= string.Empty;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> modelChangePathList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public int defaultModelChangeWear;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> modelChangeWearPathList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> modelChangeKineDriverDataList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> modelChangeKineDriverAfterBonamikDataList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> modelChangeBnmDataList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> ElementIdPathList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> PsdDataList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> HairDataList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> HairWorksDataList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public string HairWorksMaterial= string.Empty;
		public string HairWorksModelDirectPath= string.Empty;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> KineDriverDataList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> KineDriverAfterBonamikDataList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryMaterialParamArrayItem> MaterialParamList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryMaterialParamArrayItem>();
		public float lodScale_;
		public bool UseStyleEdit;
		public string LmAnimMdlData= string.Empty;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> LmAnimPackDataList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> LmAnimGraphDataList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public string AnimConstraintData= string.Empty;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> BnmDataList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public uint BnmPartsTableId;
		public int BgCollisionType;
		public uint DestructionId;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> ArticulationDataList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> DynamicsDataList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> BodyDriverDataList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> ClsnDataList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public bool OverlapInstanceIgnoreBaseScaling;
		public float StepOffset;
		public string vehicleChassisClsnData_= string.Empty;
		public uint InteractionParamId;
		public uint InteractionItemId;
		public bool ScopeOutFlag;
		public bool ScopeOutVisible;
		public float ScopeOutRange;
		public int ScopeOutRangeCheckInterval;
		public int ScopeOutUpdateCount;
		public string MapClsn= string.Empty;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> VlinkPathList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public int DefaultAIControllerType;
		public string AIGraphData= string.Empty;
		public string BodyGraphData= string.Empty;
		public string Command0= string.Empty;
		public string Command1= string.Empty;
		public string Command2= string.Empty;
		public string Command2Sub= string.Empty;
		public string CommandUpdate= string.Empty;
		public string TypeCommonAI0= string.Empty;
		public string Schedule0= string.Empty;
		public string Schedule1= string.Empty;
		public string InitializeOnlyAI0= string.Empty;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> PartsIdList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem>();
		public uint SoundFootStep;
		public string RustleLongSoundFile_= string.Empty;
		public string RustleShortSoundFile_= string.Empty;
		public string RustleStandSoundFile_= string.Empty;
		public string RustleSitSoundFile_= string.Empty;
		public string RustleFootSoundFile_= string.Empty;
		public string WingFlapUpFile_= string.Empty;
		public string WingFlapDownFile_= string.Empty;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> SwingKnockFileNames_= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> SwingRubFileNames_= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public string RagdollImpactFile_= string.Empty;
		public string ProcedualSoundConfig_= string.Empty;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> ExtraSoundFileNames= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public int autoSeType_;
		public uint seParam_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> AddTagList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem>();
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> VehicleIdList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem>();
		public string ModelSwapPartsName= string.Empty;
		public uint NotifyAlterna;
		public uint NotifyDeath;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CharacterEntry();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.CharacterEntry.CharacterEntry", 0, Black.Entity.Data.CharacterEntry.CharacterEntry.ObjectType, Construct, properties, 0, 1128);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.CharacterEntry.CharacterEntry", base.GetFieldProperties(), 1243728343, 1220872069);
            
			
			
			fieldProperties.AddProperty(new Property("EntryId", 349772766, "SQEX.Ebony.Std.Fixid", 64, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("DisplayName", 4176258230, "Ebony.Base.String", 72, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsVisible", 1619861713, "bool", 88, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("ActorType_", 4103772927, "Black.Entity.Data.CharacterEntry.ActorType", 92, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("UseCharaParamId", 294074413, "bool", 96, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("CharaParamId", 4137985136, "SQEX.Ebony.Std.Fixid", 100, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("OverwriteParameterID_", 3918159725, "SQEX.Ebony.Std.Fixid", 104, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("UseCharaParamId1", 3017626644, "bool", 108, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("CharaParamId1", 2251199059, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("AIParamId", 2063532321, "SQEX.Ebony.Std.Fixid", 116, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("LinkAnimId", 4157378617, "SQEX.Ebony.Std.Fixid", 120, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("ModelDirectPath", 812399388, "Ebony.Base.String", 128, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("modelChangePathList", 480761121, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 144, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("defaultModelChangeWear", 3986392656, "int", 160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("modelChangeWearPathList", 2983719502, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 168, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("modelChangeKineDriverDataList", 3359030141, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 184, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("modelChangeKineDriverAfterBonamikDataList", 3196505954, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 200, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("modelChangeBnmDataList", 2345172485, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("ElementIdPathList", 1723481717, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 232, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("PsdDataList", 1322893920, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 248, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("HairDataList", 3145964629, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 264, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("HairWorksDataList", 4018658433, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 280, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("HairWorksMaterial", 2395632288, "Ebony.Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("HairWorksModelDirectPath", 3861790268, "Ebony.Base.String", 312, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("KineDriverDataList", 576749466, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 328, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("KineDriverAfterBonamikDataList", 1442495917, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 344, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("MaterialParamList", 2946822109, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryMaterialParamArrayItem* >", 360, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("lodScale_", 2867814239, "float", 376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("UseStyleEdit", 3392387581, "bool", 380, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("LmAnimMdlData", 2154717626, "Ebony.Base.String", 384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("LmAnimPackDataList", 4013434146, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 400, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("LmAnimGraphDataList", 3564968405, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 416, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("AnimConstraintData", 1169253295, "SQEX.Ebony.Base.String", 432, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("BnmDataList", 3278817892, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 448, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("BnmPartsTableId", 44106007, "SQEX.Ebony.Std.Fixid", 464, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("BgCollisionType", 1865369846, "Black.Physics.BgCollision.Type", 468, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("DestructionId", 2546312718, "SQEX.Ebony.Std.Fixid", 472, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("ArticulationDataList", 668394956, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 480, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("DynamicsDataList", 1461574135, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 496, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("BodyDriverDataList", 2267914815, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 512, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("ClsnDataList", 441415247, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 528, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("OverlapInstanceIgnoreBaseScaling", 4022525993, "bool", 544, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("StepOffset", 1171268820, "float", 548, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vehicleChassisClsnData_", 1501847432, "Ebony.Base.String", 552, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("InteractionParamId", 1371082773, "SQEX.Ebony.Std.Fixid", 568, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("InteractionItemId", 1886233057, "SQEX.Ebony.Std.Fixid", 572, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("ScopeOutFlag", 4176780927, "bool", 576, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("ScopeOutVisible", 643103801, "bool", 577, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("ScopeOutRange", 1974573642, "float", 580, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ScopeOutRangeCheckInterval", 1333446127, "int", 584, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ScopeOutUpdateCount", 3722316083, "int", 588, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("MapClsn", 3236838475, "Ebony.Base.String", 592, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("VlinkPathList", 1223459594, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 608, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("DefaultAIControllerType", 3323660916, "Black.Actor.Component.Controller.CONTROLLER_TYPE", 624, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("AIGraphData", 1637626765, "Ebony.Base.String", 632, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("BodyGraphData", 2582831039, "Ebony.Base.String", 648, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("Command0", 3625301830, "Ebony.Base.String", 664, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("Command1", 3642079449, "Ebony.Base.String", 680, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("Command2", 3591746592, "Ebony.Base.String", 696, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("Command2Sub", 334985570, "Ebony.Base.String", 712, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("CommandUpdate", 951047787, "Ebony.Base.String", 728, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("TypeCommonAI0", 3895023262, "Ebony.Base.String", 744, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("Schedule0", 4263585876, "Ebony.Base.String", 760, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("Schedule1", 4280363495, "Ebony.Base.String", 776, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("InitializeOnlyAI0", 194601277, "Ebony.Base.String", 792, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("PartsIdList", 3699899496, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem* >", 808, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("SoundFootStep", 1025725018, "SQEX.Ebony.Std.Fixid", 824, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("RustleLongSoundFile_", 2739310008, "Ebony.Base.String", 832, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("RustleShortSoundFile_", 3169563620, "Ebony.Base.String", 848, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("RustleStandSoundFile_", 1379424838, "Ebony.Base.String", 864, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("RustleSitSoundFile_", 4097595298, "Ebony.Base.String", 880, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("RustleFootSoundFile_", 4105828122, "Ebony.Base.String", 896, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("WingFlapUpFile_", 3359133335, "Ebony.Base.String", 912, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("WingFlapDownFile_", 3716564952, "Ebony.Base.String", 928, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("SwingKnockFileNames_", 1720174960, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 944, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("SwingRubFileNames_", 3884738409, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 960, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("RagdollImpactFile_", 412200121, "Ebony.Base.String", 976, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("ProcedualSoundConfig_", 1627971988, "Ebony.Base.String", 992, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("ExtraSoundFileNames", 1178693666, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 1008, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("autoSeType_", 3937233219, "Black.Entity.Data.CharacterEntry.CharacterEntry.SE_TYPES", 1024, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("seParam_", 1721741655, "SQEX.Ebony.Std.Fixid", 1028, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("AddTagList", 19569668, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem* >", 1032, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("VehicleIdList", 1361348606, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem* >", 1048, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("ModelSwapPartsName", 523539518, "Ebony.Base.String", 1064, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("NotifyAlterna", 3117274429, "SQEX.Ebony.Std.Fixid", 1080, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("NotifyDeath", 2586583966, "SQEX.Ebony.Std.Fixid", 1084, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new CharacterEntry();
        }
		
    }
}