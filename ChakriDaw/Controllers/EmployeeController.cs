using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChakriDaw.ViewModels;
using ChakriDaw.Model;


namespace ChakriDaw.Controllers
{
    public class EmployeeController : Controller
    {
        ChakriChaiDBEntities context = new ChakriChaiDBEntities();
        public ActionResult AddInformation()
        {
            return View();
        }
        public ActionResult Index()
        {
            
            List<User> UserName = context.Users.ToList();
            //List<User> UserId = context.Users.ToList();
            List<Exam> ExamName = context.Exams.ToList();
            List<Board> BoardName = context.Boards.ToList();
            List<Academic> InstitueName = context.Academics.ToList();
            List<Academic> PassedYear = context.Academics.ToList();
            List<Academic> Skill = context.Academics.ToList();

            var employeemultipleclass = from ac in InstitueName
                                        join ex in ExamName on ac.ExamId equals ex.Id into table1
                                        from ex in table1.DefaultIfEmpty()
                                        join un in UserName on ac.EmployeeId equals un.Id into table2
                                        from un in table2.DefaultIfEmpty()
                                        join b in BoardName on ac.BoardId equals b.Id into table3
                                        from b in table3.DefaultIfEmpty()
                                        select new EmployeeMultipleClass { AcademicDetails = ac, ExamDetails = ex, BoardDetails = b, UserDetails=un };



            return View(employeemultipleclass);
        }

    }
}