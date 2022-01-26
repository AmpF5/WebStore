using Microsoft.EntityFrameworkCore;

namespace WebStore.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Keyboard> Keyboards { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Mechaniczna", CategoryDescription = "klawiatura mechaniczna" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Membranowa", CategoryDescription = "klawiatura membranowa" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Hybrydowa", CategoryDescription = "klawiatura hybrydowa" });


            modelBuilder.Entity<Keyboard>().HasData(new Keyboard
            {
                KeyboardId = 1,
                Name = "Corsair k100",
                Price = 899.99M,
                Description ="klawiatura corsiar k100",
                CategoryId = 1,
                ImageUrl = "\\Images\\corsairk100.jpg",
                ImageThumbnailUrl = "\\Images\\corsairk100.jpg",
                IsInStock = true,
                IsOnSale = false
            }); ;
        }

    }
}
