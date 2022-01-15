using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChakriDaw.ViewModels;

namespace ChakriDaw.Model
{
    public class EmployeeMultipleClass
    {
        public Employee EmployeeDetails { get; set; }
        public User UserDetails { get; set; }

        public Exam ExamDetails { get; set; }
        public Board BoardDetails { get; set; }
        public Academic AcademicDetails { get; set; }

    }
}