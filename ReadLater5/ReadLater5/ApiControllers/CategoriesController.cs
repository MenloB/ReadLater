using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Threading.Tasks;

namespace ReadLater5.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet("{categoryName}")]
        public async Task<IActionResult> Get(string categoryName)
        {
            return new JsonResult(await _service.GetCategory(categoryName));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Category category)
        {
            return new JsonResult(await _service.CreateCategory(category));
        }

        [HttpPut("{categoryId}")]
        public async Task<IActionResult> Put(string categoryId, [FromBody] Category category)
        {
            await _service.UpdateCategory(category);
            return new NoContentResult();
        }

        [HttpDelete("{userId}")]
        public async Task<IActionResult> Delete(string userId, [FromBody] Category category)
        {
            await _service.DeleteCategory(category);
            return new NoContentResult();
        }
    }
}
