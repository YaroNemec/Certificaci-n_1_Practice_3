using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {

        public StudentsController(ILogger<StudentsController> logger)
        {
        }


        [HttpGet]
        public List<Student> GetStudent()
        {
            return new List<Student>();
            
        }
        [HttpPost]
        public Student CreateStudent([FromBody] string studentName)
        {
            return new Student()
            {
                NameStudent = studentName
            };
        }

        [HttpPut]
        public Student UpdateStudent([FromBody] Student estudiante)
        {
            estudiante.NameStudent = "updated";
            return estudiante;
        }

        [HttpDelete]
        public Student DeleteStudent([FromBody] Student estudiante)
        {
            return estudiante;
        }
    }
}
