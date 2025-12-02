using Microsoft.EntityFrameworkCore;
using ComandaPro.Domain.Entities;
using ComandaPro.Repository.Mapping;

namespace ComandaPro.Repository.Context
{
    public class ComandaProContext : DbContext
    {
        public ComandaProContext()
        {
            Database.EnsureCreated();
        }

        public ComandaProContext(DbContextOptions<ComandaProContext>? op=null) : base(op) 
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=ComandaPro;user=root;password=");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ItemOrder> ItemOrders { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>(new CategoryMap().Configure);
            modelBuilder.Entity<Product>(new ProductMap().Configure);
            modelBuilder.Entity<Order>(new OrderMap().Configure);
            modelBuilder.Entity<Payment>(new PaymentMap().Configure);
            modelBuilder.Entity<ItemOrder>(new ItemOrderMap().Configure);
            modelBuilder.Entity<User>(new UserMap().Configure);
        }
    }
}
