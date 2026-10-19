using System;
using Microsoft.EntityFrameworkCore;

namespace Cau1_ChiTieu.Models
{
    public class QLChiTieuDbContext : DbContext
    {
        public DbSet<ChiTieu> ChiTieus { get; set; } = null!;

        public QLChiTieuDbContext()
        {
        }

        public QLChiTieuDbContext(DbContextOptions<QLChiTieuDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationHelper.Settings.ConnectionStrings.DefaultConnection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTieu>(entity =>
            {
                entity.ToTable("ChiTieu");
                entity.HasKey(e => e.MaCT);
                entity.Property(e => e.NgayChi).HasColumnType("date");
                entity.Property(e => e.NoiDung).IsRequired().HasMaxLength(100);
                entity.Property(e => e.LoaiChi).IsRequired().HasMaxLength(30);
                entity.Property(e => e.SoTien).HasColumnType("decimal(18, 0)");
                entity.Property(e => e.GhiChu).HasMaxLength(200);
            });
        }
    }
}
