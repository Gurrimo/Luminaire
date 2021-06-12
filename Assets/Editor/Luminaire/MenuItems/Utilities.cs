namespace Luminaire.MenuItems
{
    using UnityEditor;
    using System.IO;

    public static class Utilities
    {
        // Ensures game path is set and the game executable is accessible
        // from the directory when set.
        public static bool IsGamePathValid()
        {
            var settings = LuminaireSettings.Instance;
            var gamePath = settings.GamePath;
            if (string.IsNullOrEmpty(gamePath))
            {
                EditorUtility.DisplayDialog("Game path not set", "Game path must be set before assets can be imported.", "OK");
                return false;
            }

            if (!File.Exists(gamePath))
            {
                EditorUtility.DisplayDialog("Invalid game path", "Invalid game path. Make sure the game path points to a valid game executable.", "OK");
                return false;
            }
            return true;
        }
    }
}
