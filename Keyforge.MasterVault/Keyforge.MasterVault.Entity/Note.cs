using System.Text.Json.Serialization;

namespace Keyforge.MasterVault.Entity
{
    public class Note
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("created_timestamp")]
        public int CreatedTimestamp { get; set; }
    }


}
