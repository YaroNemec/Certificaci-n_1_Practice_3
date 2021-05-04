using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace Practice_3.Controllers
{
    [ApiController]
    [Route("/api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly IConfiguration _config;
        public StudentsController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public List<Student> GetStudent()
        {
            string dbConnection = _config.GetConnectionString("Database");
            Console.WriteLine($"We are connecting to...{dbConnection}");
            return new List<Student>() {
            new Student() { NameStudent = $"Mauricio" },
            new Student() { NameStudent = $"Pedro" },
            new Student() { NameStudent = $"Camii" }
            };

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
