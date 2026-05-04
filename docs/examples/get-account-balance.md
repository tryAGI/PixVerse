# Get account balance

Read the PixVerse API account balance.

This example assumes `using PixVerse;` is in scope and `apiKey` contains your PixVerse API key.

```csharp
using var client = new PixVerseClient(apiKey);

var response = await client.GetAccountBalanceAsync();
```