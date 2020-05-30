using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hibird_Theory_Backend.Models;
using System.Web;

namespace Hibird_Theory_Backend.Controllers
{
    [Route("api/Covid19")]
    [ApiController]
    //[Route("[controller]")]
    public class Covid19Controller : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<Covid19Controller> _logger;

        public Covid19Controller(ILogger<Covid19Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<List<CovidData>> Pizza([FromBody]UserLocation location)
        {
            var result = new List<CovidData>();
            var before = new CovidData{
                Time = "BeforeCovid19",
                Amount = 30000
            };
            var after = new CovidData {
                Time = "AfterCovid19",
                Amount = 10000
            };
            result.Add(before);
            result.Add(after);
            return Ok(result);
        }
    }
}