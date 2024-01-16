using Microsoft.AspNetCore.Mvc;

namespace Test2.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            return Ok("Test2.Api");
        }
    }
}