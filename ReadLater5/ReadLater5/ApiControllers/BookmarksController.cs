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
    public class BookmarksController : ControllerBase
    {
        private readonly IBookmarkService _service;

        public BookmarksController(IBookmarkService service)
        {
            _service = service;
        }

        [HttpGet("{bookmarkId}")]
        public async Task<IActionResult> Get(int bookmarkId)
        {
            return new JsonResult(await _service.GetBookmarkById(bookmarkId));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Bookmark bookmark)
        {
            return new JsonResult(await _service.CreateBookmark(bookmark));
        }

        [HttpPut("{bookmarkId}")]
        public async Task<IActionResult> Put(int bookmarkId, [FromBody] Bookmark bookmark)
        {
            bookmark.ID = bookmarkId;
            await _service.UpdateBookmark(bookmark);
            return new NoContentResult();
        }

        [HttpDelete("{userId}")]
        public async Task<IActionResult> Delete(string userId, [FromBody] Bookmark bookmark)
        {
            await _service.DeleteBookmark(bookmark);
            return new NoContentResult();
        }
    }
}
