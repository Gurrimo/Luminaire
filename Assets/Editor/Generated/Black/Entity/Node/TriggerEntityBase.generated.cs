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

namespace Black.Entity.Node
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class TriggerEntityBase : Black.Entity.Node.PointNodeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint eventId_;
		public string eventString_= string.Empty;
		public int triggerType_;
		public int touchTarget_;
		public int characterSelectID_;
		[UnityEngine.SerializeReference] public List<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> CharaParamIDList= new List<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem>();
		public int touchStatus_;
		public int touchStatus2_;
		public int touchStatus3_;
		public int touchStatus4_;
		public UnityEngine.Vector4 scaling_;
		public float radius_;
		public float height_;
		public float depth_;
		public float width_;
		public int count_;
		public bool enableTrigger_;
		public UnityEngine.Color color_;
		public bool checkInSameScene_;
		public bool scaleTriggerWithParent_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TriggerEntityBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.TriggerEntityBase", 0, Black.Entity.Node.TriggerEntityBase.ObjectType, Construct, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.TriggerEntityBase", base.GetFieldProperties(), 1250432021, -1289929382);
            
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entitySearchLabelId_", 3840219358, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("jointId_", 3429568351, "SQEX.Ebony.Std.Fixid", 256, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("eventId_", 548562519, "SQEX.Ebony.Std.Fixid", 288, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("eventString_", 3649127407, "Ebony.Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerType_", 1915532364, "Black.Actor.Node.ActorNodeTriggerBase.TriggerType", 312, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("touchTarget_", 2447709882, "Black.Actor.Node.ActorNodeTrigger.TouchTarget", 316, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("characterSelectID_", 4004084206, "Black.Entity.Node.TriggerEntityBase.CharacterSelectID", 320, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("CharaParamIDList", 2063779448, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem* >", 328, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("touchStatus_", 1525396607, "Black.Actor.Node.ActorNodeTriggerBase.TouchStatus", 344, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("touchStatus2_", 2553285, "Black.Actor.Node.ActorNodeTriggerBase.TouchStatus", 348, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("touchStatus3_", 1076467996, "Black.Actor.Node.ActorNodeTriggerBase.TouchStatus", 352, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("touchStatus4_", 3539023, "Black.Actor.Node.ActorNodeTriggerBase.TouchStatus", 356, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("scaling_", 3325430311, "Luminous.Math.VectorA", 368, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("radius_", 2286360452, "float", 384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("height_", 2527956647, "float", 388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("depth_", 1210636015, "float", 392, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("width_", 2754776768, "float", 396, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("count_", 2113926193, "int", 400, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableTrigger_", 1936258923, "bool", 404, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("color_", 3572781317, "Luminous.RenderInterface.Color", 416, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkInSameScene_", 2455832991, "bool", 432, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("scaleTriggerWithParent_", 586178736, "bool", 433, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new TriggerEntityBase();
        }
		
    }
}