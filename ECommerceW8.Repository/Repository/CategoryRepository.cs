using ECommerceW8.Data;
using ECommerceW8.Models;
using ECommerceW8.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceW8.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ECommerceW8DbContext _dbContext;

        public CategoryRepository(ECommerceW8DbContext dbContext)
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
