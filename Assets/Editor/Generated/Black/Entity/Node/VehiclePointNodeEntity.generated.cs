using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class VehiclePointNodeEntity : Black.Entity.Node.PointNodeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint destId_;
		public uint destNameId_;
		public uint destTabId_;
		public uint mapIconID_;
		public bool asDestinationPoint_;
		public int destType_;
		public string destName_;
		public uint groupedDestId_;
		public float canGetOffRange_;
		public bool canEnterOnOutOfGus_;
		public bool isParkOnRoadShoulder_;
		public float nearDistance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VehiclePointNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.VehiclePointNodeEntity", 0, Black.Entity.Node.VehiclePointNodeEntity.ObjectType, null, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.VehiclePointNodeEntity", base.GetFieldProperties(), 1104864131, -735842491);
            
			fieldProperties.AddProperty(new Property("destId_", 4063674269, "SQEX.Ebony.Std.Fixid", 304, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("destNameId_", 2158701436, "SQEX.Ebony.Std.Fixid", 308, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("destTabId_", 3192882314, "SQEX.Ebony.Std.Fixid", 312, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("mapIconID_", 3421776266, "SQEX.Ebony.Std.Fixid", 316, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("asDestinationPoint_", 1555594272, "bool", 320, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("destType_", 133053286, "Black.Entity.Node.VehiclePointNodeEntity.DestinationType", 324, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("destName_", 591471211, "Ebony.Base.String", 328, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupedDestId_", 1165480741, "SQEX.Ebony.Std.Fixid", 344, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("canGetOffRange_", 2458799874, "float", 348, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("canEnterOnOutOfGus_", 16456587, "bool", 352, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isParkOnRoadShoulder_", 1720542955, "bool", 353, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("nearDistance_", 2581621333, "float", 356, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}