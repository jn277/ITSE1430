﻿/*
 * ITSE 1430
 * Donald Helaire
 * Lab5
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharacterRoster.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About() => View();
        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

            //return View();
        //}
    }
}