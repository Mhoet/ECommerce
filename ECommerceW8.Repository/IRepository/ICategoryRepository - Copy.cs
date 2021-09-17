using ECommerceW8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceW8.Repository.IRepository
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> ReturnCategoryList();
    }
}
