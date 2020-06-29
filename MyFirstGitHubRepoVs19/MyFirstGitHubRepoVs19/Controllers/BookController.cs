using System;
using System.Collections.Generic;
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
            return View();
        }
        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookbyId(id);
        }
        public List<BookModel> SearchBooks(string books, string authorName)
        {
            return _bookRepository.SearchBook(books, authorName);
        }
    }
}
