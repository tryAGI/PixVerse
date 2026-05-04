#nullable enable

namespace PixVerse
{
    public partial interface IPixVerseClient
    {
        /// <summary>
        /// Create a first-frame to last-frame transition video.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PixVerse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PixVerse.VideoGenerationApiResponse> CreateTransitionVideoAsync(

            global::PixVerse.TransitionVideoRequest request,
            global::PixVerse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a first-frame to last-frame transition video.
        /// </summary>
        /// <param name="firstFrameImgId"></param>
        /// <param name="lastFrameImgId"></param>
        /// <param name="prompt"></param>
        /// <param name="model"></param>
        /// <param name="duration"></param>
        /// <param name="quality"></param>
        /// <param name="aspectRatio"></param>
        /// <param name="motionMode"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="seed"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PixVerse.VideoGenerationApiResponse> CreateTransitionVideoAsync(
            long firstFrameImgId,
            long lastFrameImgId,
            string? prompt = default,
            global::PixVerse.PixVerseModel? model = default,
            int? duration = default,
            global::PixVerse.VideoQuality? quality = default,
            global::PixVerse.AspectRatio? aspectRatio = default,
            string? motionMode = default,
            string? negativePrompt = default,
            long? seed = default,
            global::PixVerse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}