#nullable enable

namespace Replicate.JsonConverters
{
    /// <inheritdoc />
    public sealed class SchemasPredictionRequestWebhookEventsFilterItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Replicate.SchemasPredictionRequestWebhookEventsFilterItem>
    {
        /// <inheritdoc />
        public override global::Replicate.SchemasPredictionRequestWebhookEventsFilterItem Read(
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
                        return global::Replicate.SchemasPredictionRequestWebhookEventsFilterItemExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Replicate.SchemasPredictionRequestWebhookEventsFilterItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Replicate.SchemasPredictionRequestWebhookEventsFilterItem);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Replicate.SchemasPredictionRequestWebhookEventsFilterItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Replicate.SchemasPredictionRequestWebhookEventsFilterItemExtensions.ToValueString(value));
        }
    }
}
