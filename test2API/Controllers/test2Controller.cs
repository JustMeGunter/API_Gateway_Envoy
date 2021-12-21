using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace test2API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class test2Controller : ControllerBase
    {
        private static readonly string[] test2 = new[]
        {
            "prueba1test2", "prueba2test2", "prueba3test2", "prueba4test2"
        };

        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();

            return Ok(test2[rng.Next(test2.Length)]);
        }
    }
}