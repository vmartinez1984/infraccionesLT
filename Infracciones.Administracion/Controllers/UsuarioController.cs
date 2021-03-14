using Infracciones.BusinessLayer;
using Infracciones.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Infracciones.Administracion.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index(int? id)
        {
            if (Session["Usuario"] == null)
                return RedirectToAction("Login", "Home");

            List<Usuario> lista;

            lista = UsuarioBl.GetAll(id);

            return View(lista);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            if (Session["Usuario"] == null)
                return RedirectToAction("Login", "Home");

            Usuario usuario;

            usuario = UsuarioBl.Get(id);

            return View(usuario);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            if (Session["Usuario"] == null)
                return RedirectToAction("Login", "Home");

            ViewBag.ListaDePerfiles = UsuarioBl.GetAllPerfiles();

            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {
            if (Session["Usuario"] == null)
                return RedirectToAction("Login", "Home");

            try
            {
                usuario.UsuarioIdAlta = (Session["Usuario"] as Usuario).Id;
                if (ModelState.IsValid)
                {
                    UsuarioBl.Add(usuario);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(usuario);
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            if (Session["Usuario"] == null)
                return RedirectToAction("Login", "Home");

            Usuario usuario;

            ViewBag.ListaDePerfiles = UsuarioBl.GetAllPerfiles();
            usuario = UsuarioBl.Get(id);

            return View(usuario);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(Usuario usuario)
        {
            if (Session["Usuario"] == null)
                return RedirectToAction("Login", "Home");

            try
            {
                if (ModelState.IsValid)
                {
                    UsuarioBl.Update(usuario);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(usuario);
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            if (Session["Usuario"] == null)
                return RedirectToAction("Login", "Home");

            Usuario usuario;

            usuario = UsuarioBl.Get(id);

            return View(usuario);
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                if (Session["Usuario"] == null)
                    return RedirectToAction("Login", "Home");

                UsuarioBl.Delete(id, (Session["Usuario"] as Usuario).Id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult IniciarSesion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IniciarSesion(UsuarioDeInicioDeSesion usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Usuario usuario1;

                    usuario1 = UsuarioBl.Get(usuario.Usuario, usuario.Contrasenia);
                    //if(usuario1 is null)
                    //{

                    //}
                    return View();
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {

                return View();
            }



        }
    }
}
