using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Controllers
{
    public class HomeController : Controller
    {
        BookContext db;
        public HomeController(BookContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.Books.ToListAsync());
        }
        public async Task<IActionResult> Favorites()
        {
            return View(await db.Books.ToListAsync());
        }
        public async Task<IActionResult> isFavorite(int id)
        {
            Books book = db.Books.FirstOrDefault(x => x.IdBook == id);
            if (book.Favorites == 0)
                book.Favorites = 1;
            else
                book.Favorites = 0;

            db.Books.Update(book);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
