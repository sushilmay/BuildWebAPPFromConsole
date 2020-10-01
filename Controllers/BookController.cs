using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using BuildWebAPPFromConsole.Model;
using BuildWebAPPFromConsole.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BuildWebAPPFromConsole.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<ViewResult> GetAllBooks()
        {
            var data= await _bookRepository.GetAllBooks();
            return View(data);
        }

        [Route("book-details/{id}", Name = "bookDetailsRoute")]
        public async Task<ViewResult> GetBook(int id)
        {
            var data= await _bookRepository.GetBookById(id);
            return View(data);
        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
        public ViewResult AddNewBook(bool isSuccess = false, int bookId = 0)
        {
            var model = new BookModel() { Language = "English" };
            ViewBag.Language = new SelectList(new List<string>() { "Hindi", "English", "Dutch" });

            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel bookModel)
        {
            ViewBag.Language = new SelectList(new List<string>() { "Hindi", "English", "Dutch" });

            if (ModelState.IsValid)
            {
                if (bookModel.TotalPages == null || bookModel.TotalPages<=0)
                {
                    ModelState.AddModelError("", "Total Pages must be greater than 0;");
                    return View();
                }
                int id = await _bookRepository.AddNewBook(bookModel);
                if (id > 0)
                { 
                    return RedirectToAction(nameof(AddNewBook), new { isSuccess = true, bookId = id });
                }
            }

            return View();
        }
    }
}
