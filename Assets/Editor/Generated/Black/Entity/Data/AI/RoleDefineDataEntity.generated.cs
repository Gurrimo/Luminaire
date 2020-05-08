using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.AI
{
    public partial class RoleDefineDataEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string name_= string.Empty;
		public uint charaEntryId1_;
		public uint charaEntryId2_;
		public uint charaEntryId3_;
		public bool bAnyChar_;
		public bool bPriorityNear_;
		public bool bCandidateLeader_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new RoleDefineDataEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.AI.RoleDefineDataEntity", 0, Black.Entity.Data.AI.RoleDefineDataEntity.ObjectType, null, properties, 0, 112);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.AI.RoleDefineDataEntity", base.GetFieldProperties(), -1563992405, -542564075);
            
			
			
			fieldProperties.AddProperty(new Property("name_", 182823483, "Ebony.Base.String", 64, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("charaEntryId1_", 1810113593, "SQEX.Ebony.Std.Fixid", 80, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("charaEntryId2_", 1810658046, "SQEX.Ebony.Std.Fixid", 84, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("charaEntryId3_", 1810510951, "SQEX.Ebony.Std.Fixid", 88, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("bAnyChar_", 3732818910, "bool", 92, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bPriorityNear_", 2374205316, "bool", 93, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bCandidateLeader_", 3681859280, "bool", 94, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}