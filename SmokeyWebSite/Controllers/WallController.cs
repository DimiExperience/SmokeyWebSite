using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using SmokeyWebSite.Models;

namespace SmokeyWebSite.Controllers
{
    public class WallController : Controller
    {
        public ActionResult Wall()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Wall(WallModel model)
        {
            ViewBag.MessageName = model.Name;
            ViewBag.MessageEmailAdress = model.EmailAdress;
            ViewBag.MessagePost = model.Post;
            ViewBag.CurrentTime = DateTime.UtcNow;

            

            //e sada, kako da storujem model u database??????

            return View();
        }
        
    }
}