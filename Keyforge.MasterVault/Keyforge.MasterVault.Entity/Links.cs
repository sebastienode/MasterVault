using System.Text.Json.Serialization;

namespace Keyforge.MasterVault.Entity
{
    public class Links
    {
        [JsonPropertyName("houses")]
        public List<string> Houses { get; set; }

        [JsonPropertyName("accolades")]
        public List<Guid> Accolades { get; set; }

        [JsonPropertyName("cards")]
        public List<Guid> Cards { get; set; }

        [JsonPropertyName("notes")]
        public List<Guid> Notes { get; set; }
    }


}
