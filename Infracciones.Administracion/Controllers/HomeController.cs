using Infracciones.BusinessLayer;
using Infracciones.Dto;
using System;
using System.Web.Mvc;

namespace Infracciones.Administracion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //if (Session["Usuario"] == null)
            //{
            //    return RedirectToAction("IniciarSesion", "Usuario");
            //}
            //else
            //{
                return View();
            //}
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {

            try
            {
                Usuario usuario;

                usuario = UsuarioBl.Get(collection["Usuario"], collection["Contrasenia"]);
                if (usuario is null)
                {
                    usuario = new Usuario();
                    ViewBag.Error = "Usuario y/o contraseña no validos";

                    return View("Index", new UsuarioDeInicioDeSesion { Usuario = collection["Usuario"], Contrasenia = collection["Contrasenia"] });
                }
                else
                {
                    Session["Usuario"] = usuario;

                    return View("Main");
                }

            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        public ActionResult Main()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}