using EcommerceeW8.Services.Interface;
using EcommerceW8.Models;
using ECommerceW8.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace ECommerceW8.Controllers
{
    public class HomeController : Controller
    {
            private readonly IProductsServices _productService;

            public HomeController(IProductsServices productService)
            {
                _productService = productService;
            }

            public IActionResult Index()
            {
                IEnumerable < Product > products = _productService.ReturnProductImages();
                return View(products);
            }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
