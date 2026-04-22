using MinimalApiDemo.Models;
using System.Net.Http.Json;

namespace MinimalApiDemo.Services
{
    public class ForecastService
    {
        private readonly HttpClient _http;

        public ForecastService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<DailyForecast>> GetForecastAsync(double lat, double lon)
        {
            var url =
                $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}" +
                $"&daily=temperature_2m_max,temperature_2m_min,precipitation_sum&timezone=auto";

            var response = await _http.GetFromJsonAsync<ForecastResponse>(url);

            if (response?.Daily == null)
                return new List<DailyForecast>();

            var result = new List<DailyForecast>();

            for (int i = 0; i < response.Daily.Dates.Count; i++)
            {
                result.Add(new DailyForecast
                {
                    Date = response.Daily.Dates[i],
                    HighC = response.Daily.MaxTemps[i],
                    LowC = response.Daily.MinTemps[i],
                    PrecipMm = response.Daily.PrecipMm[i]
                });
            }

            return result;
        }
    }
}
