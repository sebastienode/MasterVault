using System.Text.Json.Serialization;

namespace Keyforge.MasterVault.Entity
{
    public class DeckPage
    {
        [JsonPropertyName("data")]
        public MasterVaultDeck Deck { get; set; }

        [JsonPropertyName("_linked")]
        public Linked Linked { get; set; }
    }


}
