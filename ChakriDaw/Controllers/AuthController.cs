using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChakriDaw.ViewModel;
using ChakriDaw.ViewModels;

namespace ChakriDaw.Controllers
{
    public class AuthController : Controller
    {
        ChakriChaiDBEntities context = new ChakriChaiDBEntities();
        public ActionResult Login()
        {
            Login l = new Login();
            return View(l);
        }

        [HttpPost]
        public ActionResult Login(Login l)
        {
            if (ModelState.IsValid) {
                var user = context.Users
                    .Where(u => u.Email == l.Email && u.Password == l.Password)
                    .FirstOrDefault();

                if (user != null) {
                    return Redirect("/Home/Index");
                } 

                TempData["ErrMsg"] = "Username or Password doesn't match!";
                return View(l);
            }
            return View(l);
        }

        public ActionResult Register()
        {
            User u = new User();
            return View(u);
        }

        [HttpPost]
        public ActionResult Register(User u)
        {
            if (ModelState.IsValid) {
                // TODO: Verify if role is correct

                // Check if email exists
                var user = context.Users.Where(x => x.Email == u.Email).FirstOrDefault();

                if (user != null) {
                    TempData["ErrMsg"] = "Email already exists!";
                    return View(u);
                }


                // Then add to DB
                u.Status = "Inactive";
                context.Users.Add(u);
                context.SaveChanges();
                return Redirect("/Home/Index");
            }
            return View(u);
        }
    }
}