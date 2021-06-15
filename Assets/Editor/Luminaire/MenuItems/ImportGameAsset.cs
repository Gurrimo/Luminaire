namespace Luminaire.MenuItems
{
    using GfxbinTool;
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using UnityEditor;
    using UnityEngine;

    public static class ImportGmdl
    {
        private static readonly string[] InputTypes = { "Game Model", "gmdl.gfxbin",
                                                        "Game Material", "gmtl.gfxbin",
                                                        "GPU Binary", "gpubin",
                                                        "Bonamik", "bnm" };

        [MenuItem("Luminaire/Import Game Asset")]
        private static void OnImportGmdl()
        {
            if (!Utilities.IsGamePathValid()) return;

            var inputPath = EditorUtility.OpenFilePanelWithFilters("Import Game Asset", LuminaireSettings.Instance.GamePath, InputTypes);
            if (string.IsNullOrEmpty(inputPath))
            {
                return;
            }
            // TODO: Fix convert function in GfxbinTool to accept (or have a version that accepts) just one string as an argument.
            // Then remove this quick fix.
            string[] tempArr = { inputPath };
            GfxbinTool.Program.convert(tempArr);
        }
    }
}
