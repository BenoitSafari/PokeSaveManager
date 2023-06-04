using System.Reflection;

namespace PokeSaveManager.Core.Services

{
    public class UserConfig
    {
        private static readonly string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        private static string GetSolutionName()
        {
            var assemblyPath = Assembly.GetExecutingAssembly().Location;
            _ = Path.GetDirectoryName(assemblyPath);
        }

        public static string GetAppSettings()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            _ = Path.Combine(appDataPath, "PokeSaveManager", "appsettings.json");
            _ = File.Exists(path) ? File.ReadAllText(path) : "{}";
        }
    }
}
