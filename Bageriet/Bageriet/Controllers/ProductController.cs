using Microsoft.AspNetCore.Mvc;
using Bageriet.Models;
using Bageriet.ViewModels;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bageriet.Controllers
{
    public class ProductController : Controller 
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly AppDbContext _appDbContext;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository, AppDbContext appDbContext)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _appDbContext = appDbContext;
        }


       [Authorize]
        public IActionResult Comment(int ProductId, string comment, float ratings)
        {
            int id = ProductId;
            if (ModelState.IsValid)
            {
                _appDbContext.Products.Find(ProductId).Comment += comment + " || " + @User.Identity.Name;
                _appDbContext.Products.Find(ProductId).Ratings += ratings;
                _appDbContext.Products.Find(ProductId).Count++;
                _appDbContext.Products.Find(ProductId).Average = (_appDbContext.Products.Find(ProductId).Ratings / _appDbContext.Products.Find(ProductId).Count);
                _appDbContext.SaveChanges();
            }
                return RedirectToAction("Details", new { id });
        }
        public ViewResult ProductList()
        {
            ProductListViewModel ProductListViewModel = new ProductListViewModel();
            ProductListViewModel.Products = _productRepository.AllProducts;

            return View(ProductListViewModel);
        }

        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
                return NotFound();
            return View(product);
        }
    }
}
