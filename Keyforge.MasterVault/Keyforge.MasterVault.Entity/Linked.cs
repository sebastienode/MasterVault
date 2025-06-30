using System.Text.Json.Serialization;

namespace Keyforge.MasterVault.Entity
{
    public class Linked
    {
        [JsonPropertyName("houses")]
        public List<House> Houses { get; set; }

        [JsonPropertyName("accolades")]
        public List<Accolade> Accolades { get; set; }

        [JsonPropertyName("cards")]
        public List<Card> Cards { get; set; }

        [JsonPropertyName("notes")]
        public List<Note> Notes { get; set; }
    }
}
