using ECommerceW8.Data;
using ECommerceW8.Database;
using ECommerceW8.Models;
using ECommerceW8.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceW8.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ECommerceW8DbContext _dbContext;

        public ProductRepository(ECommerceW8DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Product> ReturnProductList()
        {
            IEnumerable<Product> productList = _dbContext.Product
                .Include(prod => prod.Category)
                .Include(prod => prod.Images).ToList();
            return productList;
        }
        public  Product ReturnProductById(string id)
        {
            Product product = _dbContext.Product.Include(prod => prod.Category)
                   .Include(prod => prod.Images).FirstOrDefault(prod => prod.Id == id);
            return product;
        }
        public IEnumerable<Product> ReturnProductImages()
        {
            IEnumerable<Product> products = _dbContext.Product
               .Include(cat => cat.Images).Take(12).ToList();
            return products;
        }
    }
}
