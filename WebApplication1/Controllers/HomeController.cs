﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Inicial()
        {
            return View();
        }
        public ActionResult Servicos()
        {
            return View();
        }
        public ActionResult QuemSomos()
        {
            return View();
        }
        public ActionResult Parceiros()
        {
            return View();
        }

    }
}