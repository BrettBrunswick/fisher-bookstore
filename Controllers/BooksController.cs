using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fisher.Bookstore.Models;

namespace Fisher.Bookstore.Controllers
{

    public class BooksController : Controller
    {

        public IActionResult Index()
        {
            var books = GetBooks();
            return View(books);
        }

        public IActionResult New()
        {
            return Content ("Books controller’s New action");
        }

        private IEnumerable<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book() {
                Title = "My First Book",
                Author = new Author(){Name = "Brett Brunswick"}});

            books.Add(new Book() {
                Title = "Mr. Misunderstood",
                Author = new Author(){Name = "Eric Church"}});

            books.Add(new Book() {
                Title = "Nothing Was the Same",
                Author = new Author(){Name = "Drake"}});

                return books;        
        }

    }
}
