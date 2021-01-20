using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using justAPlayMVC.Models;

namespace justAPlayMVC.Controllers
{
    public class DataExamplesController : Controller
    {

        public IActionResult ViewBagDemo()
        {
            ViewBag.Greeting = "Hello";
            return View();
        }

        public IActionResult ViewDataDemo()
        {
            ViewData["Greeting"] = "Hello";
            return View();
        }

        public IActionResult ModelDemo()
        {
            var book = new Book()
            {
                BookTitle = "Pickwick Papers",

                BookAuthor = "Dickens",

                PublishedDate = new DateTime(1836, 12, 25)
            };
            return View(book);
        }

    }
}
