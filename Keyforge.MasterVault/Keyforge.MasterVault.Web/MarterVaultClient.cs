using HttpClientHelper;
using Keyforge.MasterVault.Entity;
using System.Text.Json;

namespace Keyforge.MasterVault.Web
{
    public interface IMasterVaultClient 
    {
        Task<DeckPage> GetDeckAsync(Guid deckId, IToDictionnary? parameters = null);
        
        Task<AllianceDeck> GetAllianceDeckAsync(Guid deckId, IToDictionnary? parameters = null);
    }

    public class MarterVaultClient : IMasterVaultClient, IDisposable
    {
        private readonly HttpClientWrapper _httpClientWrapper;

        private List<IDisposable> _subscriptions = [];

        public MarterVaultClient(HttpClient client) : this(client, false)
        { }

        private MarterVaultClient(HttpClient client, bool disposeClient) : this(new HttpClientWrapper(client))
        {
            if (disposeClient)
            {
                _subscriptions.Add(client);
            }
        }

        public MarterVaultClient(HttpClientWrapper httpClientWrapper)
        {
            _httpClientWrapper = httpClientWrapper ?? throw new ArgumentNullException(nameof(httpClientWrapper));
        }

        public static MarterVaultClient GetDefaultClient(string token)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("https://keyforgegame.com/api/")
            };
            client.DefaultRequestHeaders.Add("X-Authorization", $"Token {token}");
            return new MarterVaultClient(client, true);
        }

        public async Task<DeckPage> GetDeckAsync(Guid deckId, IToDictionnary? parameters = null)
        {
            return await GetAsync<DeckPage>(HttpMethod.Get, $"decks/v2/{deckId}", parameters);
        }
        
        public async Task<AllianceDeck> GetAllianceDeckAsync(Guid deckId, IToDictionnary? parameters = null)
        {
            return await GetAsync<AllianceDeck>(HttpMethod.Get, $"decks/public-alliances/{deckId}", parameters);
        }

        private async Task<T> GetAsync<T>(HttpMethod method, string endpoint, IToDictionnary? parameters = null)
        {
            using (var request = _httpClientWrapper.CreateRequest(method, endpoint, parameters))
            using (var response = await _httpClientWrapper.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                if (string.IsNullOrWhiteSpace(json))
                {
                    throw new InvalidOperationException("Response content is empty.");
                }
                var result = JsonSerializer.Deserialize<T>(json);
                if (result is null)
                {
                    throw new InvalidOperationException("Deserialization resulted in null.");
                }
                return result;
            }
        }

        public void Dispose()
        {
            foreach (var subscription in _subscriptions)
            {
                subscription.Dispose();
            }
            _subscriptions.Clear();
        }
    }
}
