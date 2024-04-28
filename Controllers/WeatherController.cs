using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WeatherApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly WeatherService _weatherService;
        public WeatherController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }
        [HttpGet("{city}")]
        public async Task<IActionResult> GetWeather(string city)
        {
            try
            {
                var weather = await _weatherService.GetWeatherAsync(city);
                return Ok(weather); // Dönen JSON içeriği doğrudan döndürülüyor.
            }
            catch (HttpRequestException)
            {
                return NotFound();
            }
        }

    }
}
