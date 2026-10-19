using Microsoft.EntityFrameworkCore;

namespace Cau2_NhaTro.Models
{
    public class QLNhaTroDbContext : DbContext
    {
        public DbSet<PhongTro> PhongTros { get; set; } = null!;
        public DbSet<KhachThue> KhachThues { get; set; } = null!;

        public static string ConnectionString = "Server=.\\SQLEXPRESS;Database=QL_NhaTro;User Id=sa;Password=1532006Quang;TrustServerCertificate=True;";

        public QLNhaTroDbContext()
        {
        }

        public QLNhaTroDbContext(DbContextOptions<QLNhaTroDbContext> options)
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
            modelBuilder.Entity<PhongTro>(entity =>
            {
                entity.ToTable("PhongTro");
                entity.HasKey(e => e.MaPhong);
                entity.Property(e => e.TenPhong).IsRequired().HasMaxLength(20);
                entity.Property(e => e.GiaThue).HasColumnType("decimal(18, 0)");
                entity.Property(e => e.TinhTrang).IsRequired().HasMaxLength(20).HasDefaultValue("Trống");
            });

            modelBuilder.Entity<KhachThue>(entity =>
            {
                entity.ToTable("KhachThue");
                entity.HasKey(e => e.MaKhach);
                entity.Property(e => e.HoTen).IsRequired().HasMaxLength(100);
                entity.Property(e => e.GioiTinh).IsRequired().HasMaxLength(5);
                entity.Property(e => e.NgaySinh).HasColumnType("date");
                entity.Property(e => e.SoDienThoai).IsRequired().HasMaxLength(15);
                entity.Property(e => e.TenTinh).IsRequired().HasMaxLength(100);
                entity.Property(e => e.TenPhuongXa).IsRequired().HasMaxLength(100);

                entity.HasOne(d => d.PhongTro)
                    .WithMany(p => p.KhachThues)
                    .HasForeignKey(d => d.MaPhong)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
