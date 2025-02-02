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

namespace Black.Save.Multiplay
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class SaveAvatarColorSet
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		[UnityEngine.SerializeReference] public Black.Save.Multiplay.SaveAvatarColor Color1= new Black.Save.Multiplay.SaveAvatarColor();
		[UnityEngine.SerializeReference] public Black.Save.Multiplay.SaveAvatarColor Color2= new Black.Save.Multiplay.SaveAvatarColor();
		[UnityEngine.SerializeReference] public Black.Save.Multiplay.SaveAvatarColor Color3= new Black.Save.Multiplay.SaveAvatarColor();
		[UnityEngine.SerializeReference] public Black.Save.Multiplay.SaveAvatarColor Color4= new Black.Save.Multiplay.SaveAvatarColor();
		[UnityEngine.SerializeReference] public Black.Save.Multiplay.SaveAvatarColor Color5= new Black.Save.Multiplay.SaveAvatarColor();
		[UnityEngine.SerializeReference] public Black.Save.Multiplay.SaveAvatarColor Color6= new Black.Save.Multiplay.SaveAvatarColor();
		[UnityEngine.SerializeReference] public Black.Save.Multiplay.SaveAvatarColor Color7= new Black.Save.Multiplay.SaveAvatarColor();
		[UnityEngine.SerializeReference] public Black.Save.Multiplay.SaveAvatarColor Color8= new Black.Save.Multiplay.SaveAvatarColor();
		[UnityEngine.SerializeReference] public Black.Save.Multiplay.SaveAvatarColor Color9= new Black.Save.Multiplay.SaveAvatarColor();
		[UnityEngine.SerializeReference] public Black.Save.Multiplay.SaveAvatarColor Color10= new Black.Save.Multiplay.SaveAvatarColor();
		[UnityEngine.SerializeReference] public Black.Save.Multiplay.SaveAvatarColor Color11= new Black.Save.Multiplay.SaveAvatarColor();
		[UnityEngine.SerializeReference] public Black.Save.Multiplay.SaveAvatarColor Color12= new Black.Save.Multiplay.SaveAvatarColor();
		[UnityEngine.SerializeReference] public Black.Save.Multiplay.SaveAvatarColor Color13= new Black.Save.Multiplay.SaveAvatarColor();
		[UnityEngine.SerializeReference] public Black.Save.Multiplay.SaveAvatarColor Color14= new Black.Save.Multiplay.SaveAvatarColor();
		[UnityEngine.SerializeReference] public Black.Save.Multiplay.SaveAvatarColor Color15= new Black.Save.Multiplay.SaveAvatarColor();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveAvatarColorSet();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Multiplay.SaveAvatarColorSet", 0, Black.Save.Multiplay.SaveAvatarColorSet.ObjectType, null, properties, 0, 240);
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

            fieldProperties = new PropertyContainer("Black.Save.Multiplay.SaveAvatarColorSet", null, 73179319, -1316285610);
            
			fieldProperties.AddIndirectlyProperty(new Property("Color1.R", 646346423, "float", 0, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color1.G", 830900232, "float", 4, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color1.B", 914788327, "float", 8, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color1.IsDefault", 3359682260, "bool", 12, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color2.R", 3109589894, "float", 16, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color2.G", 3461919893, "float", 20, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color2.B", 3378031798, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color2.IsDefault", 2169472853, "bool", 28, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color3.R", 1092894829, "float", 32, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color3.G", 740564830, "float", 36, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color3.B", 824452925, "float", 40, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color3.IsDefault", 1441247494, "bool", 44, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color4.R", 2874690948, "float", 48, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color4.G", 3092799995, "float", 52, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color4.B", 3143132852, "float", 56, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color4.IsDefault", 1221324031, "bool", 60, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color5.R", 3526643115, "float", 64, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color5.G", 3845417876, "float", 68, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color5.B", 3795085019, "float", 72, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color5.IsDefault", 1069419208, "bool", 76, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color6.R", 2242248858, "float", 80, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color6.G", 1923474097, "float", 84, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color6.B", 1973806954, "float", 88, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color6.IsDefault", 2710186073, "bool", 92, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color7.R", 2894304193, "float", 96, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color7.G", 2676195146, "float", 100, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color7.B", 2625862289, "float", 104, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color7.IsDefault", 2354652314, "bool", 108, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color8.R", 2302313960, "float", 112, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color8.G", 2117760151, "float", 116, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color8.B", 2033872056, "float", 120, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color8.IsDefault", 2230055811, "bool", 124, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color9.R", 2954266127, "float", 128, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color9.G", 2601936128, "float", 132, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color9.B", 2685824223, "float", 136, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color9.IsDefault", 2190305228, "bool", 140, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color10.R", 4135622973, "float", 144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color10.G", 25209486, "float", 148, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color10.B", 109097581, "float", 152, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color10.IsDefault", 730444694, "bool", 156, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color11.R", 783686294, "float", 160, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color11.G", 599132485, "float", 164, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color11.B", 515244390, "float", 168, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color11.IsDefault", 3094903141, "bool", 172, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color12.R", 478217479, "float", 176, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color12.G", 125887480, "float", 180, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color12.B", 209775575, "float", 184, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color12.IsDefault", 578426980, "bool", 188, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color13.R", 1436813568, "float", 192, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color13.G", 1789143567, "float", 196, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color13.B", 1705255472, "float", 200, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color13.IsDefault", 1455226843, "bool", 204, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color14.R", 1642065041, "float", 208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color14.G", 1960839802, "float", 212, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color14.B", 1910506945, "float", 216, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color14.IsDefault", 3532863658, "bool", 220, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color15.R", 979667114, "float", 224, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color15.G", 1197776161, "float", 228, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color15.B", 1248109018, "float", 232, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("Color15.IsDefault", 889153001, "bool", 236, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("Color1", 1673244779, "Black.Save.Multiplay.SaveAvatarColor", 0, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color2", 1690022398, "Black.Save.Multiplay.SaveAvatarColor", 16, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color3", 1706800017, "Black.Save.Multiplay.SaveAvatarColor", 32, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color4", 1723577636, "Black.Save.Multiplay.SaveAvatarColor", 48, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color5", 1740355255, "Black.Save.Multiplay.SaveAvatarColor", 64, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color6", 1757132874, "Black.Save.Multiplay.SaveAvatarColor", 80, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color7", 1773910493, "Black.Save.Multiplay.SaveAvatarColor", 96, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color8", 1522246208, "Black.Save.Multiplay.SaveAvatarColor", 112, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color9", 1539023827, "Black.Save.Multiplay.SaveAvatarColor", 128, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color10", 1534500673, "Black.Save.Multiplay.SaveAvatarColor", 144, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color11", 1517723054, "Black.Save.Multiplay.SaveAvatarColor", 160, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color12", 1500945435, "Black.Save.Multiplay.SaveAvatarColor", 176, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color13", 1484167816, "Black.Save.Multiplay.SaveAvatarColor", 192, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color14", 1601611149, "Black.Save.Multiplay.SaveAvatarColor", 208, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color15", 1584833530, "Black.Save.Multiplay.SaveAvatarColor", 224, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}