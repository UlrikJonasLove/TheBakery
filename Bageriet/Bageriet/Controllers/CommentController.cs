using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bageriet.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bageriet.Controllers
{
   /* public class CommentController : Controller
    {
        private readonly AppDbContext _appDbContext;
     
        public CommentController(AppDbContext appDbContext)
        {
           // _productRepository = productRepository;
            _appDbContext = appDbContext;

        }

        [HttpPost]
        public IActionResult Comment(int ProductId, string comment, float ratings)
        {
            int id = ProductId; 
            if (ModelState.IsValid)
            {
                _appDbContext.Products.Find(ProductId).Comment += comment + " - Användare: ";
                _appDbContext.Products.Find(ProductId).Ratings += ratings;
                _appDbContext.Products.Find(ProductId).Count++;
                _appDbContext.Products.Find(ProductId).Average = (_appDbContext.Products.Find(ProductId).Ratings / _appDbContext.Products.Find(ProductId).Count);
                _appDbContext.SaveChanges();
            }
            return RedirectToAction("Details", new { id });
        } 
    } */
}
