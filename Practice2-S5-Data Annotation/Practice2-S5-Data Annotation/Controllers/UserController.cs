using Practice2_S5_Data_Annotation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice2_S5_Data_Annotation.Controllers
{
    public class UserController : Controller
    {
        private static List<UserModel> _users = new List<UserModel>();

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                UserModel user = new UserModel();
                user.IdNumber = Int32.Parse(collection["IdNumber"]);
                user.ConfirmPassword = collection["ConfirmPassword"];
                user.Email = collection["email"];
                user.Password = collection["password"];
                user.Name = collection["name"];
                _users.Add(user);

                return RedirectToAction("Details", new { id = user.IdNumber });
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Index()
        {
            return View(_users);
        }
        public ActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                UserModel user = _users.Find(_id => _id.IdNumber == id);
                return View(user);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}