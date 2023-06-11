using System.Collections.Generic;

using PokeSaveManager.Core;
using PokeSaveManager.Core.SaveGame;
using PokeSaveManager.Core.Utils;
namespace PokeSaveManager.Mono.src
{

    public static class Initializer
    {
        /// <summary>
        /// Load and deserialize all user saves from the provided directories
        /// </summary>
        /// <param name="directories">Paths to the directories that contains user's saves</param>
        /// <returns>Deserialized save files</returns>
        public static List<SaveFile> LoadUserSaves(List<string> directories)
        {
            List<SaveFile> userSaveFiles = new();
            foreach (var dir in directories)
            {
                var files = FileUtils.LoadFilesFromFolder(dir, Constants.AcceptedSaveFormat);
                files.ForEach(file => userSaveFiles.Add(new SaveFile(file)));
            }
            return userSaveFiles;
        }
    }
}
