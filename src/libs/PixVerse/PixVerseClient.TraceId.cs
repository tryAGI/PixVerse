namespace PixVerse;

public sealed partial class PixVerseClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request)
    {
        _ = Options;

        if (!request.Headers.Contains("Ai-trace-id"))
        {
            request.Headers.TryAddWithoutValidation("Ai-trace-id", Guid.NewGuid().ToString("D"));
        }
    }
}
