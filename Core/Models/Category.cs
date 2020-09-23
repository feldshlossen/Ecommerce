using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Core.Models
{
    public class Category
    {

        public int CategoryId { get; set; }
        public string Name { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }
        public Category()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }
    }
}
