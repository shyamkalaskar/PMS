using Microsoft.AspNetCore.Mvc;
using PMS.Models;
using PMS.Repositories;

namespace PMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _repository;

        public CategoryController(ICategoryRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryMaster>>> Get() =>
        Ok(await _repository.GetAllAsync());

        [HttpGet("{id}")] // Get Single Record
        public async Task<ActionResult<CategoryMaster>> GetCategory(int id)
        {
            var category = await _repository.GetByIdAsync(id);
            if (category == null) return NotFound();
            return Ok(category);
        }

        [HttpPost]// Insert
        public async Task<ActionResult<CategoryMaster>> AddCategory(CategoryMaster category)
        {
            var newCategory = await _repository.AddAsync(category);
            return CreatedAtAction(nameof(Get), new { id = newCategory.CategoryId }, newCategory);
        }

        [HttpPut]// Update
        public async Task<IActionResult> UpdateCategory(CategoryMaster category)
        {
            try
            {
                if (category.CategoryId != category.CategoryId) return BadRequest();
                await _repository.UpdateAsync(category);
            }
            catch
            {
                
            }
          
            return Ok(category);
        }

        [HttpDelete("{id}")]// Delete
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _repository.GetByIdAsync(id);
            if (category != null)
            {
                category.IsDelete = 1;
                await _repository.UpdateAsync(category);               
            }
            return Ok(category);
        }

    }
}
