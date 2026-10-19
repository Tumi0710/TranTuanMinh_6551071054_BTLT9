using Microsoft.EntityFrameworkCore;

namespace Cau3_DaNgoai.Models
{
    public class QLDaNgoaiDbContext : DbContext
    {
        public DbSet<ChuyenDi> ChuyenDis { get; set; } = null!;

        public static string ConnectionString = "Server=.\\SQLEXPRESS;Database=QL_DaNgoai;User Id=sa;Password=1532006Quang;TrustServerCertificate=True;";

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
