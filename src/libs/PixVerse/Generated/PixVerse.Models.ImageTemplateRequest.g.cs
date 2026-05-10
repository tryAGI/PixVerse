
#nullable enable

namespace PixVerse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageTemplateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public long? TemplateId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("img_ids")]
        public global::System.Collections.Generic.IList<long>? ImgIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageTemplateRequest" /> class.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="prompt"></param>
        /// <param name="imgIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageTemplateRequest(
            long? templateId,
            string? prompt,
            global::System.Collections.Generic.IList<long>? imgIds)
        {
            this.TemplateId = templateId;
            this.Prompt = prompt;
            this.ImgIds = imgIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageTemplateRequest" /> class.
        /// </summary>
        public ImageTemplateRequest()
        {
        }

    }
}