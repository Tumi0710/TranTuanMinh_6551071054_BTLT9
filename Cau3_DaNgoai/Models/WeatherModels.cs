using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Cau3_DaNgoai.Models
{
    public class GeoSearchResult
    {
        [JsonPropertyName("results")]
        public List<GeoLocation>? Results { get; set; }
    }

    public class GeoLocation
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("country")]
        public string? Country { get; set; }
    }

    public class WeatherForecastResponse
    {
        [JsonPropertyName("daily")]
        public DailyForecastData? Daily { get; set; }
    }

    public class DailyForecastData
    {
        [JsonPropertyName("time")]
        public List<string>? Time { get; set; }

        [JsonPropertyName("weather_code")]
        public List<int>? WeatherCode { get; set; }

        [JsonPropertyName("temperature_2m_max")]
        public List<double>? Temperature2mMax { get; set; }

        [JsonPropertyName("temperature_2m_min")]
        public List<double>? Temperature2mMin { get; set; }

        [JsonPropertyName("precipitation_probability_max")]
        public List<int>? PrecipitationProbabilityMax { get; set; }
    }
}
