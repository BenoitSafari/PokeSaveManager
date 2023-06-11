namespace PokeSaveManager.Core.SaveGame
{
    public class SaveFile
    {
        public GameVersion Version { get; set; }
        public byte[] Data { get; set; }
        public SaveFile(byte[] data)
        {

        }
    }
}
