using Microsoft.EntityFrameworkCore;

namespace Cau4_TraSua.Models
{
    public class QLTraSuaDbContext : DbContext
    {
        public DbSet<DanhMucMon> DanhMucMons { get; set; } = null!;
        public DbSet<MonUong> MonUongs { get; set; } = null!;
        public DbSet<HoaDon> HoaDons { get; set; } = null!;
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; } = null!;

        public QLTraSuaDbContext()
        {
        }

        public QLTraSuaDbContext(DbContextOptions<QLTraSuaDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(AppConfig.Instance.DefaultConnection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanhMucMon>(entity =>
            {
                entity.ToTable("DanhMucMon");
                entity.HasKey(e => e.MaDM);
                entity.Property(e => e.TenDM).IsRequired().HasMaxLength(50);
            });

            modelBuilder.Entity<MonUong>(entity =>
            {
                entity.ToTable("MonUong");
                entity.HasKey(e => e.MaMon);
                entity.Property(e => e.TenMon).IsRequired().HasMaxLength(100);
                entity.Property(e => e.GiaBan).HasColumnType("decimal(18, 0)");
                entity.Property(e => e.DangBan).HasDefaultValue(true);

                entity.HasOne(d => d.DanhMucMon)
                    .WithMany(p => p.MonUongs)
                    .HasForeignKey(d => d.MaDM)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.ToTable("HoaDon");
                entity.HasKey(e => e.MaHD);
                entity.Property(e => e.NgayLap).HasColumnType("datetime");
                entity.Property(e => e.TongTien).HasColumnType("decimal(18, 0)");
                entity.Property(e => e.HinhThucTT).IsRequired().HasMaxLength(20);
                entity.Property(e => e.DaThanhToan).HasDefaultValue(true);
            });

            modelBuilder.Entity<ChiTietHoaDon>(entity =>
            {
                entity.ToTable("ChiTietHoaDon");
                entity.HasKey(e => new { e.MaHD, e.MaMon });
                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.HoaDon)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.MaHD)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.MonUong)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.MaMon)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}
