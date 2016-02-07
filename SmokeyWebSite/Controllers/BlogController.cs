using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmokeyWebSite.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Blog()
        {
            return View();
        }
	}
}