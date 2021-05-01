using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bageriet.Models;
using Microsoft.AspNetCore.Mvc;
using Bageriet.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bageriet.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var HomeViewModel = new HomeViewModel
            {
                ProductOfTheWeek = _productRepository.ProductOfTheWeek
            };
            return View(HomeViewModel);
        }
    }
}
