#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeploymentsUpdateResponseCurrentReleaseCreatedByTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Replicate.DeploymentsUpdateResponseCurrentReleaseCreatedByType>
    {
        /// <inheritdoc />
        public override global::Replicate.DeploymentsUpdateResponseCurrentReleaseCreatedByType Read(
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
                        return global::Replicate.DeploymentsUpdateResponseCurrentReleaseCreatedByTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Replicate.DeploymentsUpdateResponseCurrentReleaseCreatedByType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Replicate.DeploymentsUpdateResponseCurrentReleaseCreatedByType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Replicate.DeploymentsUpdateResponseCurrentReleaseCreatedByTypeExtensions.ToValueString(value));
        }
    }
}
