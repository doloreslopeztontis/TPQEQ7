using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPQEQ7.Models;

namespace TPQEQ7.Controllers
{
    public class LoginRegistroController : Controller
    {
        // GET: LoginRegistro
        
        //Login: Haber
        [HttpPost]

        public ActionResult Login(string Usuario = "", string Contraseña = "")
        {
            if (Usuario == "" && Contraseña == "")
            {
                return View();
            }
            else
            {
                bool Existe = QEQ.ExisteUsuario(Usuario, Contraseña);
                Usuario USER = QEQ.TraerUsuario(Usuario, Contraseña);
                Session["Usuario"] = USER;
                if (Existe == false)
                {
                    return RedirectToAction("Registro", "LoginRegistro");
                }
                else
                {
                    if (USER.Perfil == true) //true=admin
                    {
                        return RedirectToAction("MenuBackoffice", "Backoffice");
                    }
                    else
                    {
                        return RedirectToAction("ComienzoJuego", "Juego");
                    }
                }
            }
        }
    }
}