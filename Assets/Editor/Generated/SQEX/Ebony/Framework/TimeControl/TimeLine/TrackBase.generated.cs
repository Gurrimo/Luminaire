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

namespace SQEX.Ebony.Framework.TimeControl.TimeLine
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class TrackBase : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		[UnityEngine.SerializeReference] public List<SQEX.Ebony.Framework.TimeControl.TimeLine.Track> childTrackList_= new List<SQEX.Ebony.Framework.TimeControl.TimeLine.Track>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TrackBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.TimeControl.TimeLine.TrackBase", 0, SQEX.Ebony.Framework.TimeControl.TimeLine.TrackBase.ObjectType, Construct, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.TimeControl.TimeLine.TrackBase", base.GetFieldProperties(), -1829795006, -1381977434);
            
			
			
			fieldProperties.AddProperty(new Property("childTrackList_", 2693454425, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.TimeControl.TimeLine.Track* >", 8, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new TrackBase();
        }
		
    }
}