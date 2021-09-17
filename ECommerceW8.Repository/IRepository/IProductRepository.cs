using ECommerceW8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceW8.Repository.IRepository
{
    public interface IProductRepository
    {
        public IEnumerable<Product> ReturnProductList();
        public Product ReturnProductById(string id);
        public IEnumerable<Product> ReturnProductImages();
    }
}
