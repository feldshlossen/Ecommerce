using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Core.Repositories
{
   public interface IRepository<T>
    {

        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        void Update(T entity);
        void Add(T entity);
        void Delete(T entity);
    }
}
