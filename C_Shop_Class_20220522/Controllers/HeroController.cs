using C_Shop_Class_20220522.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C_Shop_Class_20220522.Controllers
{
    public class HeroController : Controller
    {

        private static List<Hero> _heroes = new List<Hero>()
        {
            new Hero(){Id = 1, Name = "鋼鐵人", Atk = 50, Hp = 100},
            new Hero(){Id = 2, Name = "索爾", Atk = 50, Hp = 100}
        };
        // GET: HeroController
        public ActionResult Index()
        {
            var heroes = _heroes.ToList();
            return View(heroes);
        }

        // GET: HeroController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HeroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HeroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hero model)
        {
            try
            {
                _heroes.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HeroController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HeroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HeroController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HeroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
