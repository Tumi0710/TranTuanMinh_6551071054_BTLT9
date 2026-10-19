using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Serilog;

namespace Cau2_NhaTro
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

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            Application.ThreadException += (sender, args) =>
            {
                Log.Error(args.Exception, "Lỗi ThreadException chưa bắt.");
                MessageBox.Show("Đã xảy ra lỗi, thông tin đã được ghi lại.", "Thông báo lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                if (args.ExceptionObject is Exception ex)
                {
                    Log.Error(ex, "Lỗi UnhandledException chưa bắt.");
                }
                else
                {
                    Log.Error("Lỗi UnhandledException không xác định: {Obj}", args.ExceptionObject);
                }
                MessageBox.Show("Đã xảy ra lỗi, thông tin đã được ghi lại.", "Thông báo lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            try
            {
                Log.Information("Khởi động ứng dụng Quản lý nhà trọ.");
                Application.Run(new FormKhachThue());
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Lỗi Fatal khi chạy ứng dụng.");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
