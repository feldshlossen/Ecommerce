using Ecommerce.Core.Models;
using Ecommerce.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Data.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Category entity)
        {
            _context.Categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            _context.Categories.Remove(entity);
        }

        public Task<List<Category>> GetAllAsync()
        {
           return _context.Categories.ToListAsync();
        }

        public Task<Category> GetByIdAsync(int id)
        {
            //return _context.Categories.FirstOrDefault(c => c.CategoryId == id);
            return _context.Categories.FirstOrDefaultAsync(ic => ic.CategoryId == id);
        }

        public void Update(Category entity)
        {
            _context.Categories.Update(entity);
        }
    }
}
