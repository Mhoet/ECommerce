using EcommerceeW8.Services.Interface;
using EcommerceW8.Data;
using EcommerceW8.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceeW8.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly ECommerceW8DbContext _dbContext;

        public CategoryServices(ECommerceW8DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Category> ReturnCategoryList()
        {
            IEnumerable<Category> categoryList = _dbContext.Category.Include(cat => cat.Products)
           .Include(cat => cat.Products)
           .ThenInclude(cat => cat.Images).ToList();
            return categoryList;
        }
    }
}
