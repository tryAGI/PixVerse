#nullable enable

namespace PixVerse.JsonConverters
{
    /// <inheritdoc />
    public sealed class PixVerseModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PixVerse.PixVerseModel>
    {
        /// <inheritdoc />
        public override global::PixVerse.PixVerseModel Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::PixVerse.PixVerseModelExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::PixVerse.PixVerseModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::PixVerse.PixVerseModel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PixVerse.PixVerseModel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::PixVerse.PixVerseModelExtensions.ToValueString(value));
        }
    }
}
