using MinimalApiDemo.Models;

public class WeatherService
{
    public Task<WeatherResponse> GetWeatherAsync(double lat, double lon)
    {
        var result = new WeatherResponse
        {
            Latitude = lat,
            Longitude = lon,
            TemperatureC = 18,
            TemperatureF = Math.Round((18 * 9.0 / 5.0) + 32, 1),
            Condition = "Cloudy",
            Humidity = 55,
            WindKph = 8
        };

        return Task.FromResult(result);
    }
}
