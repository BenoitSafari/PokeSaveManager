namespace PokeSaveManager.Core

{
    public static class Constants
    {
        #region App infos and paths
        public const string AppName = "PokeSaveManager";
        public const string AppVersion = "0.0.1";
        public const string ContentPath = "content";
        public static readonly string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        #endregion

        #region Save files extensions
        public const string SAV = ".sav";
        public const string DSV = ".dsv";
        public const string SRM = ".srm";
        public static readonly List<string> AcceptedSaveFormat = new() { SAV, DSV, SRM };
        #endregion

        #region Save files sizes
        public const int Gen3Size = 0x20000;
        public const int Gen3HalfSize = 0x10000;
        #endregion
    }
}
