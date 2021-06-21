using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Threading.Tasks;

namespace ReadLater5.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IBookmarkService _bookmarkService;
        private readonly ICategoryService _categoryService;

        public UserController(IBookmarkService bookmarkService, ICategoryService categoryService)
        {
            _bookmarkService = bookmarkService;
            _categoryService = categoryService;
        }

        [HttpGet("{userId}/categories/")]
        public async Task<IActionResult> Bookmarks(string userId)
        {
            return new JsonResult(await _bookmarkService.GetAllBookmarksForUser(userId));
        }

        [HttpGet("{userId}/bookmarks")]
        public async Task<IActionResult> Categories(string userId)
        {
            return new JsonResult(await _categoryService.GetCategoriesForUser(userId));
        }

    }
}
