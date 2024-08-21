#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeploymentsCreateResponseCurrentReleaseCreatedByTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Replicate.DeploymentsCreateResponseCurrentReleaseCreatedByType?>
    {
        /// <inheritdoc />
        public override global::Replicate.DeploymentsCreateResponseCurrentReleaseCreatedByType? Read(
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
                        return global::Replicate.DeploymentsCreateResponseCurrentReleaseCreatedByTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Replicate.DeploymentsCreateResponseCurrentReleaseCreatedByType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Replicate.DeploymentsCreateResponseCurrentReleaseCreatedByType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Replicate.DeploymentsCreateResponseCurrentReleaseCreatedByTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
