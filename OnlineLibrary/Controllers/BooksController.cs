using Microsoft.AspNetCore.Mvc;
using OnlineLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Controllers
{
        // Genres and Events
    public class BooksController : Controller
    {
        BookContext db;
        public BooksController(BookContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            List<Genre> GenreList = db.Genre.OrderBy(o => o.Name).ToList();

            return View(GenreList);
        }

        // When you click on the book
        public IActionResult ClickCover(int id)
        {
            Books book = db.Books.FirstOrDefault(x => x.IdBook == id);

            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        // When choosing a genre
        public IActionResult ClickGenre(int id)
        {
            List<Books> books = db.Books.Where(x => x.GenreId == id).ToList();

            if (books == null)
            {
                return NotFound();
            }
            return View(books);
        }

    }

}

