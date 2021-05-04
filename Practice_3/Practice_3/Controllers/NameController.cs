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
    [Route("/api/info")]
    public class NameController : ControllerBase
    {
        private readonly IConfiguration _config;

        public NameController(IConfiguration config)
        {
            _config = config;
        }


        [HttpGet]
        public String GetInfo()//Devuelve Proyect title y el environment name from settings 
        {
            string projectTitle = _config.GetSection("Project").GetSection("Title").Value;
            string dbConnection = _config.GetConnectionString("Database");
            Console.WriteLine($"We are connecting to...{dbConnection}");
            String info = $"From enc: {projectTitle} ";

            return info;

        }
    }
}
