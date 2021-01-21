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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LayoutDemo()
        {
            return View();
        }

        public IActionResult SecondLayoutDemo()
        {
            return View();
        }

        public IActionResult SampleForm ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SampleForm(string Username, string Email, string Telephone, string Message, string RedirectMe)
        {
            if(RedirectMe == "1")
            {
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Username = Username;
            ViewBag.Email = Email;
            ViewBag.Telephone = Telephone;
            ViewBag.Message = Message;
            return View();
        }

        public IActionResult SampleFormModel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SampleFormModel(FeedbackForm model)
        {
            if (model.RedirectMe == "1")
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
