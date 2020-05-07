using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Render.PostProcess
{
    public partial class VWColorFilterTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool propCAT_;
		public bool propsRGBGamma_;
		public bool propDither_;
		public float propSceneEv_;
		public float propUserEv_;
		public bool propEnabledWhite_;
		public float propGM_;
		public float propBY_;
		public bool propEnabledToneCurve_;
		public float propHighRange_;
		public float propContrast_;
		public float propZeroSlope_;
		public float propDark_;
		public bool propEnabledHue_;
		public float proprotM_;
		public float proprotY_;
		public float proprotG_;
		public float proprotB_;
		public bool propEnabledSaturationALL_;
		public bool propEnabledSaturation_;
		public float propsAll_;
		public float propsM_;
		public float propsY_;
		public float propsG_;
		public float propsB_;
		public bool propEnabledSaturationClamp_;
		public float propscAll_;
		public float propscM_;
		public float propscY_;
		public float propscG_;
		public float propscB_;
		public bool propEnabledSaturationByKido_;
		public float props0_;
		public float props1_;
		public float props2_;
		public float props3_;
		public float props4_;
		public float propsM0_;
		public float propsM1_;
		public float propsM2_;
		public float propsM3_;
		public float propsM4_;
		public float propsY0_;
		public float propsY1_;
		public float propsY2_;
		public float propsY3_;
		public float propsY4_;
		public float propsG0_;
		public float propsG1_;
		public float propsG2_;
		public float propsG3_;
		public float propsG4_;
		public float propsB0_;
		public float propsB1_;
		public float propsB2_;
		public float propsB3_;
		public float propsB4_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VWColorFilterTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Render.PostProcess.VWColorFilterTrackItem", 0, Black.System.TimeLine.TrackItem.Render.PostProcess.VWColorFilterTrackItem.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Render.PostProcess.VWColorFilterTrackItem", base.GetFieldProperties(), 731056422, -1217140648);
            
			fieldProperties.AddProperty(new Property("propCAT_", 1436489273, "bool", 88, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsRGBGamma_", 1923425970, "bool", 89, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propDither_", 1027854365, "bool", 90, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propSceneEv_", 1878793404, "float", 92, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propUserEv_", 1686205217, "float", 96, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propEnabledWhite_", 3849867743, "bool", 100, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propGM_", 816887917, "float", 104, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propBY_", 254297694, "float", 108, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propEnabledToneCurve_", 3969473297, "bool", 112, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propHighRange_", 2183379730, "float", 116, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propContrast_", 966800351, "float", 120, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propZeroSlope_", 2500299462, "float", 124, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propDark_", 3326680961, "float", 128, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propEnabledHue_", 1784097278, "bool", 132, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("proprotM_", 308614709, "float", 136, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("proprotY_", 1380410849, "float", 140, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("proprotG_", 307628971, "float", 144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("proprotB_", 1382235230, "float", 148, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propEnabledSaturationALL_", 488765409, "bool", 152, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propEnabledSaturation_", 368446382, "bool", 153, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsAll_", 3220688981, "float", 156, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsM_", 3503444881, "float", 160, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsY_", 3500193477, "float", 164, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsG_", 281259463, "float", 168, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsB_", 280715010, "float", 172, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propEnabledSaturationClamp_", 3930747385, "bool", 176, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propscAll_", 2692141342, "float", 180, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propscM_", 621820378, "float", 184, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propscY_", 619848902, "float", 188, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propscG_", 620143092, "float", 192, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propscB_", 3841887225, "float", 196, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propEnabledSaturationByKido_", 2794273438, "bool", 200, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("props0_", 293426436, "float", 204, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("props1_", 293279341, "float", 208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("props2_", 3514920306, "float", 212, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("props3_", 3514773211, "float", 216, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("props4_", 294014816, "float", 220, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsM0_", 3367589641, "float", 224, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsM1_", 3367736736, "float", 228, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsM2_", 2294116215, "float", 232, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsM3_", 3368030926, "float", 236, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsM4_", 3366898093, "float", 240, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsY0_", 1186096613, "float", 244, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsY1_", 112579260, "float", 248, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsY2_", 112726355, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsY3_", 1186641066, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsY4_", 113020545, "float", 260, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsG0_", 4211141931, "float", 264, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsG1_", 990089346, "float", 268, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsG2_", 989648061, "float", 272, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsG3_", 4210994836, "float", 276, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsG4_", 990633799, "float", 280, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsB0_", 3024981260, "float", 284, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsB1_", 3024834165, "float", 288, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsB2_", 3025275450, "float", 292, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsB3_", 4098895971, "float", 296, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsB4_", 4099337256, "float", 300, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}