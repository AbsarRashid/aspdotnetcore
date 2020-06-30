using MyFirstGitHubRepoVs19.ComFunction;
using MyFirstGitHubRepoVs19.DBClass;
using MyFirstGitHubRepoVs19.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstGitHubRepoVs19.Repository
{
    public class BookRepo
    {
        CallToDb dbconnec = new CallToDb();
        ComFunc func = new ComFunc();
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
            ClassProAccessParams cls = new ClassProAccessParams();
            cls.Calltype = "GetAllBookData";
            cls.StoredProcedure = "SP_ENTRY_BOOK_INFO";
            DataSet ds = dbconnec.GetTransResult(cls);
            var list = func.DataTableToList<BookModel>(ds.Tables[0]);
            return list;
        }
    }
}
