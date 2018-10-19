using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TPQEQ7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        //Inicio: Ramis
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Instrucciones()
        {
            return View();
        }
    }
}