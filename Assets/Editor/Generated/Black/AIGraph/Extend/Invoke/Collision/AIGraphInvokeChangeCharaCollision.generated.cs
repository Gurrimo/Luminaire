using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Collision
{
    public partial class AIGraphInvokeChangeCharaCollision : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isChangeCharaCollision_;
		public uint charaCollisionID_;
		public bool isChangeBGCollision_;
		public uint bgCollisionID_;
		public bool isChangeVsLimsCollision_;
		public uint vslimsCollisionID_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeChangeCharaCollision();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Collision.AIGraphInvokeChangeCharaCollision", 0, Black.AIGraph.Extend.Invoke.Collision.AIGraphInvokeChangeCharaCollision.ObjectType, Construct, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Collision.AIGraphInvokeChangeCharaCollision", base.GetFieldProperties(), 364587207, -2097095197);
            
			
			
			fieldProperties.AddProperty(new Property("isChangeCharaCollision_", 436079729, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("charaCollisionID_", 2069960986, "SQEX.Ebony.Std.Fixid", 28, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("isChangeBGCollision_", 2345286243, "bool", 32, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bgCollisionID_", 2054326028, "SQEX.Ebony.Std.Fixid", 36, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("isChangeVsLimsCollision_", 4224326828, "bool", 40, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("vslimsCollisionID_", 3576884099, "SQEX.Ebony.Std.Fixid", 44, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AIGraphInvokeChangeCharaCollision();
        }
		
    }
}