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

namespace Black.Sequence.Train
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class SequenceActionTrainGetStatus : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinTrain_= new SQEX.Ebony.Framework.Node.GraphVariableInputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outPinCurrentSpeed_= new SQEX.Ebony.Framework.Node.GraphVariableOutputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outPinElapsedTimeHr_= new SQEX.Ebony.Framework.Node.GraphVariableOutputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outPinElapsedTimeMin_= new SQEX.Ebony.Framework.Node.GraphVariableOutputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outPinElapsedTimeSec_= new SQEX.Ebony.Framework.Node.GraphVariableOutputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outPinTraveledDistance_= new SQEX.Ebony.Framework.Node.GraphVariableOutputPin();
		[UnityEngine.SerializeReference] public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outPinNumOfCarts_= new SQEX.Ebony.Framework.Node.GraphVariableOutputPin();
		public int reportType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTrainGetStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Train.SequenceActionTrainGetStatus", 0, Black.Sequence.Train.SequenceActionTrainGetStatus.ObjectType, Construct, properties, 0, 808);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Train.SequenceActionTrainGetStatus", base.GetFieldProperties(), -1484070007, 938564665);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inPinTrain_.pinName_", 1182273685, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inPinTrain_.name_", 4117852432, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("inPinTrain_.connections_", 3929804510, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("inPinTrain_.pinValueType_", 625564181, "Base.String", 248, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPinCurrentSpeed_.pinName_", 2452970106, "Base.String", 272, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPinCurrentSpeed_.name_", 2785305221, "Base.String", 288, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPinCurrentSpeed_.connections_", 2917858205, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 304, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outPinCurrentSpeed_.pinValueType_", 2633876620, "Base.String", 336, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPinElapsedTimeHr_.pinName_", 2861547129, "Base.String", 360, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPinElapsedTimeHr_.name_", 3001635524, "Base.String", 376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPinElapsedTimeHr_.connections_", 2429950330, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 392, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outPinElapsedTimeHr_.pinValueType_", 2888774457, "Base.String", 424, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPinElapsedTimeMin_.pinName_", 3847206981, "Base.String", 448, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPinElapsedTimeMin_.name_", 3957563392, "Base.String", 464, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPinElapsedTimeMin_.connections_", 3649662382, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 480, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outPinElapsedTimeMin_.pinValueType_", 1761272645, "Base.String", 512, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPinElapsedTimeSec_.pinName_", 1808839020, "Base.String", 536, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPinElapsedTimeSec_.name_", 617318359, "Base.String", 552, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPinElapsedTimeSec_.connections_", 113913271, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 568, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outPinElapsedTimeSec_.pinValueType_", 1209343706, "Base.String", 600, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPinTraveledDistance_.pinName_", 4136983800, "Base.String", 624, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPinTraveledDistance_.name_", 4017897555, "Base.String", 640, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPinTraveledDistance_.connections_", 3981645627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 656, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outPinTraveledDistance_.pinValueType_", 525660550, "Base.String", 688, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPinNumOfCarts_.pinName_", 3313776806, "Base.String", 712, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPinNumOfCarts_.name_", 691050481, "Base.String", 728, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPinNumOfCarts_.connections_", 2511631729, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 744, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outPinNumOfCarts_.pinValueType_", 2194538536, "Base.String", 776, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("inPinTrain_", 115407762, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPinCurrentSpeed_", 162269743, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 264, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPinElapsedTimeHr_", 840990206, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 352, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPinElapsedTimeMin_", 2580691938, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 440, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPinElapsedTimeSec_", 2694783053, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 528, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPinTraveledDistance_", 2707850401, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 616, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPinNumOfCarts_", 1469261731, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 704, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("reportType_", 1413702884, "Black.Sequence.Train.SequenceActionTrainGetStatus.StatusType", 792, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SequenceActionTrainGetStatus();
        }
		
    }
}