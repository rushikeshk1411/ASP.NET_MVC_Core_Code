﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDataTransfer.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index1()
        {
            return View();
        }
        public ViewResult Display1()
        {
            return View();
        }
    }
}