using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Mobhunt
{
    public partial class SaveMobhuntMainStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int version_;
		public Black.Save.Mobhunt.SaveMobhuntStruct mobhuntDinnerData;
		public int killCount_;
		public int killCount1_;
		public int killCount2_;
		public int currenDinnerId_;
		public int rank_;
		public int exp_;
		public int currentDinnerQuestTargetId_;
		public Black.Save.Mobhunt.SaveMobhuntVDataStruct mobhuntVData;
		public bool isFistMobhuntClear_;
		public bool isAdamanClear_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMobhuntMainStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Mobhunt.SaveMobhuntMainStruct", 0, Black.Save.Mobhunt.SaveMobhuntMainStruct.ObjectType, null, properties, 0, 166568);
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

            fieldProperties = new PropertyContainer("Black.Save.Mobhunt.SaveMobhuntMainStruct", null, -518804172, -297682609);
            
			fieldProperties.AddProperty(new Property("version_", 2901812440, "uint32_t", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("mobhuntDinnerData", 2671003544, "Black.Save.Mobhunt.SaveMobhuntStruct", 8, 164352, 64, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("killCount_", 374553101, "int", 164360, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("killCount1_", 3063082932, "int", 164364, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("killCount2_", 3063230027, "int", 164368, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("currenDinnerId_", 3273085240, "uint32_t", 164372, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("rank_", 821720808, "uint32_t", 164376, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("exp_", 4079435861, "uint32_t", 164380, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("currentDinnerQuestTargetId_", 927721797, "uint32_t", 164384, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("mobhuntVData", 3304439366, "Black.Save.Mobhunt.SaveMobhuntVDataStruct", 164388, 2176, 16, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("isFistMobhuntClear_", 2449351192, "bool", 166564, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isAdamanClear_", 4272792135, "bool", 166565, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}