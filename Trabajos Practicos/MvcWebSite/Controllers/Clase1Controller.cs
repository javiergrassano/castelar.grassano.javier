﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML.WebSite.Controllers
{
    public class Clase1Controller : Controller
    {
        public Clase1Controller()
        {
            ViewBag.menu = "CLASE1";
        }

        // GET: Clase1
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult TP1()
        {
            return View();
        }

        public ActionResult TP2()
        {
            return View();
        }

        public ActionResult TP3()
        {
            return View();
        }

        public ActionResult TP4()
        {
            return View();
        }

        public ActionResult TP5()
        {
            return View();
        }

        public ActionResult TP6()
        {
            return View();
        }

        public ActionResult TP7()
        {
            return View();
        }

    }
}