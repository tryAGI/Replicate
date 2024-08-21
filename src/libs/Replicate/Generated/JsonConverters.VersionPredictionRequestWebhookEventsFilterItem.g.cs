#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class VersionPredictionRequestWebhookEventsFilterItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Replicate.VersionPredictionRequestWebhookEventsFilterItem>
    {
        /// <inheritdoc />
        public override global::Replicate.VersionPredictionRequestWebhookEventsFilterItem Read(
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
                        return global::Replicate.VersionPredictionRequestWebhookEventsFilterItemExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Replicate.VersionPredictionRequestWebhookEventsFilterItem)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Replicate.VersionPredictionRequestWebhookEventsFilterItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Replicate.VersionPredictionRequestWebhookEventsFilterItemExtensions.ToValueString(value));
        }
    }
}
