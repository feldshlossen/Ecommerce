using System.Collections.Generic;

namespace Ecommerce.Core.Models
{
    public class Product
    {


        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ExtendedSescription  { get; set; }
        public decimal Price { get; set; }
        public string ImgUrl { get; set; }
        public ICollection<Cart> Carts { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }
        public Product()
        {
            Carts = new HashSet<Cart>();
            ProductCategories = new HashSet<ProductCategory>();
        }

 
    }
}