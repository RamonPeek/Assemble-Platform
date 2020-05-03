using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_Managers.Interfaces;
using _5_Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace _1_View.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        private readonly ICharacterManager CharacterManager;

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> GetAsync()
        {
            var rng = new Random();
            Character character = await CharacterManager.GetCharacterByName("Spider-man");

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [ActivatorUtilitiesConstructor]
        public WeatherForecastController(ICharacterManager characterManager)
        {
            this.CharacterManager = characterManager;
        }
    }
}
