﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HDMvcWebsite.Areas.Admin.Controllers
{
    public class ManageAccountController : Controller
    {
        // GET: Admin/ManageAccount
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}