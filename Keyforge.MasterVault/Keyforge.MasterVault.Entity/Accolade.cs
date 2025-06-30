using System.Text.Json.Serialization;

namespace Keyforge.MasterVault.Entity
{
    public class Accolade
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("visible")]
        public bool Visible { get; set; }
    }
}
