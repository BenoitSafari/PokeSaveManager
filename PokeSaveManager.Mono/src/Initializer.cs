using System.Collections.Generic;

using PokeSaveManager.Core.SaveGame;

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

            return userSaveFiles;
        }
    }
}
