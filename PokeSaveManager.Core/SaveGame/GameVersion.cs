namespace PokeSaveManager.Core.SaveGame
{
    public class GameVersion
    {
        public Version? Version { get; set; }
        public Gen? Gen { get; set; }

    }

    public enum Version
    {
        Sapphire = 1,
        Ruby,
        Emerald,
        FireRed,
        LeafGreen,
    }

    public enum Gen
    {
        Gen1 = 1,
        Gen2 = 2,
        Gen3 = 3,
        Gen4 = 4,
        Gen5 = 5,
        Gen6 = 6,
        Gen7 = 7,
        Gen8 = 8,
    }
}
