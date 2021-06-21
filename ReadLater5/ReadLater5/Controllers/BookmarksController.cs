using Entity;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadLater5.Controllers
{
    public class BookmarksController : Controller
    {
        private readonly IBookmarkService _bookmarkService;

        public BookmarksController(IBookmarkService service)
        {
            _bookmarkService = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetBookmarksForCategory(int categoryId)
        {
            return Ok(await _bookmarkService.GetAllBookmarksForCategory(categoryId));
        }

        #region Creating bookmark view and post action
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int categoryId, Bookmark bookmark)
        {
            bookmark.CategoryId = categoryId;
            return Ok(await _bookmarkService.CreateBookmark(bookmark));
        }
        #endregion

        [HttpDelete]
        public async Task<IActionResult> DeleteBookmarkFromCategory(int categoryId)
        {
            await _bookmarkService.DeleteBookmark(categoryId);
            return Ok();
        }

        public async Task<IActionResult> Update(int bookmarkId)
        {
            var bookmarkForUpdating = await _bookmarkService.GetBookmarkById(bookmarkId);
            return View(bookmarkForUpdating);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Bookmark bookmark)
        {
            await _bookmarkService.UpdateBookmark(bookmark);
            return Redirect($"/Categories/Details/{bookmark.CategoryId}");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int bookmarkId)
        {
            var bookmark = await _bookmarkService.GetBookmarkById(bookmarkId);
            return View(bookmark);
        }

    }
}
