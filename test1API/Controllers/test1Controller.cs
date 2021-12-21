using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace test1API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class test1Controller : ControllerBase
    {
        private static readonly string[] test1 = new[]
        {
            "prueba1test1", "prueba2test1", "prueba3test1", "prueba4test1"
        };

        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();

            return Ok(test1[rng.Next(test1.Length)]);
        }
    }
}