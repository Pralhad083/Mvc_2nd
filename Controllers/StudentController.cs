using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_2nd.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Submit(int id, string name)
        {
            ViewBag.Id = id;
            ViewBag.Name = name;
            return View("Index");
        }

        public ActionResult ByPost()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Display(FormCollection fc)
        {
            ViewBag.Id =fc["id"];
            ViewBag.Name = fc["name"];
            return View("ByPost");
        }

    }
}