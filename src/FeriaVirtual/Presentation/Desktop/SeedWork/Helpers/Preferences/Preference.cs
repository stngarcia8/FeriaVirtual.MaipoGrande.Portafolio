using Newtonsoft.Json;
using System;
using System.IO;

namespace FeriaVirtual.App.Desktop.SeedWork.Helpers.Preferences
{
    public class Preference
    {
        private AppSettings _settings;
        private readonly string _settingPath;
        private readonly string _settingFileName;
        private readonly string _settingRootPath;


        private Preference()
        {
            _settingRootPath = Environment.CurrentDirectory;
            _settingFileName = "appsettings.json";
            _settingPath = Path.Combine(_settingRootPath, _settingFileName);
        }

        public static Preference Build()
            => new Preference();


        private void DefineDefaultSettings()
            => _settings = new AppSettings {
                RowsPerPage = 10,
                DarkMode = 1,
                ColorSchema = 3,
                ColorSchemaName = "Gris"
            };


        public void WriteSettings()
        {
            try {
                GetSettings();
                string jsonSettings = JsonConvert.SerializeObject(_settings);
                File.WriteAllText(_settingPath, jsonSettings);

            } catch {
                DefineDefaultSettings();
            }
        }


        private void GetSettings()
            => _settings = new AppSettings {
                RowsPerPage = PreferenceData.RowsPerPage,
                DarkMode = PreferenceData.DarkMode,
                ColorSchema = PreferenceData.ColorSchema,
                ColorSchemaName = PreferenceData.ColorSchemaName
            };


        public void ReadSettings()
        {
            try {
                using(StreamReader jsonReader = File.OpenText(_settingPath)) {
                    var jsonSettings = jsonReader.ReadToEnd();
                    _settings = JsonConvert.DeserializeObject<AppSettings>(jsonSettings);
                }
                AsignSettings();

            } catch {
                DefineDefaultSettings();
            }
        }


        private void AsignSettings()
        {
            PreferenceData.RowsPerPage = _settings.RowsPerPage;
            PreferenceData.DarkMode = _settings.DarkMode;
            PreferenceData.ColorSchema = _settings.ColorSchema;
            PreferenceData.ColorSchemaName = _settings.ColorSchemaName;
        }


    }
}
