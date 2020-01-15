using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFFPOSTGRESS.Domain.DAL
{
    public class StorageContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public StorageContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
