using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            TempData["Name"] = "Bui Van Trung";
            TempData["Age"] = 23;
            TempData["Address"] = "Ha Noi,VietNam";
            return View("ShowData");
        }

        public ActionResult ShowData()
        {
            return View();
        }
    }
}