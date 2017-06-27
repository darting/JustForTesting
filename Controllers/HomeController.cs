using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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

        [HttpGet("/Headers")]
        public IDictionary Headers()
        {
            var headers = HttpContext.Request.Headers;
            var dict = new Dictionary<string, string>();
            foreach(var item in headers) {
                dict[item.Key] = item.Value;
            }
            return dict;
        }

        [HttpGet("/Echo/{echo}")]
        public string Echo(string echo)
        {
            return echo;
        }
    }
}
