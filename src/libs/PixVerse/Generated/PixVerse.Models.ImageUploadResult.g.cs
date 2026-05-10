
#nullable enable

namespace PixVerse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageUploadResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("img_id")]
        public long? ImgId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUploadResult" /> class.
        /// </summary>
        /// <param name="imgId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageUploadResult(
            long? imgId)
        {
            this.ImgId = imgId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUploadResult" /> class.
        /// </summary>
        public ImageUploadResult()
        {
        }

    }
}