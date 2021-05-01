using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appAbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            _appAbContext = appDbContext;
        }

        public IEnumerable<Product> AllProducts
        {
            get
            {
                return _appAbContext.Products.Include(c => c.Category);
            }
        }

        public IEnumerable<Product> ProductOfTheWeek
        {
            get
            {
                return _appAbContext.Products.Include(c => c.Category).Where(p => p.IsProductOfTheWeek);
            }
        }

        public Product GetProductById(int productId)
        {
            return _appAbContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
