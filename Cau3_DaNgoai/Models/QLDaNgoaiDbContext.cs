using System;
using System.IO;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace Cau3_DaNgoai.Models
{
    public class QLDaNgoaiDbContext : DbContext
    {
        public DbSet<ChuyenDi> ChuyenDis { get; set; } = null!;

        public static string ConnectionString { get; set; } = LoadConnectionString();

        private static string LoadConnectionString()
        {
            try
            {
                string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
                if (File.Exists(configPath))
                {
                    string json = File.ReadAllText(configPath);
                    using var doc = JsonDocument.Parse(json);
                    if (doc.RootElement.TryGetProperty("ConnectionStrings", out var csSection) &&
                        csSection.TryGetProperty("DefaultConnection", out var csElem))
                    {
                        var str = csElem.GetString();
                        if (!string.IsNullOrWhiteSpace(str))
                        {
                            return str;
                        }
                    }
                }
            }
            catch
            {
                // Fallback nếu không đọc được file cấu hình
            }

            return "Server=localhost;Database=QL_DaNgoai;Trusted_Connection=True;TrustServerCertificate=True;";
        }

        public QLDaNgoaiDbContext()
        {
        }

        public QLDaNgoaiDbContext(DbContextOptions<QLDaNgoaiDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChuyenDi>(entity =>
            {
                entity.ToTable("ChuyenDi");
                entity.HasKey(e => e.MaChuyen);
                entity.Property(e => e.TenChuyen).IsRequired().HasMaxLength(100);
                entity.Property(e => e.DiaDiem).IsRequired().HasMaxLength(100);
                entity.Property(e => e.NgayDi).HasColumnType("date");
                entity.Property(e => e.NganSach).HasColumnType("decimal(18, 0)");
                entity.Property(e => e.PhuongTien).IsRequired().HasMaxLength(30);
                entity.Property(e => e.GhiChu).HasMaxLength(200);
            });
        }
    }
}
