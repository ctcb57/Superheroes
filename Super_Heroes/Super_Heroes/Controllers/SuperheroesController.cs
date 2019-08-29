using Super_Heroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Super_Heroes.Controllers
{
    public class SuperheroesController : Controller
    {
        // GET: Superheroes
        ApplicationDbContext context;
        public SuperheroesController()
        {
            context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {

            return View(context.Superheroes);
        }

        // GET: Superheroes/Details/5
        public ActionResult Details(int id)
        {
            var superhero = context.Superheroes.FirstOrDefault(s => s.superheroId == id);
            return View(superhero);
        }

        // GET: Superheroes/Create
        public ActionResult Create()
        {
            Superheroes superheroes = new Superheroes();
            return View(superheroes);
        }

        // POST: Superheroes/Create
        [HttpPost]
        public ActionResult Create(Superheroes superheroes)
        {
            try
            {
                context.Superheroes.Add(superheroes);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Superheroes/Edit/5
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

        // GET: Superheroes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Superheroes/Delete/5
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
