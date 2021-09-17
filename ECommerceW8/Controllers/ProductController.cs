using EcommerceeW8.Services.Interface;
using EcommerceW8.Models;
using ECommerceW8.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace ECommerceW8.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductsServices _productService;
        public ProductController(IProductsServices productService)
        {
            _productService = productService;
        }


        public IActionResult Index()
        {
            IEnumerable<Product> productList = _productService.ReturnProductList();
            return View(productList);
        }


        [HttpPost]
        public IActionResult SearchByCategory(string searchQuery)
        {
            IEnumerable<Product> productList = _productService.ReturnProductList();

            List<Product> productsByCategory = new List<Product>();
            if (string.IsNullOrEmpty(searchQuery))
            {
                return NotFound();
            }
            foreach (var item in productList)
            {
                if(item.Category.Name == searchQuery)
                {
                    productsByCategory.Add(item);
                }
            }
            return View(productsByCategory);
        }
        public IActionResult ProductDetail(string id)
        {
            Product product = _productService.ReturnProductById(id);
            return View(product);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
