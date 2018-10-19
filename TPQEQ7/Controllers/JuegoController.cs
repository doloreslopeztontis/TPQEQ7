using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TPQEQ7.Controllers
{
    public class JuegoController : Controller
    {
        // GET: Juego
        public ActionResult Index()
        {
            return View();
        }

        //Juego
        public ActionResult ComienzoJuego()
        {
            return View();
        }
    }
}