﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BedAppManage.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult List()
        {
            return View();
        }
    }
}