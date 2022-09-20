using Microsoft.AspNetCore.Mvc;
using SourceWebApi;

namespace JenkinsWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var list = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureCelsius = Random.Shared.Next(-20, 40),
            })
            .ToList();

            list.ForEach(wf => wf.Description = WeatherService.GetDescription(wf.TemperatureCelsius));
                
            return list;
        }
    }
}