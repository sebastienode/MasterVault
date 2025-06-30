using System.Text.Json.Serialization;

namespace Keyforge.MasterVault.Entity
{
    public class SetEraCards
    {
        [JsonPropertyName("Legacy")]
        public List<Guid> Legacy { get; set; }

        [JsonPropertyName("Anomaly")]
        public List<Guid> Anomaly { get; set; }

        [JsonPropertyName("Mixed Set")]
        public List<Guid> MixedSet { get; set; }
    }
}
