using System.ComponentModel.DataAnnotations;

namespace PMS.Models
{
    public class CategoryMaster
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public int CompanyId { get; set; }
        public int IsDelete { get; set; }
    }
}
