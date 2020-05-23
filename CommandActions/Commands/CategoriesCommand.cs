using Infrastructure.DBContext;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandActions.Commands
{
    public class CategoriesCommand : ICategoriesCommand
    {
        private readonly ProductDBContext _context;

        public CategoriesCommand(ProductDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategory(long id)
        {
            var category = await _context.Categories.FindAsync(id);

            return category;
        }

        public async void UpdateCategory(Category category)
        {
            _context.Entry(category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public async Task<Category> AddCategory(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            return category;
        }

        public async Task<Category> DeleteCategory(Category category)
        {

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return category;
        }

        public bool CategoryExists(long id)
        {
            return _context.Categories.Any(e => e.CategoryId == id);
        }
    }
}
