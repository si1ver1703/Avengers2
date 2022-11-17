using ADONETExample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Castle.Windsor;

namespace ADONETExample.Controllers
{

    public class HomeController : Controller
    {

        MyDBEntities db = new MyDBEntities();

        [ActionFilter]
        [ExceptionFilter]
        [ActionName("MainPage")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Results(string fName)
        {
            /*db.Customers.Where(x => x.FirstName.Contains(fName)).ToList();*/
            var searching = db.Avengers.Results(fName);

            return PartialView(searching);
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LinkResults()
        {
            /*var searching = db.Customers.Where(x => x.Company == ).First();*/

            ViewBag.Countries = db.Avengers.LinkResults();

            return PartialView();
        }

        public JsonResult SendAsJson(string name)
        {
            var searching = db.Avengers.SendAsJson(name);

            return Json(searching, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public ActionResult GetTable()
        {
            return View(db.Avengers.GetTable());
        }
    }
}