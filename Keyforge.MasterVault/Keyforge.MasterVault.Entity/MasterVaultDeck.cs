using System.Text.Json.Serialization;

namespace Keyforge.MasterVault.Entity
{
    public class MasterVaultDeck
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("expansion")]
        public int Expansion { get; set; }

        [JsonPropertyName("power_level")]
        public int PowerLevel { get; set; }

        [JsonPropertyName("chains")]
        public int Chains { get; set; }

        [JsonPropertyName("wins")]
        public int Wins { get; set; }

        [JsonPropertyName("losses")]
        public int Losses { get; set; }

        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("is_my_deck")]
        public bool IsMyDeck { get; set; }

        [JsonPropertyName("is_deck_owned")]
        public bool IsDeckOwned { get; set; }

        [JsonPropertyName("cards")]
        public List<Guid> Cards { get; set; }

        [JsonPropertyName("notes")]
        public List<string> Notes { get; set; }

        [JsonPropertyName("is_my_favorite")]
        public bool IsMyFavorite { get; set; }

        [JsonPropertyName("is_on_my_watchlist")]
        public bool IsOnMyWatchlist { get; set; }

        [JsonPropertyName("casual_wins")]
        public int CasualWins { get; set; }

        [JsonPropertyName("casual_losses")]
        public int CasualLosses { get; set; }

        [JsonPropertyName("set_era_cards")]
        public SetEraCards SetEraCards { get; set; }

        [JsonPropertyName("shards_bonus")]
        public object ShardsBonus { get; set; }

        [JsonPropertyName("bonus_icons")]
        public List<BonusIcon> BonusIcons { get; set; }

        [JsonPropertyName("flavor_text")]
        public string FlavorText { get; set; }

        [JsonPropertyName("is_pending_transfer")]
        public bool IsPendingTransfer { get; set; }

        [JsonPropertyName("available_print_languages")]
        public List<string> AvailablePrintLanguages { get; set; }

        [JsonPropertyName("_links")]
        public Links Links { get; set; }
    }


}
