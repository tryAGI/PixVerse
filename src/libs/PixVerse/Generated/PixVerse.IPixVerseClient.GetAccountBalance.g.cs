#nullable enable

namespace PixVerse
{
    public partial interface IPixVerseClient
    {
        /// <summary>
        /// Get the current PixVerse API account balance.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PixVerse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PixVerse.BalanceApiResponse> GetAccountBalanceAsync(
            global::PixVerse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}