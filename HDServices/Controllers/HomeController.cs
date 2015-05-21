using HDServices.DAL;
using HDServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HDServices.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //using (var context = new DALContext())
            //{
            //    Page page = new Page();
            //    page.Title = "news title";

            //    context.Pages.Create(page);
            //}

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
