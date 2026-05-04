
#nullable enable

namespace PixVerse
{
    /// <summary>
    /// 
    /// </summary>
    public enum PixVerseModel
    {
        /// <summary>
        /// 
        /// </summary>
        V45,
        /// <summary>
        /// 
        /// </summary>
        V5,
        /// <summary>
        /// 
        /// </summary>
        V55,
        /// <summary>
        /// 
        /// </summary>
        V56,
        /// <summary>
        /// 
        /// </summary>
        V6,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PixVerseModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PixVerseModel value)
        {
            return value switch
            {
                PixVerseModel.V45 => "v4.5",
                PixVerseModel.V5 => "v5",
                PixVerseModel.V55 => "v5.5",
                PixVerseModel.V56 => "v5.6",
                PixVerseModel.V6 => "v6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PixVerseModel? ToEnum(string value)
        {
            return value switch
            {
                "v4.5" => PixVerseModel.V45,
                "v5" => PixVerseModel.V5,
                "v5.5" => PixVerseModel.V55,
                "v5.6" => PixVerseModel.V56,
                "v6" => PixVerseModel.V6,
                _ => null,
            };
        }
    }
}