using System;
using System.IO;
using System.Windows.Forms;
using Serilog;

namespace Cau4_TraSua
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            string logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.File(Path.Combine(logDirectory, "log-.txt"),
                    rollingInterval: RollingInterval.Day,
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();

            ApplicationConfiguration.Initialize();

            try
            {
                Log.Information("App start.");
                Application.Run(new FormBanHang());
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Fatal error.");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
