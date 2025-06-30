using HttpClientHelper;

namespace Keyforge.MasterVault.Web
{
    public class MasterVaultParameters : IToDictionnary
    {
        public const string LinkCards = "cards";
        public const string LinkNotes = "notes";
        public const string LinkAccolades = "accolades";

        public List<string> Links { get; set; } = [];

        public Dictionary<string, string> ToDictionary()
        {
            return new Dictionary<string, string>
            {
                { "links", string.Join(",", Links.Distinct()) }
            };
        }
    }
}
