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
    public class ProductsServices : IProductsServices
    {
        private readonly ECommerceW8DbContext _dbContext;

        public ProductsServices(ECommerceW8DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<EcommerceW8.Models.Product> ReturnProductList()
        {
            IEnumerable<Product> productList = _dbContext.Product.Include(prod => prod.Category)
                .Include(prod => prod.Images).ToList();
            return productList;
        }
        public Product ReturnProductById(string id)
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
