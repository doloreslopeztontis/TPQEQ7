using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPQEQ7.Models;

namespace TPQEQ7.Controllers
{
    public class BackofficeController : Controller
    {
        // GET: Backoffice
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MenuBackoffice()
        {
            return View();
        }
        //ABML: Lopez Joffre

        public ActionResult ABMLCaracteristicas()
        {
            return View();
        }

        public ActionResult ABMLCategorias()
        {
            return View();
        }

        public ActionResult ABMLPersonajes()
        {
            return View();
        }

        public ActionResult ListaPersonajes(string Categoria = "todos")
        {
            ViewBag.Personajes = QEQ.ListarPersonajes(Categoria);
            return View();
        }
    }
}