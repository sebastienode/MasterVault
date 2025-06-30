using System.Text.Json.Serialization;

namespace Keyforge.MasterVault.Entity
{
    public class Card
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("card_title")]
        public string CardTitle { get; set; }

        [JsonPropertyName("card_title_en")]
        public string CardTitleEn { get; set; }

        [JsonPropertyName("house")]
        public string House { get; set; }

        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        [JsonPropertyName("front_image")]
        public string FrontImage { get; set; }

        [JsonPropertyName("card_text")]
        public string CardText { get; set; }

        [JsonPropertyName("traits")]
        public string Traits { get; set; }

        [JsonPropertyName("amber")]
        public int Amber { get; set; }

        [JsonPropertyName("power")]
        public string Power { get; set; }

        [JsonPropertyName("armor")]
        public string Armor { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("house_variant")]
        public object HouseVariant { get; set; }

        [JsonPropertyName("flavor_text")]
        public string FlavorText { get; set; }

        [JsonPropertyName("card_number")]
        public string CardNumber { get; set; }

        [JsonPropertyName("expansion")]
        public int Expansion { get; set; }

        [JsonPropertyName("is_maverick")]
        public bool IsMaverick { get; set; }

        [JsonPropertyName("is_anomaly")]
        public bool IsAnomaly { get; set; }

        [JsonPropertyName("is_enhanced")]
        public bool IsEnhanced { get; set; }

        [JsonPropertyName("is_non_deck")]
        public bool IsNonDeck { get; set; }
    }


}
