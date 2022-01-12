using school.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace school.Controllers.API
{
    public class StudenttController : ApiController
    {
        List<Student> listOfStudents = new List<Student> {
       new Student(0,"tikva","yosef",12,26),
       new Student(1,"keren","hailu",11,23),
       new Student(2,"eden","tasama",9,24),
       new Student(3,"yafit","samuel",8,22)
        };



        // GET: api/Studentt
        public IHttpActionResult Get()
        {

            return Ok(new { listOfStudents });
        }

        // GET: api/Studentt/3
        public IHttpActionResult Get(int id)
        {
            Student student1 = listOfStudents.First((item) => id == item.Id );
           return Ok(new { student1 });
        }

        // POST: api/Studentt
        public IHttpActionResult Post([FromBody] Student obj)
        {
            listOfStudents.Add(obj);
            return Ok(new { listOfStudents });
        }

        // PUT: api/Studentt/5
        public void Put(int id, [FromBody] string value)
        {
            
        }

        // DELETE: api/Studentt/5
        public void Delete(int id)
        {
            foreach (var item in collection)
            {

            }
        }
    }
}
