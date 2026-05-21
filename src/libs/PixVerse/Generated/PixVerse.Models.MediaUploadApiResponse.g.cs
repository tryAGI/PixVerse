
#nullable enable

namespace PixVerse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MediaUploadApiResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ErrCode")]
        public int? ErrCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ErrMsg")]
        public string? ErrMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Resp")]
        public global::PixVerse.MediaUploadResult? Resp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaUploadApiResponse" /> class.
        /// </summary>
        /// <param name="errCode"></param>
        /// <param name="errMsg"></param>
        /// <param name="resp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaUploadApiResponse(
            int? errCode,
            string? errMsg,
            global::PixVerse.MediaUploadResult? resp)
        {
            this.ErrCode = errCode;
            this.ErrMsg = errMsg;
            this.Resp = resp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaUploadApiResponse" /> class.
        /// </summary>
        public MediaUploadApiResponse()
        {
        }

    }
}