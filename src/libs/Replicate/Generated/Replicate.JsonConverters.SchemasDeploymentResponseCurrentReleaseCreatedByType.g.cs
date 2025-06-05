#nullable enable

namespace Replicate.JsonConverters
{
    /// <inheritdoc />
    public sealed class SchemasDeploymentResponseCurrentReleaseCreatedByTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Replicate.SchemasDeploymentResponseCurrentReleaseCreatedByType>
    {
        /// <inheritdoc />
        public override global::Replicate.SchemasDeploymentResponseCurrentReleaseCreatedByType Read(
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
                        return global::Replicate.SchemasDeploymentResponseCurrentReleaseCreatedByTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Replicate.SchemasDeploymentResponseCurrentReleaseCreatedByType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Replicate.SchemasDeploymentResponseCurrentReleaseCreatedByType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Replicate.SchemasDeploymentResponseCurrentReleaseCreatedByType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Replicate.SchemasDeploymentResponseCurrentReleaseCreatedByTypeExtensions.ToValueString(value));
        }
    }
}
