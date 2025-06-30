using System.Text.Json.Serialization;

namespace Keyforge.MasterVault.Entity
{
    public class MyDeckPage
    {
        [JsonPropertyName("data")]
        public List<MasterVaultDeck> Decks { get; set; }

        [JsonPropertyName("_linked")]
        public Linked Linked { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}
