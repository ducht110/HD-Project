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

            using (var ctx = new HDContext())
            {
                //Student stud = new Student() { LastName = "Student", FirstMidName = "Đức", EnrollmentDate = DateTime.Parse("2005-09-01") };

                //ctx.Students.Add(stud);

                //Teacher te = new Teacher() { LastName = "Student", FirstMidName = "Đức", TeacherCode ="123", ClassID= "12a"};

                //ctx.Students.Add(stud);
                //ctx.Teachers.Add(te);
                //ctx.SaveChanges();
            }

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
