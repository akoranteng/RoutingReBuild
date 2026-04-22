using System.Text.Json.Serialization;

namespace MinimalApiDemo.Models
{
    public class ForecastResponse
    {
        [JsonPropertyName("daily")]
        public DailyForecastData Daily { get; set; }
    }

    public class DailyForecastData
    {
        [JsonPropertyName("time")]
        public List<string> Dates { get; set; }

        [JsonPropertyName("temperature_2m_max")]
        public List<double> MaxTemps { get; set; }

        [JsonPropertyName("temperature_2m_min")]
        public List<double> MinTemps { get; set; }

        [JsonPropertyName("precipitation_sum")]
        public List<double> PrecipMm { get; set; }
    }

    public class DailyForecast
    {
        public string Date { get; set; }
        public double HighC { get; set; }
        public double LowC { get; set; }
        public double PrecipMm { get; set; }
    }
}
