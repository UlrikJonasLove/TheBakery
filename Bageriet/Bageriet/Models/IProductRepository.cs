using System.Collections.Generic;

namespace Bageriet.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
        IEnumerable<Product> ProductOfTheWeek { get;  }
        Product GetProductById(int ProductId);
    }
}
