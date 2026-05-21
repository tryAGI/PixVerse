
#nullable enable

namespace PixVerse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KeyframeImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("img_id")]
        public long? ImgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyframeImage" /> class.
        /// </summary>
        /// <param name="imgId"></param>
        /// <param name="prompt"></param>
        /// <param name="duration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyframeImage(
            long? imgId,
            string? prompt,
            int? duration)
        {
            this.ImgId = imgId;
            this.Prompt = prompt;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyframeImage" /> class.
        /// </summary>
        public KeyframeImage()
        {
        }

    }
}