namespace PokeSaveManager.Core.Utils
{
    public static class FileUtils
    {
        public static void SaveFile(string path, string content)
        {
            FindOrCreateDirectory(path);
            File.WriteAllText(path, content);
        }
        public static List<byte[]> GetDirectoryFilesFromPatternList(string dir, List<string> searchPatterns)
        {
            var pathList = GetDirectoryFilesNameFromPatternList(dir, searchPatterns);
            var saveFiles = new List<byte[]>();
            foreach (var path in pathList)
            {
                var data = File.ReadAllBytes(path);
                if (data.Any()) saveFiles.Add(data);
            }
            return saveFiles;
        }
        private static void FindOrCreateDirectory(string path)
        {
            var directory = Path.GetDirectoryName(path) ?? throw new NullReferenceException("Directory is null");
            if (!Directory.Exists(directory)) _ = Directory.CreateDirectory(directory);
        }
        private static List<string> GetDirectoryFilesNameFromPatternList(string dir, List<string> searchPatterns)
        {
            var files = new List<string>();
            foreach (var searchPattern in searchPatterns)
                files.AddRange(Directory.GetFiles(dir, searchPattern));
            return files;
        }
    }
}
