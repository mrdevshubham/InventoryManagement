using Microsoft.EntityFrameworkCore;

namespace Customer.Data.DataAccess
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext()
        {

        }
        public CustomerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer.Data.Entities.Configurations.Customer> Customers { get; set; }
        public DbSet<Customer.Data.Entities.Configurations.Orders> orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=SHUBHAMJAIN02; Initial Catalog=CustomerApp;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer.Data.Entities.Configurations.Customer>(customer =>
            {
                customer.ToTable("Customers");
                customer.HasKey("ID");
            });

            modelBuilder.Entity<Customer.Data.Entities.Configurations.Orders>(orders =>
            {
                orders.ToTable("Orders");
                orders.HasKey("ORD_ID");
                orders.HasKey("CUST_ID");
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}
