using Microsoft.AspNetCore.Mvc;

namespace CICDDemo.Controllers
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

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("Test1")]
        public IActionResult Get1()
        {
            return Ok("Test 1");
        }

        [HttpGet("Test2")]
        public IActionResult Get2()
        {
            return Ok("Test 2");
        }

        [HttpGet("Test3")]
        public IActionResult Get3()
        {
            return Ok("Test 3");
        }

        [HttpGet("Test4")]
        public IActionResult Get4()
        {
            return Ok("Test 4");
        }
    }
}
