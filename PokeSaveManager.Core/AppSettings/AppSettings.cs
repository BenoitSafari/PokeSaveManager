using PokeSaveManager.Core.Utils;

namespace PokeSaveManager.Core.AppSettings
{
    public class AppSettings
    {
        private readonly string _appSettingsPath;
        public AppSettingsModel Content;

        public AppSettings()
        {
            _appSettingsPath = Path.Combine(Constants.AppDataPath, Constants.AppName, "appsettings.json");
            Content = JsonUtils.Deserialize<AppSettingsModel>(_appSettingsPath);

            Save(Content);
        }

        /// <summary>
        /// Save user's settings to the local appsettings.json file.
        /// </summary>
        public void Save()
        {
            Save(Content);
        }

        /// <summary>
        /// Save user's settings to the local appsettings.json file.
        /// </summary>
        /// <param name="content">AppSettingsModel object</param>
        private void Save(AppSettingsModel content)
        {
            var jsonContent = JsonUtils.Serialize(content);
            FileUtils.SaveFile(_appSettingsPath, jsonContent);
        }
    }
}
