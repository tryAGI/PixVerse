
#nullable enable

namespace PixVerse
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoQuality
    {
        /// <summary>
        /// 
        /// </summary>
        x1080p,
        /// <summary>
        /// 
        /// </summary>
        x360p,
        /// <summary>
        /// 
        /// </summary>
        x540p,
        /// <summary>
        /// 
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoQuality value)
        {
            return value switch
            {
                VideoQuality.x1080p => "1080p",
                VideoQuality.x360p => "360p",
                VideoQuality.x540p => "540p",
                VideoQuality.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoQuality? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => VideoQuality.x1080p,
                "360p" => VideoQuality.x360p,
                "540p" => VideoQuality.x540p,
                "720p" => VideoQuality.x720p,
                _ => null,
            };
        }
    }
}