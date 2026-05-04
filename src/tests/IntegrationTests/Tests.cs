namespace PixVerse.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static PixVerseClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("PIXVERSE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("PIXVERSE_API_KEY environment variable is not found.");

        var client = new PixVerseClient(apiKey);
        
        return client;
    }
}
