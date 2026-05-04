
#nullable enable

namespace PixVerse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadMediaRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Media { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medianame")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Medianame { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadMediaRequest" /> class.
        /// </summary>
        /// <param name="media"></param>
        /// <param name="medianame"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadMediaRequest(
            byte[] media,
            string medianame)
        {
            this.Media = media ?? throw new global::System.ArgumentNullException(nameof(media));
            this.Medianame = medianame ?? throw new global::System.ArgumentNullException(nameof(medianame));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadMediaRequest" /> class.
        /// </summary>
        public UploadMediaRequest()
        {
        }
    }
}