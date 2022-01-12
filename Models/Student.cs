using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace school.Models
{
    public class Student
    {
        public int Id;
        public string Fname;
        public string Lname;
        public int SchoolClass;
        public int Age;

        public Student(int id, string fname, string lname, int schoolClass, int age)
        {
            this.Id = id;
            this.Fname = fname;
            this.Lname = lname;
            this.SchoolClass = schoolClass;
            this.Age = age;
        }
    }
}