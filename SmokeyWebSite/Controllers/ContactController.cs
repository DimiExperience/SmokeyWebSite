using SmokeyWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmokeyWebSite.Controllers;

namespace SmokeyWebSite.Controllers
{

    public class ContactController : Controller
    {
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(ContactViewModel model)
        {
            return View();
        }
	}
}