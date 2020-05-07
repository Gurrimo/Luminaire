using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Wind
{
    public partial class BonamikWindPresetEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isEnable_;
		public uint bnmwnd0Id;
		public string bnmwnd0Path;
		public uint bnmwnd1Id;
		public string bnmwnd1Path;
		public uint bnmwnd2Id;
		public string bnmwnd2Path;
		public uint bnmwnd3Id;
		public string bnmwnd3Path;
		public uint bnmwnd4Id;
		public string bnmwnd4Path;
		public uint bnmwnd5Id;
		public string bnmwnd5Path;
		public uint bnmwnd6Id;
		public string bnmwnd6Path;
		public uint bnmwnd7Id;
		public string bnmwnd7Path;
		public uint bnmwnd8Id;
		public string bnmwnd8Path;
		public uint bnmwnd9Id;
		public string bnmwnd9Path;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BonamikWindPresetEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Wind.BonamikWindPresetEntity", 0, Black.Entity.Data.Wind.BonamikWindPresetEntity.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Wind.BonamikWindPresetEntity", base.GetFieldProperties(), -1668337179, -1898511682);
            
			fieldProperties.AddProperty(new Property("isEnable_", 4253513587, "bool", 64, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd0Id", 827056940, "SQEX.Ebony.Std.Fixid", 68, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd0Path", 519152018, "Ebony.Base.String", 72, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd1Id", 3579113195, "SQEX.Ebony.Std.Fixid", 88, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd1Path", 99444797, "Ebony.Base.String", 96, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd2Id", 2322181006, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd2Path", 1175553636, "Ebony.Base.String", 120, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd3Id", 528953389, "SQEX.Ebony.Std.Fixid", 136, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd3Path", 742851031, "Ebony.Base.String", 144, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd4Id", 64085840, "SQEX.Ebony.Std.Fixid", 160, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd4Path", 3662795238, "Ebony.Base.String", 168, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd5Id", 2565825519, "SQEX.Ebony.Std.Fixid", 184, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd5Path", 4142667969, "Ebony.Base.String", 192, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd6Id", 790238018, "SQEX.Ebony.Std.Fixid", 208, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd6Path", 3445464712, "Ebony.Base.String", 216, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd7Id", 3023535793, "SQEX.Ebony.Std.Fixid", 232, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd7Path", 3017881819, "Ebony.Base.String", 240, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd8Id", 3366553812, "SQEX.Ebony.Std.Fixid", 256, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd8Path", 3062294106, "Ebony.Base.String", 264, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd9Id", 765440627, "SQEX.Ebony.Std.Fixid", 280, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwnd9Path", 1314845893, "Ebony.Base.String", 288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}