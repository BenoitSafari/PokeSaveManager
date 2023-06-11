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
        public static bool LoadFile(string path, out byte[] data)
        {
            data = File.Exists(path) ? File.ReadAllBytes(path) : Array.Empty<byte>();
            return data.Length > 0;
        }
        public static List<byte[]> LoadFilesFromFolder(string dir, List<string> searchPatterns)
        {
            var files = Directory.GetFiles(dir);
            var saveFiles = new List<byte[]>();
            foreach (var file in files)
            {
                if (!searchPatterns.Contains(Path.GetExtension(file))) continue;
                if (LoadFile(file, out var data)) saveFiles.Add(data);
            }
            return saveFiles;
        }
    }
}
