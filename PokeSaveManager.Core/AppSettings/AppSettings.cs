namespace PokeSaveManager.Core.AppSettings

{
    public class AppSettings
    {
        public AppSettingsPaths Paths { get; set; } = new AppSettingsPaths();
        public AppSettingsGraphics Graphics { get; set; } = new AppSettingsGraphics();
    }
    public class AppSettingsPaths
    {
        public string? RetroArchPath { get; set; }
        public string? NsNand { get; set; }
    }

    public class AppSettingsGraphics
    {
        public int Width { get; set; } = 1280;
        public int Height { get; set; } = 720;
        public bool Fullscreen { get; set; } = true;
        public bool MouseVisibility { get; set; }
    }
}
