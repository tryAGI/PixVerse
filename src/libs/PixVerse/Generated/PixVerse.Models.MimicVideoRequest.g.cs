
#nullable enable

namespace PixVerse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MimicVideoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PixVerse.JsonConverters.PixVerseModelJsonConverter))]
        public global::PixVerse.PixVerseModel? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PixVerse.JsonConverters.VideoQualityJsonConverter))]
        public global::PixVerse.VideoQuality? Quality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PixVerse.JsonConverters.AspectRatioJsonConverter))]
        public global::PixVerse.AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("motion_mode")]
        public string? MotionMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public long? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MimicVideoRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="model"></param>
        /// <param name="duration"></param>
        /// <param name="quality"></param>
        /// <param name="aspectRatio"></param>
        /// <param name="motionMode"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="seed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MimicVideoRequest(
            string? prompt,
            global::PixVerse.PixVerseModel? model,
            int? duration,
            global::PixVerse.VideoQuality? quality,
            global::PixVerse.AspectRatio? aspectRatio,
            string? motionMode,
            string? negativePrompt,
            long? seed)
        {
            this.Prompt = prompt;
            this.Model = model;
            this.Duration = duration;
            this.Quality = quality;
            this.AspectRatio = aspectRatio;
            this.MotionMode = motionMode;
            this.NegativePrompt = negativePrompt;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MimicVideoRequest" /> class.
        /// </summary>
        public MimicVideoRequest()
        {
        }

    }
}