using Microsoft.EntityFrameworkCore;
using Storage.Domain;

namespace Storage.DAL
{
    public class StorageContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProduct { get; set; }

        public StorageContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<OrderProduct>()
                        .HasKey(t => new { t.OrderNumber, t.ProductId });

            modelBuilder.Entity<OrderProduct>()
                        .HasOne(sc => sc.Order)
                        .WithMany(s => s.OrderProducts)
                        .HasForeignKey(sc => sc.OrderNumber);

            modelBuilder.Entity<OrderProduct>()
                        .HasOne(sc => sc.Product)
                        .WithMany(c => c.OrderProducts)
                        .HasForeignKey(sc => sc.ProductId);
        }
    }
}