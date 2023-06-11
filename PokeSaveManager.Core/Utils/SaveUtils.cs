using PokeSaveManager.Core.SaveGame;

namespace PokeSaveManager.Core.Utils

{
    public class SaveUtils
    {

        public static List<byte[]> GetSaveFilesFromFolder(string path)
        {
            var files = Directory.GetFiles(path);
            var saveFiles = new List<byte[]>();
            foreach (var file in files)
            {
                if (!Constants.AcceptedSaveFormat.Contains(Path.GetExtension(file))) continue;
                if (!FileUtils.LoadFile(file, out var data)) continue;
                saveFiles.Add(data);
            }
            return saveFiles;
        }
        public static void DecryptSaveFile(byte[] data)
        {
            throw new NotImplementedException();
        }

        public static GameVersion ResolveVersion(byte[] data)
        {
            return new GameVersion();
        }
    }
}
