using C_Shop_Class_20220522.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C_Shop_Class_20220522.Controllers
{
    public class FamilyController : Controller
    {
        private static List<Family> families = new List<Family>()
            {
            new Family(){ Name="張曉明", Title="爸爸", Id=1, Age=55, NickName="大張" },
            new Family(){ Name="黃小鴨", Title="媽媽", Id=2, Age=50, NickName="大黃" },
            new Family(){ Name="張非", Title="本人", Id=3, Age=18, NickName="小張" },
            new Family(){ Name="張胡", Title="弟弟", Id=4, Age=8, NickName="小小張" },
            };
        // GET: FamilyController
        public ActionResult Index()
        {
            var result = new FamilyInfo(families);
            return View(result._familyList);
        }

        // GET: FamilyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FamilyController/Create
        public ActionResult Create()
        {
            var Info = new FamilyInfo(families);
            Info.FamilyDetail(false, null);
            return View(Info.family);
        }

        // POST: FamilyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Family submit)
        {
            try
            {
                var family = new FamilyInfo(families);
                family.FamilyDetail(true, submit);
                families.Add(family.family);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FamilyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FamilyController/Edit/5
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

        // GET: FamilyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FamilyController/Delete/5
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
