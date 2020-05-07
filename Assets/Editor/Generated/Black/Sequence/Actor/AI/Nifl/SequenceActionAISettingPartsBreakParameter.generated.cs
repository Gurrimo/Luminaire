using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Nifl
{
    public partial class SequenceActionAISettingPartsBreakParameter : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public uint settingPartsID_;
		public uint breakJoint_;
		public bool isRagdollReverse;
		public uint linkModeLabelFixid_;
		public uint linkModeAnimBBFixid_;
		public float lifeLimit_;
		public float damageLimit_;
		public bool isInCamera_;
		public float cameraDistance_;
		public float probabilityLow_;
		public float probabilityMiddle_;
		public float probabilityHigh_;
		public bool isDiscardWeapon_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> exclusionPartsIDList_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> linkBreakingPartsIDList_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> hitCollisions_;
		public uint visiblePartsId_;
		public uint pushCollision_;
		public float timeToEraseParts_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAISettingPartsBreakParameter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Nifl.SequenceActionAISettingPartsBreakParameter", 0, Black.Sequence.Actor.AI.Nifl.SequenceActionAISettingPartsBreakParameter.ObjectType, null, properties, 0, 584);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Nifl.SequenceActionAISettingPartsBreakParameter", base.GetFieldProperties(), -1232637512, -244202149);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 280, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actor_", 3434601855, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 376, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("settingPartsID_", 2201775271, "SQEX.Ebony.Std.Fixid", 464, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("breakJoint_", 3071746225, "SQEX.Ebony.Std.Fixid", 468, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("isRagdollReverse", 514484574, "bool", 472, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("linkModeLabelFixid_", 1750706111, "SQEX.Ebony.Std.Fixid", 476, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("linkModeAnimBBFixid_", 614532520, "SQEX.Ebony.Std.Fixid", 480, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("lifeLimit_", 981059311, "float", 484, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("damageLimit_", 210993908, "float", 488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isInCamera_", 542414502, "bool", 492, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("cameraDistance_", 1197223102, "float", 496, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("probabilityLow_", 396864931, "float", 500, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("probabilityMiddle_", 20318818, "float", 504, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("probabilityHigh_", 4111554973, "float", 508, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isDiscardWeapon_", 1043692150, "bool", 512, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("exclusionPartsIDList_", 2964025571, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem* >", 520, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("linkBreakingPartsIDList_", 4095893356, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem* >", 536, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("hitCollisions_", 3984557052, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem* >", 552, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("visiblePartsId_", 805395809, "SQEX.Ebony.Std.Fixid", 568, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("pushCollision_", 1953016040, "SQEX.Ebony.Std.Fixid", 572, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeToEraseParts_", 3286022246, "float", 576, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}