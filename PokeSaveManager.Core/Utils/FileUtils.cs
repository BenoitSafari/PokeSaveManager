namespace PokeSaveManager.Core.Utils
{
    public static class FileUtils
    {
        private static void FindOrCreateDirectory(string path)
        {
            var directory = Path.GetDirectoryName(path) ?? throw new NullReferenceException("Directory is null");
            if (!Directory.Exists(directory)) _ = Directory.CreateDirectory(directory);
        }
        public static void SaveFile(string path, string content)
        {
            FindOrCreateDirectory(path);
            File.WriteAllText(path, content);
        }
    }
}
