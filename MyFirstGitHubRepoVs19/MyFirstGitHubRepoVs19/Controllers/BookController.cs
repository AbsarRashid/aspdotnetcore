using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstGitHubRepoVs19.Models;
using MyFirstGitHubRepoVs19.Repository;

namespace MyFirstGitHubRepoVs19.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepo _bookRepository=null;

        public BookController()
        {
            _bookRepository = new BookRepo();
        }
        public ViewResult GetAllBooks()
        {
            
            var data= _bookRepository.GetAllBooks();

            return View(data);
        }
        [Route("book.details/{id}", Name= "bookDetailsRoute")]
        public ViewResult GetBook(int id)
        {
            dynamic data = new ExpandoObject();
            data.book= _bookRepository.GetBookbyId(id);
            data.Name = "Absar";
            return View(data);
        }
        public List<BookModel> SearchBooks(string books, string authorName)
        {
            return _bookRepository.SearchBook(books, authorName);
        }
        public ViewResult AddNewBook()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddNewBook(BookModel bookModel)
        {
            return View();
        }
    }
}
