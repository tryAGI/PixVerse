
#nullable enable

namespace PixVerse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SoundEffectRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        public long? VideoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SoundEffectRequest" /> class.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="prompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SoundEffectRequest(
            long? videoId,
            string? prompt)
        {
            this.VideoId = videoId;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SoundEffectRequest" /> class.
        /// </summary>
        public SoundEffectRequest()
        {
        }

    }
}