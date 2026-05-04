#nullable enable

namespace PixVerse
{
    public partial interface IPixVerseClient
    {
        /// <summary>
        /// Create a lip-sync video.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PixVerse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PixVerse.VideoGenerationApiResponse> CreateLipSyncVideoAsync(

            global::PixVerse.LipSyncRequest request,
            global::PixVerse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a lip-sync video.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="videoMediaId"></param>
        /// <param name="audioMediaId"></param>
        /// <param name="voiceId"></param>
        /// <param name="text"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PixVerse.VideoGenerationApiResponse> CreateLipSyncVideoAsync(
            long? videoId = default,
            long? videoMediaId = default,
            long? audioMediaId = default,
            string? voiceId = default,
            string? text = default,
            global::PixVerse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}