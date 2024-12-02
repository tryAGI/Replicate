#nullable enable

namespace Replicate.JsonConverters
{
    /// <inheritdoc />
    public sealed class SchemasTrainingRequestWebhookEventsFilterItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Replicate.SchemasTrainingRequestWebhookEventsFilterItem?>
    {
        /// <inheritdoc />
        public override global::Replicate.SchemasTrainingRequestWebhookEventsFilterItem? Read(
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
                        return global::Replicate.SchemasTrainingRequestWebhookEventsFilterItemExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Replicate.SchemasTrainingRequestWebhookEventsFilterItem)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Replicate.SchemasTrainingRequestWebhookEventsFilterItem? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Replicate.SchemasTrainingRequestWebhookEventsFilterItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
