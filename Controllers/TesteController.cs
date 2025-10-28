using CursoInfoeste.Models;
using Microsoft.AspNetCore.Mvc;

namespace CursoInfoeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<ActionResult<Tenant>> Create()
        {
            return Ok(new Tenant { Id = 1, Name = "Tenant 1" });
        }
    }
}
