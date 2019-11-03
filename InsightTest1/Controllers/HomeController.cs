using InsightTest1.Context;
using InsightTest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsightTest1.Controllers
{
    public class HomeController : Controller
    {
        ActivityContext db = new ActivityContext();
        public ActionResult Index()
        {
            Login obj = new Login();
            return View(obj);
        }

        [HttpPost]
        public ActionResult Index(Login objlogin)
        {
            Login loginobj = new Login()
            {
                UserName = objlogin.UserName,
                UserPassword = objlogin.UserPassword,              
            };
            db.Login.Add(loginobj);
            db.SaveChanges();
            return View(objlogin);
        }
        [HttpPost]
        public ActionResult Login(Login objlogin)
        {
            var userlist = db.Login.ToList();
            var display = userlist.Where(m => m.UserName == objlogin.UserName && m.UserPassword == objlogin.UserPassword).FirstOrDefault();
            ViewBag.Status = display != null ? "CORRECT UserName and Password" : "INCORRECT UserName or Password";          
            return View(objlogin);
        }
    }

}
 
