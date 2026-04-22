using System.Net.Http.Json;
using MinimalApiDemo.Models;

namespace MinimalApiDemo.Services
{
    public class ReverseGeocodingService
    {
        private readonly HttpClient _http;

        public ReverseGeocodingService(HttpClient http)
        {
            _http = http;
        }

        public async Task<(string City, string State, string Country)> LookupAsync(double lat, double lon)
        {
            var url = $"https://geocoding-api.open-meteo.com/v1/reverse?latitude={lat}&longitude={lon}";

            var response = await _http.GetFromJsonAsync<ReverseGeocodeResponse>(url);

            var result = response?.Results?.FirstOrDefault();

            if (result == null)
                return ("Unknown", "Unknown", "Unknown");

            return (result.Name, result.Admin1, result.Country);
        }
    }
}
