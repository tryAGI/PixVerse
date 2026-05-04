
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace PixVerse
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::PixVerse.JsonConverters.PixVerseModelJsonConverter),

            typeof(global::PixVerse.JsonConverters.PixVerseModelNullableJsonConverter),

            typeof(global::PixVerse.JsonConverters.VideoQualityJsonConverter),

            typeof(global::PixVerse.JsonConverters.VideoQualityNullableJsonConverter),

            typeof(global::PixVerse.JsonConverters.AspectRatioJsonConverter),

            typeof(global::PixVerse.JsonConverters.AspectRatioNullableJsonConverter),

            typeof(global::PixVerse.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.ApiResponseBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.CommonVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.PixVerseModel), TypeInfoPropertyName = "PixVerseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.VideoQuality), TypeInfoPropertyName = "VideoQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.AspectRatio), TypeInfoPropertyName = "AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.TextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.ImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.TransitionVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.FusionVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PixVerse.ImageReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.ImageReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.MultiTransitionVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PixVerse.KeyframeImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.KeyframeImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.RestyleVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.SwapVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.SoundEffectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.ExtendVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.MimicVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.ModifyVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.MaskSelectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.Point))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.LipSyncRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.ImageTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.VideoGenerationApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.VideoGenerationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.VideoResultApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.VideoResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.ImageGenerationApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.ImageGenerationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.ImageResultApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.ImageResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.ImageUploadApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.ImageUploadResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.MediaUploadApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.MediaUploadResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.BalanceApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.RestyleListApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.MaskSelectionApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.LipSyncTtsListApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.UploadImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PixVerse.UploadMediaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PixVerse.ImageReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PixVerse.KeyframeImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}