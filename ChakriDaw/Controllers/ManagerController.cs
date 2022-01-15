using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChakriDaw.ViewModels;
using ChakriDaw.Model;
using ChakriDaw.ViewModel;
namespace ChakriDaw.Controllers
{
    public class ManagerController : Controller
    {
        ChakriChaiDBEntities context = new ChakriChaiDBEntities();
        public ActionResult Index()
        {
            //var jobpost = context.JobPosts.ToList();

            return View();
        }

        public ActionResult SeeUserInfo()
        {
            var userinfo = context.Users.ToList();
            return View(userinfo);
        }

        public ActionResult SeeAllJobPosts()
        {
            var jobpost = context.JobPosts.ToList();
            return View(jobpost);
        }

        public ActionResult ViewManagerProfile()
        {
            int Id = 1;
            var p = context.Users.FirstOrDefault(e => e.Id == Id);
            return View(p);
        }

        public ActionResult EditManagerProfile()
        {
            int Id = 1;
            var p = context.Users.FirstOrDefault(e => e.Id == Id);
            return View(p);

        }
        /*[HttpPost]
        public ActionResult EditManagerProfile(User p )
        {

            var oldp = context.Users.FirstOrDefault(e => e.Id == p.Id);
            oldp.Name = p.Name;
            context.Entry(oldp).State =ModelState.
            context.SaveChanges
        }*/
    }
}