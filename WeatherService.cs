
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApi{
    public class WeatherService
    {

        private readonly HttpClient _httpClient;
        private readonly string _apiKey = ""; // OpenWeatherMap API Anahtarı

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetWeatherAsync(string city)
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city},&APPID={_apiKey}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return content; // Bu noktada dönen içeriği JSON olarak döndürüyoruz, dönüş tipini ve işlemleri ihtiyaca göre ayarlanabilir.
        }

    }
}
