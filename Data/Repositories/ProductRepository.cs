using Ecommerce.Core.Models;
using Ecommerce.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public void Add(Product entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _context.Products.Add(entity);
        }

        public void Delete(Product entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _context.Products.Remove(entity);
        }

        public Task<List<Product>> GetAllAsync()
        {
            return _context.Products.ToListAsync();

        }

        public Task<Product> GetByIdAsync(int id)
        {
            return _context.Products.FirstOrDefaultAsync(p => p.ProductId == id);
        }

        public IEnumerable<Product> GetProductsByCategoryId(int id)
        {
             return _context.ProductCategories
               .Include(p => p.Product)
               .Where(c => c.CategoryId == id)
               .Select(c => c.Product)
               .ToList();
        }

        public void Update(Product entity)
        {
            _context.Products.Update(entity);
        }
    }


}
