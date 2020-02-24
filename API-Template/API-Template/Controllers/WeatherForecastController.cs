using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API_Template.Controllers
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

        [HttpGet("{zipCode}")]
        public WeatherForecast Get(int zipCode)
        {


            var dateString = "02/24/2020 07:00 PM";
            var culture = CultureInfo.CreateSpecificCulture("en-US");
            var styles = DateTimeStyles.None;
            var rng = new Random();
            var rInt = rng.Next(-20, 50);
            return new WeatherForecast
            {
                Date = DateTime.Parse(dateString, culture, styles),
                TemperatureC = rInt,
                Summary = "Sunny"
            };
        }

        public WeatherForecast Get()
        {
            var dateString = "02/24/2020 07:00 PM";
            var culture = CultureInfo.CreateSpecificCulture("en-US");
            var styles = DateTimeStyles.None;
            var rng = new Random();
            return new WeatherForecast
            {
                Date = DateTime.Parse(dateString, culture, styles),
                TemperatureC = 14,
                Summary = "Sunny"
            };
        }
    }
}
