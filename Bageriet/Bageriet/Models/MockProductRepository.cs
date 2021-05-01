using System.Collections.Generic;
using System.Linq;

namespace Bageriet.Models
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Product> AllProducts =>
            new List<Product>
            {
                new Product {ProductId=1, Name="Bagarens favorit", Description="Riktigt gott bröd!", Category = _categoryRepository.AllCategories.ToList()[0], ImageUrl="https://goldbelly.imgix.net/uploads/merchant/main_image/778/hot-bread-kitchen.05560fd0bcbc5b3bb726f649c9ee7124.jpg?ixlib=react-8.6.4&auto=format&fit=crop&h=534&w=1150", IsProductOfTheWeek = true, ImageThumbnailUrl="https://goldbelly.imgix.net/uploads/merchant/main_image/778/hot-bread-kitchen.05560fd0bcbc5b3bb726f649c9ee7124.jpg?ixlib=react-8.6.4&auto=format&fit=crop&h=534&w=1150"},
                new Product {ProductId=2, Name="Surdegsbröd", Description="Riktigt gott surdegsbröd!", Category = _categoryRepository.AllCategories.ToList()[0], ImageUrl="https://mittkok.expressen.se/wp-content/uploads/2016/04/surdeg.jpg", IsProductOfTheWeek=true, ImageThumbnailUrl="https://mittkok.expressen.se/wp-content/uploads/2016/04/surdeg.jpg"},
                new Product {ProductId=3, Name="Sommarhimlen", Description="Mörkt ommarbröd med bär i!", Category = _categoryRepository.AllCategories.ToList()[0], ImageUrl="https://img.koket.se/media/morkt-sommarbrod.jpg", IsProductOfTheWeek=true, ImageThumbnailUrl="https://img.koket.se/media/morkt-sommarbrod.jpg"},
                new Product {ProductId=4, Name="Chokladrutor", Description="kaka med choklad!", Category = _categoryRepository.AllCategories.ToList()[1], ImageUrl="https://www.jennysmatblogg.nu/wp-content/uploads/img_1974-2.jpg", IsProductOfTheWeek=true, ImageThumbnailUrl="https://www.jennysmatblogg.nu/wp-content/uploads/img_1974-2.jpg"},
                new Product {ProductId=5, Name="Äppelkaka", Description="Smarrig äppelkaka!", Category = _categoryRepository.AllCategories.ToList()[1], ImageUrl="https://www.viaventri.se/wp-content/uploads/2018/08/IMG_4970-kopia.jpg", IsProductOfTheWeek=true, ImageThumbnailUrl="https://www.viaventri.se/wp-content/uploads/2018/08/IMG_4970-kopia.jpg"},
                new Product {ProductId=6, Name="sockerkaka", Description="Bästa sockerkakan i Sverige!", Category = _categoryRepository.AllCategories.ToList()[1], ImageUrl="https://img.koket.se/media/hur-bakar-man-sockerkaka.jpg", IsProductOfTheWeek=true, ImageThumbnailUrl="https://img.koket.se/media/hur-bakar-man-sockerkaka.jpg"},
                new Product {ProductId=7, Name="Hallontårta", Description="Tårta med marängsmörkräm", Category = _categoryRepository.AllCategories.ToList()[2], ImageUrl="https://img.koket.se/media/fantastiska-tartor.jpg", IsProductOfTheWeek=true, ImageThumbnailUrl="https://img.koket.se/media/fantastiska-tartor.jpg"},
                new Product {ProductId=8, Name="Jasmin tårta", Description="Tårta med smak av jasmin!", Category = _categoryRepository.AllCategories.ToList()[2], ImageUrl="https://img.koket.se/mobile/stencildekoration-pa-tarta-se-gor.jpg", IsProductOfTheWeek=true, ImageThumbnailUrl="https://img.koket.se/mobile/stencildekoration-pa-tarta-se-gor.jpg"},
                new Product {ProductId=9, Name="Paradis tårta", Description="Chokladtårta med utsökt delikatess", Category = _categoryRepository.AllCategories.ToList()[2], ImageUrl="https://www.kenwoodworld.com/Global/recipes/Recipe%20Images/titanium/Chocolate-Cake.jpg", IsProductOfTheWeek=true, ImageThumbnailUrl="https://www.kenwoodworld.com/Global/recipes/Recipe%20Images/titanium/Chocolate-Cake.jpg"},
                new Product {ProductId=10, Name="Pepperoni pizza", Description="Pizza med italiensk pepperoni", Category = _categoryRepository.AllCategories.ToList()[3], ImageUrl="https://img1.cookinglight.timeinc.net/sites/default/files/styles/medium_2x/public/1563392585/pepperoni-skillet-pizza-1907.jpg?itok=l_08ukf0", IsProductOfTheWeek = false, ImageThumbnailUrl="https://img1.cookinglight.timeinc.net/sites/default/files/styles/medium_2x/public/1563392585/pepperoni-skillet-pizza-1907.jpg?itok=l_08ukf0"},
                new Product {ProductId=11, Name="Vegetarisk pizza", Description="Vegetarisk pizza med mozerella", Category = _categoryRepository.AllCategories.ToList()[3], ImageUrl="https://st2.depositphotos.com/4208641/7406/i/950/depositphotos_74061695-stock-photo-vegetarian-pizza-with-mozzarella-and.jpg", IsProductOfTheWeek=true, ImageThumbnailUrl="https://st2.depositphotos.com/4208641/7406/i/950/depositphotos_74061695-stock-photo-vegetarian-pizza-with-mozzarella-and.jpg"},
                new Product {ProductId=12, Name="Vesuvio pizza", Description="Supergod pizza med skinka och ost!", Category = _categoryRepository.AllCategories.ToList()[3], ImageUrl="https://imgs.aftonbladet-cdn.se/v2/images/26753b77-44ff-4d8b-bfb6-cf57fe26ecac?fit=crop&h=442&q=50&w=600&s=89af9ba3747ae09a577ca1b8e81e10543bde2a32", IsProductOfTheWeek=true, ImageThumbnailUrl="https://imgs.aftonbladet-cdn.se/v2/images/26753b77-44ff-4d8b-bfb6-cf57fe26ecac?fit=crop&h=442&q=50&w=600&s=89af9ba3747ae09a577ca1b8e81e10543bde2a32"}
            };
        public IEnumerable<Product> ProductOfTheWeek { get; }
        public Product GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
