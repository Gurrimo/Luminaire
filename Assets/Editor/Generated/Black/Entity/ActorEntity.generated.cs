using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity
{
    public partial class ActorEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string charaEntry_;
		public bool setInactiveAtSpawn_;
		public bool setFadeAtSpawn_;
		public bool isHideInitialForScript_;
		public bool isHideInitial_;
		public float scaling_;
		public uint overwriteParameterID_;
		public string sourcePathAI_;
		public string sourcePathAIGraph_;
		public int actorType_;
		public uint overwriteInteractionParamId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.ActorEntity", 0, Black.Entity.ActorEntity.ObjectType, null, properties, 0, 352);
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

            fieldProperties = new PropertyContainer("Black.Entity.ActorEntity", base.GetFieldProperties(), 1896381988, 1070462923);
            
			fieldProperties.AddProperty(new Property("charaEntry_", 1111613605, "Ebony.Base.String", 256, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("setInactiveAtSpawn_", 2964083311, "bool", 272, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("setFadeAtSpawn_", 1788900928, "bool", 273, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isHideInitialForScript_", 2174414902, "bool", 274, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isHideInitial_", 2350856204, "bool", 275, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("scaling_", 3325430311, "float", 276, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("overwriteParameterID_", 1970039245, "SQEX.Ebony.Std.Fixid", 280, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourcePathAI_", 482071410, "Ebony.Base.String", 288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourcePathAIGraph_", 3998915884, "Ebony.Base.String", 304, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorType_", 364512479, "Black.Entity.Data.CharacterEntry.ActorType", 320, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("overwriteInteractionParamId_", 4230144195, "SQEX.Ebony.Std.Fixid", 324, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}