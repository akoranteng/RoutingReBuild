namespace MinimalApiDemo.Models
{
    public class WeatherResponse


    {


        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double TemperatureC { get; set; }
        public double TemperatureF { get; set; }
        public string Condition { get; set; }
        public int Humidity { get; set; }
        public double WindKph { get; set; }
    }
}
