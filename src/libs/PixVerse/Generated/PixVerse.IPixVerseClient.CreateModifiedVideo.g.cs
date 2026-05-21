#nullable enable

namespace PixVerse
{
    public partial interface IPixVerseClient
    {
        /// <summary>
        /// Modify an existing video using a prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PixVerse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PixVerse.VideoGenerationApiResponse> CreateModifiedVideoAsync(

            global::PixVerse.ModifyVideoRequest request,
            global::PixVerse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify an existing video using a prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PixVerse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PixVerse.AutoSDKHttpResponse<global::PixVerse.VideoGenerationApiResponse>> CreateModifiedVideoAsResponseAsync(

            global::PixVerse.ModifyVideoRequest request,
            global::PixVerse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify an existing video using a prompt.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="videoMediaId"></param>
        /// <param name="prompt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PixVerse.VideoGenerationApiResponse> CreateModifiedVideoAsync(
            long? videoId = default,
            long? videoMediaId = default,
            string? prompt = default,
            global::PixVerse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}