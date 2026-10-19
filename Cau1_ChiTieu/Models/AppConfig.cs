using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Cau1_ChiTieu.Models
{
    public class ConnectionStringsConfig
    {
        public string DefaultConnection { get; set; } = string.Empty;
    }

    public class AppSettings
    {
        public ConnectionStringsConfig ConnectionStrings { get; set; } = new ConnectionStringsConfig();
    }

    public static class ConfigurationHelper
    {
        private static AppSettings? _settings;

        public static AppSettings Settings
        {
            get
            {
                if (_settings == null)
                {
                    LoadConfiguration();
                }
                return _settings!;
            }
        }

        public static void LoadConfiguration()
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var builder = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);

            var config = builder.Build();
            _settings = new AppSettings();
            config.Bind(_settings);

            if (string.IsNullOrWhiteSpace(_settings.ConnectionStrings.DefaultConnection))
            {
                _settings.ConnectionStrings.DefaultConnection = "Server=.\\SQLEXPRESS;Database=QL_ChiTieu;User Id=sa;Password=1532006Quang;TrustServerCertificate=True;";
            }
        }
    }
}
