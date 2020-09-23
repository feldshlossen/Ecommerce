using Ecommerce.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {

        IEnumerable<Product> GetProductsByCategoryId(int id);

    }
}
