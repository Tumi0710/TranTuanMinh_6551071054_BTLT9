using System;
using System.IO;
using System.Text.Json;
using Serilog;

namespace Cau3_DaNgoai.Models
{
    public class UserSettings
    {
        public string Language { get; set; } = "vi-VN";

        private static string GetConfigPath()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appFolder = Path.Combine(appData, "KeHoachDaNgoai");
            if (!Directory.Exists(appFolder))
            {
                Directory.CreateDirectory(appFolder);
            }
            return Path.Combine(appFolder, "usersettings.json");
        }

        public static UserSettings Load()
        {
            try
            {
                string path = GetConfigPath();
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    var settings = JsonSerializer.Deserialize<UserSettings>(json);
                    if (settings != null) return settings;
                }
            }
            catch (Exception ex)
            {
                Log.Warning(ex, "Failed to load usersettings.json.");
            }
            return new UserSettings();
        }

        public void Save()
        {
            try
            {
                string path = GetConfigPath();
                string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                Log.Warning(ex, "Failed to save usersettings.json.");
            }
        }
    }
}
