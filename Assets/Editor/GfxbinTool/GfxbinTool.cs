using GmtlJsonConverter;
using SQEX.Ebony.Std;
using SQEX.Luminous.Bonamik;
using SQEX.Luminous.GraphicsLoad;
using System;
using System.Collections.Generic;
using System.IO;
 
namespace GfxbinTool
{
    // Added public keyword to try and get this class to show up in Unity
    public static class Program
    {
        public const string gmdlExtension = "gmdl.gfxbin";
        public const string gmtlExtension = "gmtl.gfxbin";
        public const string gpubinExtension = "gpubin";
        public const string bnmExtension = "bnm";
        public const string fbxExtension = "fbx";

        public static void convert(string[] args)
        {
            foreach(var arg in args)
            {
                if (!File.Exists(arg))
                {
                    continue;
                }

                if (arg.Contains(gmtlExtension))
                {
                    ConvertMaterial(arg);
                    continue;
                }

                if (arg.Contains(bnmExtension))
                {
                    ConvertBonamik(arg);
                    continue;
                }

                if (!arg.Contains(gmdlExtension))
                {
                    continue;
                }

                // This code seems to assume that a *.gfxbin file has been
                // passed to the program. What does this code do for a .bnm?
                var gfxbin = arg;
                var gpubin = arg.Replace(gmdlExtension, gpubinExtension);
                if (!File.Exists(gpubin))
                {
                    Console.WriteLine("Could not find " + gpubin);
                    return;
                }

                ConvertFile(gfxbin, gpubin);
            }
        }

        // This function takes a gmtl file name as input and converts to
        // contents of that file to json format. It then writes that json
        // to a file in the same directory as the input file. The output
        // file will have the same name as the input file but with the 
        // .json extension.
        private static void ConvertMaterial(string gfxbin)
        {
            DefaultPrintFunction.SetDefaultPrintFunction(Console.WriteLine);
            // Reads contents of gfxbin file (which is binary) into a
            // bytearray. This implies that readData is a byte[].
            var readData = File.ReadAllBytes(gfxbin);

            var unpackContext = new LmGfxBinUnpackContext();
            var msgPck = new LmMsgPck(readData, unpackContext);

            // Loads the unpacked message data into a MaterialGmtl.
            var gmtlLoader = new LmGfxBinMaterialAssetLoader();
            var gmtl = gmtlLoader.Initialize(unpackContext, msgPck, null);

            // Make a string for the file path of the input file, but with
            // a .json file extension. The output file should be stored in
            // the same directory as the input file.
            var jsonPath = gfxbin.Replace(gmtlExtension, "json");
            JsonConvert.Convert(gmtl, jsonPath);
        }

        // Seems to be incomplete. Loads input .bnm file data into a bonamik
        // variable but doesn't do anything with that data after.
        private static void ConvertBonamik(string bnm)
        {
            // Reads contents of gfxbin file (which is binary) into a
            // bytearray. This implies that readData is a byte[].
            DefaultPrintFunction.SetDefaultPrintFunction(Console.WriteLine);
            var readData = File.ReadAllBytes(bnm);

            // bonamik.LoadBinaryData() contains a few TODO annotations. It
            // looks like Sai might have been using this to inspect the
            // contents of bonamik files/data structures.
            var bonamik = new BonamikBinaryResource();
            bonamik.LoadBinaryData(readData, bnm, false);

            Console.ReadLine();
        }

        // Converts .json file from parsing arguments into...
        private static void ConvertFile(string gfxbin, string gpubin)
        {
            DefaultPrintFunction.SetDefaultPrintFunction(Console.WriteLine);

            var readData = File.ReadAllBytes(gfxbin);
            var gpubinReadData = File.ReadAllBytes(gpubin);

            // TODO don't hardcode
            var dependencies = new Dictionary<string, byte[]>
            {
                { /* "data://character/nh/nh00/model_010/nh00_010.gpubin"*/ gpubin, gpubinReadData }
            };

            var unpackContext = new LmGfxBinUnpackContext
            {
                // Shorthand initialization for auto-implemented properties
                GpuBuffer = gpubinReadData // TODO don't hardcode
            };

            var msgPck = new LmMsgPck(readData, unpackContext);

            var gmtlLoader = new LmGfxBinMaterialAssetLoader();
            var gmdlLoader = new LmGfxBinAssetLoader();
            // After tracing this dependencies variable as its passed through 
            // various functions, it seems that the dictionary isn't actually 
            // used anywhere. The reference in the deepest level of function 
            // calls the place where this variable is used is commented out.
            gmdlLoader.BuildDependencyTable(unpackContext, msgPck, dependencies);
            var modelResourceNode = LmGfxBinAssetLoader.Convert(msgPck);

            var fbx = gpubin.Replace(gpubinExtension, fbxExtension);
            // TODO: Replace with calls to Unity API for conversion
            //FbxConvertNative.Convert(modelResourceNode, gfxbin, fbx);
            GmdlUnityAssetConverter.Convert(modelResourceNode, gfxbin,"");
        }
    }
}
