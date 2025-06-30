using System.Text.Json.Serialization;

namespace Keyforge.MasterVault.Entity
{
    public class BonusIcon
    {
        [JsonPropertyName("card_id")]
        public Guid CardId { get; set; }

        [JsonPropertyName("bonus_icons")]
        public List<string> BonusIcons { get; set; }
    }


}
