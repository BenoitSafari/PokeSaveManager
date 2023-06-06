namespace PokeSaveManager.Core.AppSettings
{
    public interface IAppSettings
    {
        AppSettingsModel GetAppSettings();
        void Save(AppSettingsModel appSettings);
    }
}
