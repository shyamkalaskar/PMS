using Microsoft.EntityFrameworkCore;
using PMS.Models;

namespace PMS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<CategoryMaster> CategoryMasters => Set<CategoryMaster>();
       
       
    }
}
