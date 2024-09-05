using AspNet.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.MVC.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            Author author1 = new Author { AuthorId = 1, Name = "Ivo Andrić", Nationality = "Bosnian" };
            Author author2 = new Author { AuthorId = 2, Name = "Gabriel García Márquez", Nationality = "Colombian" };
            Author author3 = new Author { AuthorId = 3, Name = "Leo Tolstoy", Nationality = "Russian" };
            
            List<Book> books = new List<Book>
            {
                new Book { BookId = 1, Title = "The Bridge on the Drina", YearPublished = 1945, Author = author1 },
                new Book { BookId = 2, Title = "One Hundred Years of Solitude", YearPublished = 1967, Author = author2 },
                new Book { BookId = 3, Title = "Love in the Time of Cholera", YearPublished = 1985, Author = author2 },
                new Book { BookId = 4, Title = "War and Peace", YearPublished = 1869, Author = author3 },
                new Book { BookId = 5, Title = "Anna Karenina", YearPublished = 1877, Author = author3 }
            };
            return View(books);
        }
    }
}