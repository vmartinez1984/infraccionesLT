using Infracciones.Dto;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Infracciones.Administracion.Controllers
{
    public class ArticuloController : Controller
    {
        // GET: Articulo
        public ActionResult Index(int? id)
        {
            List<Articulo> lista;

            lista = ArticuloBl.GetAll(id);
            
            return View(lista);
        }

        // GET: Articulo/Details/5
        public ActionResult Details(int id)
        {
            Articulo Articulo;

            Articulo = ArticuloBl.Get(id);
            ViewBag.ArticuloId = Articulo.Id;
            ViewBag.ListaDeFracciones = FraccionBl.GetAll(Articulo.Id);

            return View(Articulo);
        }

        // GET: Articulo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Articulo/Create
        [HttpPost]
        public ActionResult Create(Articulo Articulo)
        {
            if (Session["Usuario"] == null)
                return RedirectToAction("Login", "Home");

            try
            {
                Articulo.UsuarioIdAlta = (Session["Usuario"] as Usuario).Id;
                if (ModelState.IsValid)
                {
                    ArticuloBl.Add(Articulo);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(Articulo);
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: Articulo/Edit/5
        public ActionResult Edit(int id)
        {
            Articulo Articulo;

            Articulo = ArticuloBl.Get(id);

            return View(Articulo);
        }

        // POST: Articulo/Edit/5
        [HttpPost]
        public ActionResult Edit(Articulo Articulo)
        {
            if (Session["Usuario"] == null)
                return RedirectToAction("Login", "Home");

            try
            {
                if (ModelState.IsValid)
                {
                    ArticuloBl.Update(Articulo);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(Articulo);
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: Articulo/Delete/5
        public ActionResult Delete(int id)
        {
            if (Session["Usuario"] == null)
                return RedirectToAction("Login", "Home");

            Articulo Articulo;

            Articulo = ArticuloBl.Get(id);

            return View(Articulo);
        }

        // POST: Articulo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                if (Session["Usuario"] == null)
                    return RedirectToAction("Login", "Home");

                ArticuloBl.Delete(id, (Session["Usuario"] as Usuario).Id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
