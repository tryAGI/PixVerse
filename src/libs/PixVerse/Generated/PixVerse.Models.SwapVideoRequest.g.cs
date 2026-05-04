
#nullable enable

namespace PixVerse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SwapVideoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_media_id")]
        public long? VideoMediaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyframe_id")]
        public long? KeyframeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_id")]
        public long? MaskId { get; set; }

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
        /// Initializes a new instance of the <see cref="SwapVideoRequest" /> class.
        /// </summary>
        /// <param name="videoMediaId"></param>
        /// <param name="keyframeId"></param>
        /// <param name="maskId"></param>
        /// <param name="imgId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SwapVideoRequest(
            long? videoMediaId,
            long? keyframeId,
            long? maskId,
            long? imgId)
        {
            this.VideoMediaId = videoMediaId;
            this.KeyframeId = keyframeId;
            this.MaskId = maskId;
            this.ImgId = imgId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SwapVideoRequest" /> class.
        /// </summary>
        public SwapVideoRequest()
        {
        }
    }
}