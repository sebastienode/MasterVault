// See https://aka.ms/new-console-template for more information
using Keyforge.MasterVault.Entity;
using Keyforge.MasterVault.Web;

Console.WriteLine("Hello, World!");

//TODO SET TOKEN
var mvClient = MarterVaultClient.GetDefaultClient("", "fr-fr");

try
{
	var deck = mvClient.GetDeckAsync(Guid.Parse("96674254-c775-47f0-b966-a1f30491dec1")).GetAwaiter().GetResult().Deck;
	Console.WriteLine($"Deck Name: {deck.Name}");
	Console.WriteLine($"is my deck: {deck.IsMyDeck}");

	var allianceDeck = mvClient.GetAllianceDeckAsync(Guid.Parse("20e772cf-933f-4a82-b25e-c68d9f864501")).GetAwaiter().GetResult();

	var deckPage1 = mvClient.GetDeckAsync(allianceDeck.Deck1Id, new MasterVaultParameters().WithCards()).GetAwaiter().GetResult();
	var deckPage2 = mvClient.GetDeckAsync(allianceDeck.Deck2Id, new MasterVaultParameters().WithCards()).GetAwaiter().GetResult();
	var deckPage3 = mvClient.GetDeckAsync(allianceDeck.Deck3Id, new MasterVaultParameters().WithCards()).GetAwaiter().GetResult();

	Console.WriteLine($"Alliance Name: {allianceDeck.Name}");
	Console.WriteLine(string.Empty);

	Console.WriteLine($"Deck 1 Name: {deckPage1.Deck.Name} - House: {allianceDeck.House1Id}");
	DisplayCard(deckPage1, allianceDeck.House1Id);
    Console.WriteLine(string.Empty);

    Console.WriteLine($"Deck 1 Name: {deckPage2.Deck.Name} - House: {allianceDeck.House2Id}");
    DisplayCard(deckPage2, allianceDeck.House2Id);
    Console.WriteLine(string.Empty);

    Console.WriteLine($"Deck 1 Name: {deckPage3.Deck.Name} - House: {allianceDeck.House3Id}");
    DisplayCard(deckPage3, allianceDeck.House3Id);
    Console.WriteLine(string.Empty);
}
catch (Exception ex)
{
	Console.WriteLine($"An error occurred: ");
	Console.WriteLine(ex.ToString());
}

mvClient.Dispose();




void DisplayCard(DeckPage deck1, string house)
{
	foreach (var guid in deck1.Deck.Links.Cards)
	{
		var card = deck1.Linked.Cards.FirstOrDefault(c => c.Id == guid);
        if (card != null && card.House == house)
		{
			Console.WriteLine($"\t- {card.CardTitle}");
        }
    }
}