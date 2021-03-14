using Infracciones.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Infracciones.Administracion.Controllers
{
    public class FraccionController : Controller
    {
        // GET: Fraccion
        public ActionResult Index()
        {
            return View();
        }

        // GET: Fraccion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Fraccion/Create/{articuloId}
        public ActionResult Create(int id)
        {
            ViewBag.Articulo = ArticuloBl.Get(id);

            return View();
        }

        // POST: Fraccion/Create
        [HttpPost]
        public ActionResult Create(Fraccion fraccion)
        {
            try
            {
                if (Session["Usuario"] == null)
                    return RedirectToAction("Login", "Home");

                fraccion.UsuarioIdAlta = (Session["Usuario"] as Usuario).Id;
                if (ModelState.IsValid)
                {
                    FraccionBl.Add(fraccion);
                    return RedirectToAction($"Details/{fraccion.ArticuloId}","Articulo");
                }
                else
                {
                    ViewBag.Articulo = ArticuloBl.Get(fraccion.ArticuloId);
                    return View();
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: Fraccion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Fraccion/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Fraccion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Fraccion/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
