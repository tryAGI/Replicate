#nullable enable

namespace Replicate.JsonConverters
{
    /// <inheritdoc />
    public sealed class SchemasPredictionResponseVersionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Replicate.SchemasPredictionResponseVersion>
    {
        /// <inheritdoc />
        public override global::Replicate.SchemasPredictionResponseVersion Read(
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
                        return global::Replicate.SchemasPredictionResponseVersionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Replicate.SchemasPredictionResponseVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Replicate.SchemasPredictionResponseVersion);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Replicate.SchemasPredictionResponseVersion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Replicate.SchemasPredictionResponseVersionExtensions.ToValueString(value));
        }
    }
}
