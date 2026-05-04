
#nullable enable

namespace PixVerse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MaskSelectionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_media_id")]
        public long? VideoMediaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_index")]
        public int? FrameIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("point")]
        public global::PixVerse.Point? Point { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MaskSelectionRequest" /> class.
        /// </summary>
        /// <param name="videoMediaId"></param>
        /// <param name="frameIndex"></param>
        /// <param name="point"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MaskSelectionRequest(
            long? videoMediaId,
            int? frameIndex,
            global::PixVerse.Point? point)
        {
            this.VideoMediaId = videoMediaId;
            this.FrameIndex = frameIndex;
            this.Point = point;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaskSelectionRequest" /> class.
        /// </summary>
        public MaskSelectionRequest()
        {
        }
    }
}