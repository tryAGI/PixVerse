
#nullable enable

namespace PixVerse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LipSyncRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        public long? VideoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_media_id")]
        public long? VideoMediaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_media_id")]
        public long? AudioMediaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LipSyncRequest" /> class.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="videoMediaId"></param>
        /// <param name="audioMediaId"></param>
        /// <param name="voiceId"></param>
        /// <param name="text"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LipSyncRequest(
            long? videoId,
            long? videoMediaId,
            long? audioMediaId,
            string? voiceId,
            string? text)
        {
            this.VideoId = videoId;
            this.VideoMediaId = videoMediaId;
            this.AudioMediaId = audioMediaId;
            this.VoiceId = voiceId;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LipSyncRequest" /> class.
        /// </summary>
        public LipSyncRequest()
        {
        }

    }
}