using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Cau2_NhaTro.Models
{
    public class ProvinceItem
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("districts")]
        public List<DistrictItem>? Districts { get; set; }

        [JsonPropertyName("wards")]
        public List<WardItem>? Wards { get; set; }

        public override string ToString() => Name;
    }

    public class DistrictItem
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("wards")]
        public List<WardItem>? Wards { get; set; }

        public override string ToString() => Name;
    }

    public class WardItem
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        public override string ToString() => Name;
    }
}
