using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Bröd" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Kakor" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Tårtor" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Mat" });

            //seed pies

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Bagarens favorit!",
                Description = "Riktigt gott bröd!",
                CategoryId = 1,
                ImageUrl = "https://goldbelly.imgix.net/uploads/merchant/main_image/778/hot-bread-kitchen.05560fd0bcbc5b3bb726f649c9ee7124.jpg?ixlib=react-8.6.4&auto=format&fit=crop&h=534&w=1150",
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://goldbelly.imgix.net/uploads/merchant/main_image/778/hot-bread-kitchen.05560fd0bcbc5b3bb726f649c9ee7124.jpg?ixlib=react-8.6.4&auto=format&fit=crop&h=534&w=1150",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Surdegsbröd!",
                Description = "Riktigt gott surdegsbröd!",
                CategoryId = 1,
                ImageUrl = "https://mittkok.expressen.se/wp-content/uploads/2016/04/surdeg.jpg",
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://mittkok.expressen.se/wp-content/uploads/2016/04/surdeg.jpg",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Sommarhimlen",
                Description = "Mörkt sommarbröd med bär!",
                CategoryId = 1,
                ImageUrl = "https://img.koket.se/media/morkt-sommarbrod.jpg",
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://img.koket.se/media/morkt-sommarbrod.jpg",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Chokladrutor",
                Description = "Kaka med choklad!",
                CategoryId = 2,
                ImageUrl = "https://www.jennysmatblogg.nu/wp-content/uploads/img_1974-2.jpg",
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://www.jennysmatblogg.nu/wp-content/uploads/img_1974-2.jpg",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Äppelkaka",
                Description = "Smarrig äppelkaka!",
                CategoryId = 2,
                ImageUrl = "https://www.viaventri.se/wp-content/uploads/2018/08/IMG_4970-kopia.jpg",
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://www.viaventri.se/wp-content/uploads/2018/08/IMG_4970-kopia.jpg",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Sockerkaka",
                Description = "Bästa sockerkakan i Sverige!",
                CategoryId = 2,
                ImageUrl = "https://img.koket.se/media/hur-bakar-man-sockerkaka.jpg",
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://img.koket.se/media/hur-bakar-man-sockerkaka.jpg",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Hallontårta",
                Description = "Tårta med marängsmörkräm!",
                CategoryId = 3,
                ImageUrl = "https://img.koket.se/media/fantastiska-tartor.jpg",
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://img.koket.se/media/fantastiska-tartor.jpg",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "Jasmintårta",
                Description = "Tårta med smak av jasmin!",
                CategoryId = 3,
                ImageUrl = "https://img.koket.se/mobile/stencildekoration-pa-tarta-se-gor.jpg",
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://img.koket.se/mobile/stencildekoration-pa-tarta-se-gor.jpg",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                Name = "Paradistårta",
                Description = "Chokladtårta med utsökt delikatess!",
                CategoryId = 3,
                ImageUrl = "https://www.kenwoodworld.com/Global/recipes/Recipe%20Images/titanium/Chocolate-Cake.jpg",
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://www.kenwoodworld.com/Global/recipes/Recipe%20Images/titanium/Chocolate-Cake.jpg",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 10,
                Name = "Pepperoni pizza",
                Description = "Pizza med italiensk pepperoni!",
                CategoryId = 4,
                ImageUrl = "https://img1.cookinglight.timeinc.net/sites/default/files/styles/medium_2x/public/1563392585/pepperoni-skillet-pizza-1907.jpg?itok=l_08ukf0",
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://img1.cookinglight.timeinc.net/sites/default/files/styles/medium_2x/public/1563392585/pepperoni-skillet-pizza-1907.jpg?itok=l_08ukf0",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 11,
                Name = "Vegetarisk pizza",
                Description = "Vegetarisk pizza med mozerella",
                CategoryId = 4,
                ImageUrl = "https://st2.depositphotos.com/4208641/7406/i/950/depositphotos_74061695-stock-photo-vegetarian-pizza-with-mozzarella-and.jpg",
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://st2.depositphotos.com/4208641/7406/i/950/depositphotos_74061695-stock-photo-vegetarian-pizza-with-mozzarella-and.jpg",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 12,
                Name = "Vesuvio pizza",
                Description = "Supergod pizza med skinka och ost!",
                CategoryId = 4,
                ImageUrl = "https://imgs.aftonbladet-cdn.se/v2/images/26753b77-44ff-4d8b-bfb6-cf57fe26ecac?fit=crop&h=442&q=50&w=600&s=89af9ba3747ae09a577ca1b8e81e10543bde2a32",
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://imgs.aftonbladet-cdn.se/v2/images/26753b77-44ff-4d8b-bfb6-cf57fe26ecac?fit=crop&h=442&q=50&w=600&s=89af9ba3747ae09a577ca1b8e81e10543bde2a32",
            });
        }
    }
}
