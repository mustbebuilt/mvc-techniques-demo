using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace justAPlayMVC.ViewComponents
{
    public class WishListViewComponent : ViewComponent
    {
        const string WishListFilim = "Star Wars";

        // often asynchronous - example before is synchronous
        public IViewComponentResult Invoke()
        {
            ViewBag.WishListFilim = WishListFilim;
            return View();
        }
    }
}
