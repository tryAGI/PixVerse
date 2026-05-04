
#nullable enable

namespace PixVerse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MediaUploadResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public long? MediaId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaUploadResult" /> class.
        /// </summary>
        /// <param name="mediaId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaUploadResult(
            long? mediaId)
        {
            this.MediaId = mediaId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaUploadResult" /> class.
        /// </summary>
        public MediaUploadResult()
        {
        }
    }
}