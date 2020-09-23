using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Core.Models
{
    public class ApplicationUser : IdentityUser
    {

        public ICollection<Cart> Carts { get; set; }

        public ApplicationUser()
        {
            Carts = new HashSet<Cart>();
        }


    }
}
