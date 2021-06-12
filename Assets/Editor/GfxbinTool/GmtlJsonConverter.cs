using SQEX.Luminous.Renderer;
using System.IO;

namespace GmtlJsonConverter
{
    public static class JsonConvert
    {
        public static void Convert(MaterialGmtl gmtl, string outputPath)
        {
            var output = Newtonsoft.Json.JsonConvert.SerializeObject(gmtl, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(outputPath, output);
        }
    }
}
