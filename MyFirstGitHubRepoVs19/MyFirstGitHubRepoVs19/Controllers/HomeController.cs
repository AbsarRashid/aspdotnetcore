using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using MyFirstGitHubRepoVs19.Models;

namespace MyFirstGitHubRepoVs19.Controllers
{
    public class HomeController:Controller
    {
        [ViewData]
        public string CustomProperty { get; set; }
        [ViewData]
        public string Title { get; set; }

        [ViewData]
        public BookModel Book { get; set; }


        public ViewResult Index()
        {
            ViewBag.Title = "Index";
            dynamic data = new ExpandoObject();
            data.Id = 1;
            data.Name = "Nitish";
            ViewBag.Data = data;
            ViewBag.Type = new BookModel()
            {
               Id=5, Author="This is Author"
            };

            ViewData["Property1"] = "Absar";
            ViewData["book"] = new BookModel()
            {
                Id = 5,
                Author = "This is Author"
            };

            CustomProperty = "Custom String";
            Title = "Home Page";
            Book = new BookModel() { Id = 3, Title = "spDot net" };



            return View();
        }
        public ViewResult AboutUs()
        {
            ViewBag.Title = "About Us";
            return View();
        }
        public ViewResult Contactus()
        {
            ViewBag.Title = "Contact Us";
            return View();
        }
        public ViewResult CSharpRazor()
        {
            return View("PracRazorCSharp");
        }
    }
}
