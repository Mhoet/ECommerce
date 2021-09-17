using EcommerceW8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceeW8.Services.Interface
{
    public interface IProductsServices
    {
        public IEnumerable<Product> ReturnProductList();
        public Product ReturnProductById(string id);
        public IEnumerable<Product> ReturnProductImages();
    }
}
