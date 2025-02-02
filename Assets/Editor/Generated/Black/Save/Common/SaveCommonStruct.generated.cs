//----------------------
// <auto-generated>
// This file was automatically generated. Any changes to it will be lost if and when the file is regenerated.
// </auto-generated>
//----------------------
#pragma warning disable

using System;
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;
using CodeDom = System.CodeDom;

namespace Black.Save.Common
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class SaveCommonStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint presenceId_;
		public bool forbidSaveAnywhereFlag_;
		public int reserved_;
		public long reserved2_;
		public int noxScore_;
		[UnityEngine.SerializeReference] public Black.Save.Multiplay.SavePlantMapDataStruct plantMapData_= new Black.Save.Multiplay.SavePlantMapDataStruct();
		[UnityEngine.SerializeReference] public Black.Save.Common.SaveEpiScore ignis_= new Black.Save.Common.SaveEpiScore();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveCommonStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Common.SaveCommonStruct", 0, Black.Save.Common.SaveCommonStruct.ObjectType, null, properties, 0, 5008);
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

            fieldProperties = new PropertyContainer("Black.Save.Common.SaveCommonStruct", null, -1051156837, 1652488587);
            
			fieldProperties.AddIndirectlyProperty(new Property("plantMapData_.isCompletedLesta_", 3246911394, "bool", 612, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("plantMapData_.iconDataList_", 3893701621, "Black.Save.Multiplay.SavePlantMapDataStruct.IconDataStruct", 616, 4000, 500, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("ignis_.chapter", 3094383061, "Black.Save.Common.EPI_RESULT_SCENE", 4616, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("ignis_.score", 1269919122, "int32_t", 4620, 384, 8, Property.PrimitiveType.Int32, 0, (char)8));
			
			
			fieldProperties.AddProperty(new Property("presenceId_", 3492320450, "SQEX.Ebony.Std.Fixid", 0, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("forbidSaveAnywhereFlag_", 3485292166, "bool", 4, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("reserved_", 2083388678, "int", 8, 200, 50, Property.PrimitiveType.Int32, 0, (char)8));
			fieldProperties.AddProperty(new Property("reserved2_", 3587458470, "int64_t", 208, 400, 50, Property.PrimitiveType.Int64, 0, (char)8));
			fieldProperties.AddProperty(new Property("noxScore_", 4000410673, "uint32_t", 608, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("plantMapData_", 1555303457, "Black.Save.Multiplay.SavePlantMapDataStruct", 612, 4004, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ignis_", 824974638, "Black.Save.Common.SaveEpiScore", 4616, 388, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}