using Flights.ReadModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Flights.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightController : ControllerBase
    {
        private readonly ILogger<FlightController> _logger;

        public FlightController(ILogger<FlightController> logger)
        {
            _logger = logger;
        }

        Random random = new Random();

        [HttpGet]
        public IEnumerable<FlightRm> Search()
            => new FlightRm[]
            {
                new ( Guid.NewGuid(),
                "Deutsche BA",
                random.Next (90, 5000).ToString(),
                new TimePlaceRm("Munchen", DateTime.Now.AddHours (random.Next(1, 10))),
                new TimePlaceRm("Schiphol", DateTime.Now.AddHours (random.Next (4, 15))), 
                random.Next(1, 853)),

                new ( Guid.NewGuid(),
                "AB Corporate Aviation",
                random.Next (90, 5000).ToString(),
                new TimePlaceRm("Le Bourget", DateTime.Now.AddHours (random.Next(1, 24))),
                new TimePlaceRm("Zagreb", DateTime.Now.AddHours (random.Next (4, 25))),
                random.Next(1, 853)),

                 new ( Guid.NewGuid(),
                "ABA Air",
                random.Next (90, 5000).ToString(),
                new TimePlaceRm("Praha Ruzyne", DateTime.Now.AddHours (random.Next(1, 13))),
                new TimePlaceRm("Paris", DateTime.Now.AddHours (random.Next (4, 34))),
                random.Next(1, 853)),
             };
        
    }
}