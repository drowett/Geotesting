using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeographyTesting.MVC.Web.Models;

namespace GeographyTesting.MVC.Web.Controllers
{
    public class HomeController : Controller
    {
        readonly LocationContext context = new LocationContext();

        public ActionResult Index()
        {
            var model = context.Locations.ToList();

            return View(model);
        }
    }
}