using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceW8.Models
{
    public class Image
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public Product Product { get; set; }
        
    }
}
