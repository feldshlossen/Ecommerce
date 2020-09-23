using System.Net.Http.Headers;

namespace Ecommerce.Core.Models
{
    public class Cart
    {

        public int ProductId { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public Product Product { get; set; }

    }
}