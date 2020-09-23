using Ecommerce.Core.Models;
using Ecommerce.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Core
{
    public interface IUnitOfWork
    {

        IProductRepository Products { get; }
        IRepository<Category> Categories { get; }
        Task SaveChangesAsync();


    }
}
