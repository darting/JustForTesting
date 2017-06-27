using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JustForTesting.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IDictionary Index()
        {
            return Environment.GetEnvironmentVariables();
        }

        [HttpGet("/Echo/{echo}")]
        public string Echo(string echo)
        {
            return echo;
        }
    }
}
