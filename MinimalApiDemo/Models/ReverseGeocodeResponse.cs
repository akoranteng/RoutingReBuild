using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MinimalApiDemo.Models
{
    public class ReverseGeocodeResponse
    {
        [JsonPropertyName("results")]
        public List<ReverseGeocodeResult> Results { get; set; }
    }

    public class ReverseGeocodeResult
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("admin1")]
        public string Admin1 { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
