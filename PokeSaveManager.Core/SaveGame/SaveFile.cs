namespace PokeSaveManager.Core.SaveGame
{
    public class SaveFile
    {
        public GameVersion Version { get; set; }
        public byte[] Data { get; set; }
        private SaveFile(byte[] data)
        {

        }

        public static SaveFile CreateFromData(byte[] data)
        {
            return new(data);
        }
    }
}
