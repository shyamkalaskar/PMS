using PMS.Models;

namespace PMS.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<CategoryMaster>> GetAllAsync();
        Task<CategoryMaster?> GetByIdAsync(int id);
        Task<CategoryMaster> AddAsync(CategoryMaster product);
        Task UpdateAsync(CategoryMaster product);
        Task DeleteAsync(int id);
    }
}
