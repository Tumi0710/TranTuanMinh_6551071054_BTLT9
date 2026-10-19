using System;
using Microsoft.Extensions.Configuration;

namespace Cau4_TraSua.Models
{
    public class PaymentConfig
    {
        public string TenQuan { get; set; } = "QUÁN TRÀ SỮA COZY";
        public string BankId { get; set; } = "vietcombank";
        public string AccountNo { get; set; } = "1234567890";
        public string AccountName { get; set; } = "NGUYEN VAN QUAN";
        public string Template { get; set; } = "compact2";
    }

    public class AppConfig
    {
        public string DefaultConnection { get; set; } = "Server=.\\SQLEXPRESS;Database=QL_TraSua;User Id=sa;Password=1532006Quang;TrustServerCertificate=True;";
        public PaymentConfig Payment { get; set; } = new PaymentConfig();

        private static AppConfig? _instance;

        public static AppConfig Instance
        {
            get
            {
                if (_instance == null)
                {
                    Load();
                }
                return _instance!;
            }
        }

        public static void Load()
        {
            try
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                var config = builder.Build();
                _instance = new AppConfig();

                string? conn = config.GetConnectionString("DefaultConnection");
                if (!string.IsNullOrWhiteSpace(conn))
                {
                    _instance.DefaultConnection = conn;
                }

                config.GetSection("Payment").Bind(_instance.Payment);
            }
            catch
            {
                _instance = new AppConfig();
            }
        }
    }
}
