using Microsoft.EntityFrameworkCore;
using PMS.Data;
using PMS.Models;

namespace PMS.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<CategoryMaster> AddAsync(CategoryMaster category)
        {
            _context.CategoryMasters.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task UpdateAsync(CategoryMaster category)
        {
            _context.CategoryMasters.Update(category);
            await _context.SaveChangesAsync();
        }       
        public async Task DeleteAsync(int id)
        {
            var category = await _context.CategoryMasters.FindAsync(id);
            if (category != null)
            {
                _context.CategoryMasters.Remove(category);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<CategoryMaster>> GetAllAsync() =>
        await _context.CategoryMasters.ToListAsync();

        public async Task<CategoryMaster?> GetByIdAsync(int id) =>
         await _context.CategoryMasters.FindAsync(id);

        
    }
}
