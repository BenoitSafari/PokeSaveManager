using PokeSaveManager.Core.Services;

namespace PokeSaveManager.Core.AppSettings
{
    public class AppSettings : IAppSettings
    {
        private readonly string _appSettingsPath;

        public AppSettings()
        {
            _appSettingsPath = Path.Combine(Constants.AppDataPath, Constants.AppName, "appsettings.json");
        }

        public AppSettingsModel GetAppSettings()
        {
            var appSettings = JsonService.Deserialize<AppSettingsModel>(_appSettingsPath);
            Save(appSettings);

            return appSettings;
        }

        public void Save(AppSettingsModel appSettings)
        {
            var jsonContent = JsonService.Serialize(appSettings);
            FileService.SaveFile(_appSettingsPath, jsonContent);
        }
    }
}
