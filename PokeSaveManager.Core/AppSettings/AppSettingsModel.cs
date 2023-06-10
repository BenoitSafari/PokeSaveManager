namespace PokeSaveManager.Core.AppSettings

{
    public class AppSettingsModel
    {
        public AppSettingsModelPaths Paths { get; set; } = new AppSettingsModelPaths();
        public AppSettingsModelGraphics Graphics { get; set; } = new AppSettingsModelGraphics();
    }
    public class AppSettingsModelPaths
    {
        public string? RetroArchPath { get; set; }
        public string? NsNand { get; set; }
    }

    public class AppSettingsModelGraphics
    {
        public int Width { get; set; } = 1280;
        public int Height { get; set; } = 720;
        public bool Fullscreen { get; set; } = true;
        public bool MouseVisibility { get; set; }
    }
}
