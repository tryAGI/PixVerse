#nullable enable

namespace PixVerse
{
    public partial interface IPixVerseClient
    {
        /// <summary>
        /// Create an image from a template.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PixVerse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PixVerse.ImageGenerationApiResponse> CreateImageTemplateAsync(

            global::PixVerse.ImageTemplateRequest request,
            global::PixVerse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an image from a template.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PixVerse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PixVerse.AutoSDKHttpResponse<global::PixVerse.ImageGenerationApiResponse>> CreateImageTemplateAsResponseAsync(

            global::PixVerse.ImageTemplateRequest request,
            global::PixVerse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an image from a template.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="prompt"></param>
        /// <param name="imgIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PixVerse.ImageGenerationApiResponse> CreateImageTemplateAsync(
            long? templateId = default,
            string? prompt = default,
            global::System.Collections.Generic.IList<long>? imgIds = default,
            global::PixVerse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}