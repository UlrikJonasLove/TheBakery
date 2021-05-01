using System.Collections.Generic;
using Bageriet.Models;

namespace Bageriet.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
