using KoiPool_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace KoiPool_Project.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        // DbSet cho bảng History
        public DbSet<History> Histories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình bổ sung cho bảng History nếu cần
            modelBuilder.Entity<History>(entity =>
            {
                entity.HasKey(h => h.Id); // Khóa chính
                entity.Property(h => h.NamePool).IsRequired(); // Thuộc tính Name là bắt buộc
                entity.Property(h => h.Price).IsRequired(); // Thuộc tính Price là bắt buộc
            });
        }
    }
}
