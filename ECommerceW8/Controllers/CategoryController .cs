using EcommerceeW8.Services.Interface;
using EcommerceW8.Data;
using EcommerceW8.Models;
using ECommerceW8.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace ECommerceW8.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryServices _categoryService;

        public CategoryController(ICategoryServices categoryServices)
        {
            _categoryService = categoryServices;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categoryList =_categoryService.ReturnCategoryList();
            return View(categoryList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
