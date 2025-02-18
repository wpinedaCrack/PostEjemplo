using Microsoft.AspNetCore.Mvc;
using POS.Application.Interfaces;
using POS.Infraestructure.Commons.Bases.Request;

namespace POS.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IPersonaApplication _app;
        private readonly ILogger<WeatherForecastController> _logger;


        public WeatherForecastController(ILogger<WeatherForecastController> logger, IPersonaApplication app)
        { 
            _app = app;
            _logger = logger;
        }


        //[HttpGet("ListSelectCategories")]
        //public async Task<IActionResult> ListSelectCategories()
        //{
        //    var result = await _app.ListPersonas();
        //    //if (result.IsSuccess)
        //    //{
        //        return Ok(result);
        //   // }
        //    //return BadRequest(result);
        //}

        [HttpGet("ListPersonas")]
        public async Task<IActionResult> ListPersonas([FromQuery] BaseFiltersRequest filters)
        {
            var result = await _app.ListPersonas(filters);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

      
      

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
    }
}
