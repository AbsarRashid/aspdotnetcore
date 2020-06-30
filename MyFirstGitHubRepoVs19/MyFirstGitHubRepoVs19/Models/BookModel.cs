using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstGitHubRepoVs19.Models
{
    public class BookModel
    { 
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int totalPages { get; set; }
        public string Language { get; set; }
        public string category { get; set; }

    }
}
