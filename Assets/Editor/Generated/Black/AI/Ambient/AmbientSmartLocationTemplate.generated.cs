using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Ambient
{
    public partial class AmbientSmartLocationTemplate : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint archeType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AmbientSmartLocationTemplate();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Ambient.AmbientSmartLocationTemplate", 0, Black.AI.Ambient.AmbientSmartLocationTemplate.ObjectType, Construct, properties, 0, 216);
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

            fieldProperties = new PropertyContainer("Black.AI.Ambient.AmbientSmartLocationTemplate", base.GetFieldProperties(), 1528184899, 527442079);
            
			fieldProperties.AddIndirectlyProperty(new Property("minCoolDown_", 4002648055, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxCoolDown_", 1686966705, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("triggerCooldownOnStartup_", 2352980045, "bool", 72, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("characterCapacity_", 2138905361, "int", 76, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("interactionGroups_", 125379156, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem* >", 80, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddIndirectlyProperty(new Property("useDefaultActivator_", 572401405, "bool", 96, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("defaultActivatorRadius_", 3687545052, "float", 100, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("defaultActivationPeriod_", 3916605936, "int", 104, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("npcMinCoolDown_", 1681135214, "int", 108, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("npcMaxCoolDown_", 2873526840, "int", 112, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("scriptPriority_", 699961715, "Black.AI.Ambient.AmbientSmartLocationBase.ExecutionPriority", 116, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useExternalActivator_", 4201786171, "bool", 120, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("externalActivatorRadius_", 2743668528, "float", 124, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("externalActivationPeriod_", 2681151756, "int", 128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("usePlayerActivator_", 2305886973, "bool", 132, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("playerActivationPeriod_", 1722461818, "int", 136, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useSingleActionActivator_", 3840016234, "bool", 140, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("singleActionActivatorRadius_", 580968345, "float", 144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("singleActionActivationPeriod_", 210236943, "int", 148, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("singleActionId_", 215196187, "SQEX.Ebony.Std.Fixid", 152, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("singleActionParamId_", 3834026558, "SQEX.Ebony.Std.Fixid", 156, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("singleActionParam_", 3353006133, "int", 160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("singleActionProbability_", 1181090443, "float", 164, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("singleActionMinCoolDown_", 4279688285, "int", 168, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("singleActionMaxCoolDown_", 2593857067, "int", 172, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("tags_", 1058374253, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem* >", 176, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			
			
			fieldProperties.AddProperty(new Property("archeType_", 2117969097, "SQEX.Ebony.Std.Fixid", 208, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AmbientSmartLocationTemplate();
        }
		
    }
}