using Obligatorio.ServicioWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Obligatorio.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AltaUsuario(string Email, string Password)
        {
            bool resultado = false;
            ServicioClient proxy = new ServicioClient();
            if (Email != "" && Password != "")
            {
                DtoUsuario usr = new DtoUsuario()
                {
                    Email = Email,
                    Password = Password
                };

                resultado =proxy.InsertarUsuario(usr);
                proxy.Close();
            }
            ViewBag.resultado = resultado.ToString();
            return View();

        }


    }
}