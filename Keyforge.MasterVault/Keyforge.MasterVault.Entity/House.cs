using System.Text.Json.Serialization;

namespace Keyforge.MasterVault.Entity
{
    public class House
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("in_filters")]
        public bool InFilters { get; set; }
    }


}
