//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Emit;
//using System.Text;
//using System.Threading.Tasks;

//namespace finalCS.Data
//{
//    public class MyDbContext : DbContext
//    {
//       // public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

//        public DbSet<Product> Products { get; set; }
//        public DbSet<Category> Categories { get; set; }
//        public DbSet<Transaction> Transactions { get; set; }
//        public DbSet<Customer> Customers { get; set; } // Optional
//        public DbSet<User> Users { get; set; } // Optional

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);

//            modelBuilder.Entity<Category>()
//       .HasMany(c => c.Products)
//       .WithOne(p => p.Category)
//       .HasForeignKey(p => p.CategoryID)
//       .OnDelete(DeleteBehavior.Cascade);


//            modelBuilder.Entity<Product>()
//                .HasMany(p => p.Transactions)
//                .WithOne(t => t.Product)
//                .HasForeignKey(t => t.ProductID)
//                .OnDelete(DeleteBehavior.Cascade);


//            modelBuilder.Entity<Category>()
//                .HasIndex(c => c.CategoryName)
//                .IsUnique();
//            modelBuilder.Entity<Product>()
//      .HasIndex(p => new { p.Name, p.CategoryID })
//      .IsUnique();


//            modelBuilder.Entity<Product>()
//                .Property(p => p.Name)
//                .IsRequired()
//                .HasMaxLength(100);

//            modelBuilder.Entity<Transaction>()
//                .Property(t => t.Date)
//                .IsRequired();

//            modelBuilder.Entity<Product>()
//                .Property(p => p.StockQuantity)
//                .HasDefaultValue(0);

//            modelBuilder.Entity<Category>().HasData(
//                new Category { CategoryID = 1, CategoryName = "Electronics" },
//                new Category { CategoryID = 2, CategoryName = "Clothing" }
//            );
//        }
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {

//                optionsBuilder.UseSqlServer("Server=.\\;Database=FinalCS;Trusted_Connection=true; Encrypt=false");

//            }
//        }
//    }

//}



using Microsoft.EntityFrameworkCore;
using System;

namespace finalCS.Data
{
    public class MyDbContext : DbContext
    {
        // public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public MyDbContext() { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Customer> Customers { get; set; } // Optional
        public DbSet<User> Users { get; set; } // Optional

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.Transactions)
                .WithOne(t => t.Product)
                .HasForeignKey(t => t.ProductID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Category>()
                .HasIndex(c => c.CategoryName)
                .IsUnique();

            modelBuilder.Entity<Product>()
                .HasIndex(p => new { p.Name, p.CategoryID })
                .IsUnique();

            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Transaction>()
                .Property(t => t.Date)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(p => p.StockQuantity)
                .HasDefaultValue(0);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Electronics" },
                new Category { CategoryID = 2, CategoryName = "Clothing" },
                new Category { CategoryID = 3, CategoryName = "Books" },
                new Category { CategoryID = 4, CategoryName = "Home Appliances" }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, Name = "Smartphone", Description = "Latest model smartphone", Price = 699.99m, StockQuantity = 50, CategoryID = 1 },
                new Product { ProductID = 2, Name = "Laptop", Description = "High-performance laptop", Price = 999.99m, StockQuantity = 30, CategoryID = 1 },
                new Product { ProductID = 3, Name = "T-Shirt", Description = "100% cotton t-shirt", Price = 19.99m, StockQuantity = 100, CategoryID = 2 },
                new Product { ProductID = 4, Name = "Jeans", Description = "Denim jeans", Price = 49.99m, StockQuantity = 75, CategoryID = 2 },
                new Product { ProductID = 5, Name = "Fiction Book", Description = "Bestselling fiction book", Price = 14.99m, StockQuantity = 120, CategoryID = 3 },
                new Product { ProductID = 6, Name = "Cookbook", Description = "Recipe book with hundreds of recipes", Price = 24.99m, StockQuantity = 60, CategoryID = 3 },
                new Product { ProductID = 7, Name = "Blender", Description = "Kitchen blender with multiple speeds", Price = 79.99m, StockQuantity = 40, CategoryID = 4 },
                new Product { ProductID = 8, Name = "Microwave", Description = "Compact microwave oven", Price = 89.99m, StockQuantity = 35, CategoryID = 4 }
            );


            modelBuilder.Entity<Transaction>().HasData(
                new Transaction { TransactionID = 1, ProductID = 1, Quantity = 5, Date = DateTime.Now.AddDays(-10), Notes = "Initial stock purchase" },
                new Transaction { TransactionID = 2, ProductID = 2, Quantity = 10, Date = DateTime.Now.AddDays(-8), Notes = "Initial stock purchase" },
                new Transaction { TransactionID = 3, ProductID = 3, Quantity = 50, Date = DateTime.Now.AddDays(-6), Notes = "Initial stock purchase" },
                new Transaction { TransactionID = 4, ProductID = 4, Quantity = 30, Date = DateTime.Now.AddDays(-4), Notes = "Initial stock purchase" },
                new Transaction { TransactionID = 5, ProductID = 1, Quantity = -2, Date = DateTime.Now.AddDays(-2), Notes = "Sale" },
                new Transaction { TransactionID = 6, ProductID = 3, Quantity = -1, Date = DateTime.Now.AddDays(-1), Notes = "Sale" }
            );

            modelBuilder.Entity<User>().HasData(
                new User { UserID = 1, Username = "admin", PasswordHash = "admin123", Role = "Administrator" }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerID = 1,FirstName="John", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "123-456-7890" },
                new Customer { CustomerID = 2,FirstName="Jane", LastName = " Smith", Email = "jane.smith@example.com", PhoneNumber = "098-765-4321" }
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\;Database=FinalCS;Trusted_Connection=true; Encrypt=false");
            }
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"Database update error: {ex.Message}");
                throw new Exception("An error occurred while updating the database. Please try again later.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                throw;
            }
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                return await base.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"Database update error (async): {ex.Message}");
                throw new Exception("An error occurred while updating the database asynchronously. Please try again later.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error (async): {ex.Message}");
                throw;
            }
        }
    }
}

