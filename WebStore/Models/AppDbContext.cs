using Microsoft.EntityFrameworkCore;

namespace WebStore.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Keyboard> Keyboards { get; set; }
        public DbSet<Headphones> Headphones { get; set; }
        public DbSet<Mouse> Mice { get; set; }
        public DbSet<Monitor> Monitors { get; set; }
        public DbSet<Category> Categories { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Mechaniczna", CategoryDescription = "klawiatura mechaniczna" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Membranowa", CategoryDescription = "klawiatura membranowa" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Hybrydowa", CategoryDescription = "klawiatura hybrydowa" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Przewodowa", CategoryDescription = "myszka przewodowa" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Bezprzewodowa", CategoryDescription = "myszka bezprzewodowa" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 6, CategoryName = "Bezprzewodowe", CategoryDescription = "słuchawki bezprzewodowe" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 7, CategoryName = "Przewodowe", CategoryDescription = "słuchawki przewodowa" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 8, CategoryName = "Zakrzywiony", CategoryDescription = "monitor zakrzywiony" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 9, CategoryName = "Klasyczny", CategoryDescription = "monitor klasyczny" });



            modelBuilder.Entity<Keyboard>().HasData(new Keyboard
            {
                KeyboardId = 1,
                Name = "Corsair k100",
                Price = 899.99M,
                Description ="klawiatura corsiar k100",
                CategoryId = 1,
                ImageUrl = "~\\Images\\klawiatura1.jpg",
                ImageThumbnailUrl = "~\\Images\\klawiatura1.jpg",
                IsInStock = true,
                IsOnSale = false
            }); ;

            modelBuilder.Entity<Keyboard>().HasData(new Keyboard
            {
                KeyboardId = 2,
                Name = "FURY czarna",
                Price = 150.99M,
                Description = "klawiatura FURY czarna",
                CategoryId = 2,
                ImageUrl = "~\\Images\\klawiatura2.jpg",
                ImageThumbnailUrl = "~\\Images\\klawiatura2.jpg",
                IsInStock = true,
                IsOnSale = false
            }); ;

            modelBuilder.Entity<Keyboard>().HasData(new Keyboard
            {
                KeyboardId = 3,
                Name = "LOGITECH G513",
                Price = 530.99M,
                Description = "klawiatura LOGITECH G513a",
                CategoryId = 1,
                ImageUrl = "~\\Images\\klawiatura3.jpg",
                ImageThumbnailUrl = "~\\Images\\klawiatura3.jpg",
                IsInStock = true,
                IsOnSale = false
            }); ;


            modelBuilder.Entity<Monitor>().HasData(new Monitor
            {
                MonitorId = 1,
                Name = "BenQ EW3270U czarny 4K HDR",
                Price = 1000M,
                Inches = 23,
                Description = "monitor BenQ EW3270U czarny 4K HDR",
                CategoryId = 9,
                ImageUrl = "~\\Images\\monitor1.jpg",
                ImageThumbnailUrl = "~\\Images\\monitor1.jpg",
                IsInStock = true,
                IsOnSale = false
            }); ;

            modelBuilder.Entity<Monitor>().HasData(new Monitor
            {
                MonitorId = 2,
                Name = "Xiaomi Mi Desktop",
                Price = 1200M,
                Inches = 27,
                Description = "Monitor Xiaomi Mi Desktop Monitor 27",
                CategoryId = 9,
                ImageUrl = "~\\Images\\monitor2.jpg",
                ImageThumbnailUrl = "~\\Images\\monitor2.jpg",
                IsInStock = true,
                IsOnSale = false
            }); ;


            modelBuilder.Entity<Monitor>().HasData(new Monitor
            {
                MonitorId = 3,
                Name = "Acer KA242Y IPS 1ms FHD AMD FreeSync",
                Price = 1200M,
                Inches = 24,
                Description = "Monitor Acer KA242Y IPS 1ms FHD AMD FreeSync",
                CategoryId = 9,
                ImageUrl = "~\\Images\\monitor3.jpg",
                ImageThumbnailUrl = "~\\Images\\monitor3.jpg",
                IsInStock = true,
                IsOnSale = false
            }); ;

            modelBuilder.Entity<Mouse>().HasData(new Mouse
            {
                MouseId = 1,
                Name = "RAZER-DeathAdderV2PRO",
                Price = 200M,
                Dpi = 3200,
                Description = "Myszka RAZER-DeathAdderV2PRO",
                CategoryId = 5,
                ImageUrl = "~\\Images\\myszka1.jpg",
                ImageThumbnailUrl = "~\\Images\\myszka1.jpg",
                IsInStock = true,
                IsOnSale = false
            }); ;

            modelBuilder.Entity<Mouse>().HasData(new Mouse
            {
                MouseId = 2,
                Name = "SteelSeries Rival 5",
                Price = 300M,
                Dpi = 3200,
                Description = "Myszka SteelSeries Rival 5",
                CategoryId = 4,
                ImageUrl = "~\\Images\\myszka2.jpg",
                ImageThumbnailUrl = "~\\Images\\myszka2.jpg",
                IsInStock = true,
                IsOnSale = false
            }); ;

            modelBuilder.Entity<Mouse>().HasData(new Mouse
            {
                MouseId = 3,
                Name = "COBRA-PRO-LIGHT-MT1117",
                Price = 500M,
                Dpi = 3200,
                Description = "Myszka COBRA-PRO-LIGHT-MT1117",
                CategoryId = 4,
                ImageUrl = "~\\Images\\myszka3.jpg",
                ImageThumbnailUrl = "~\\Images\\myszka3.jpg",
                IsInStock = true,
                IsOnSale = false
            }); ;

            modelBuilder.Entity<Headphones>().HasData(new Headphones
            {
                HeadphonesId = 1,
                Name = "Zeus Bass",
                Price = 620M,
                Wireless = false,
                Description = "Intezze słuchawki przewodowe Zeus Bass",
                CategoryId = 7,
                ImageUrl = "~\\Images\\słuchawki1.jpg",
                ImageThumbnailUrl = "~\\Images\\słuchawki1.jpg",
                IsInStock = true,
                IsOnSale = false
            }); ;

            modelBuilder.Entity<Headphones>().HasData(new Headphones
            {
                HeadphonesId = 2,
                Name = "Philips BASS+ TAH4205BL00",
                Price = 450M,
                Wireless = true,
                Description = "Słuchawki Philips BASS+ TAH4205BL00",
                CategoryId = 6,
                ImageUrl = "~\\Images\\słuchawki2.jpg",
                ImageThumbnailUrl = "~\\Images\\słuchawki2.jpg",
                IsInStock = true,
                IsOnSale = false
            }); ;

            modelBuilder.Entity<Headphones>().HasData(new Headphones
            {
                HeadphonesId = 3,
                Name = "Philips Performance TAPH805BK00",
                Price = 750M,
                Wireless = true,
                Description = "Słuchawki Philips Performance TAPH805BK00",
                CategoryId = 6,
                ImageUrl = "~\\Images\\słuchawki3.jpg",
                ImageThumbnailUrl = "~\\Images\\słuchawki3.jpg",
                IsInStock = true,
                IsOnSale = false
            }); ;
        }

    }
}
