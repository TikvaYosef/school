using school.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace school.Controllers.API
{
    public class StudentController : Controller
    {

        Student[] arrayOfStudent = new Student[] {
       new Student(0,"tikva","yosef",12,26),
       new Student(1,"keren","hailu",11,23),
       new Student(2,"eden","tasama",9,24),
       new Student(3,"yafit","samuel",8,22)
        };

        // GET: Student
        public ActionResult ShowStudentById(int id)
        {
            foreach (Student item in arrayOfStudent)
            {
                if (id == item.Id)
                {
                    ViewBag.student1 = item;

                }

            }

            return View(ViewBag.student1);

        }

        // GET: Students
        public ActionResult ShowStudents()
        {
            return View(arrayOfStudent);
        }

        public ActionResult ShowStudentName()
        {
            foreach (Student item in arrayOfStudent)
            {
              
                
                    ViewBag.name = item;

                

            }
            return View(ViewBag.name);
        }

    }
}