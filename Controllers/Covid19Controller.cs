using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hibird_Theory_Backend.Models;
using Hibird_Theory_Backend.Interfaces;
using System.Web;
using System.IO;
using Newtonsoft.Json;

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
        private readonly ICalculationService _calculation;

        public Covid19Controller(ILogger<Covid19Controller> logger, ICalculationService calculation)
        {
            _logger = logger;
            _calculation = calculation;
        }

        [HttpGet]
        public ActionResult<List<EconIndicator>> Pizza()
        {
            var finalResult = JsonConvert.DeserializeObject<List<EconIndicator>>(System.IO.File.ReadAllText("dynamic.json"));;
            return Ok(finalResult);
        }

        [HttpPost]
        public ActionResult<int> GetCalculation(int pizzaCommitments)
        {
            var value = _calculation.Calculation(pizzaCommitments);
            return Ok(value);
        }
    }
}