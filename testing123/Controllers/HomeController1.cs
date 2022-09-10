using Microsoft.AspNetCore.Mvc;

namespace testing123.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "All books returning";
        }
        public string GetBook(int id)
        {
            return "book"+id+"returning";
        }
        public string exactBook(string author,string bookName)
        {
            return "Book " + bookName + " written by " + author + " found here";
        }
    }
}
