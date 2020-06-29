using MyFirstGitHubRepoVs19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstGitHubRepoVs19.Repository
{
    public class BookRepo
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookbyId(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title="MVC", Author="A"},
                new BookModel(){Id=2, Title="MVC1", Author="B"},
                new BookModel(){Id=3, Title="MVC2", Author="C"},
                new BookModel(){Id=4, Title="MVC3", Author="D"},
                new BookModel(){Id=5, Title="MVC5", Author="E"}
            };
        }
    }
}
