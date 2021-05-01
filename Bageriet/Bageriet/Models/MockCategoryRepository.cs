using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Bröd", Description="Precis som hemmabakat!"},
                new Category{CategoryId=2, CategoryName="Kakor", Description="Goda och ljuvliga!"},
                new Category{CategoryId=3, CategoryName="Tårtor", Description="Söta tårtor för alla festligheter!"},
                new Category{CategoryId=4, CategoryName="Mat", Description="Lite mat för kvällen!"}

            };
    }
}
