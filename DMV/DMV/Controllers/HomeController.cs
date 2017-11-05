using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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
        public ActionResult driver()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult driver(driver c)
        {
            if(ModelState.IsValid)
            {
                using (Database1Entities dc = new Database1Entities())
                {
                    dc.driver.Add(c);
                    dc.SaveChanges();
                    ModelState.Clear();
                    c = null;
                    ViewBag.Message = "Successfully change address";
                }
            }
            return View(c);
        }
    }
}