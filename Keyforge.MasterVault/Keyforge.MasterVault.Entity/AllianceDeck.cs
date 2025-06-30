using System.Text.Json.Serialization;

namespace Keyforge.MasterVault.Entity
{
    public class AllianceDeck
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        [JsonPropertyName("hidden")]
        public bool Hidden { get; set; }

        [JsonPropertyName("set_id")]
        public int SetId { get; set; }

        [JsonPropertyName("deck_1_id")]
        public Guid Deck1Id { get; set; }

        [JsonPropertyName("house_1_id")]
        public string House1Id { get; set; }

        [JsonPropertyName("deck_2_id")]
        public Guid Deck2Id { get; set; }

        [JsonPropertyName("house_2_id")]
        public string House2Id { get; set; }

        [JsonPropertyName("deck_3_id")]
        public Guid Deck3Id { get; set; }

        [JsonPropertyName("house_3_id")]
        public string House3Id { get; set; }

        [JsonPropertyName("token_creature_card_id")]
        public Guid? TokenCreatureCardId { get; set; }

        [JsonPropertyName("is_my_alliance")]
        public bool IsMyAlliance { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
