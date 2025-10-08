
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::Replicate.JsonConverters.SchemasModelResponseVisibilityJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasModelResponseVisibilityNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasDeploymentResponseCurrentReleaseCreatedByTypeJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasDeploymentResponseCurrentReleaseCreatedByTypeNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasPredictionResponseStatusJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasPredictionResponseStatusNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasPredictionResponseVersionJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasPredictionResponseVersionNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasPredictionRequestWebhookEventsFilterItemJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasPredictionRequestWebhookEventsFilterItemNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasTrainingRequestWebhookEventsFilterItemJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasTrainingRequestWebhookEventsFilterItemNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasTrainingResponseSourceJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasTrainingResponseSourceNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasTrainingResponseStatusJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasTrainingResponseStatusNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasVersionPredictionRequestWebhookEventsFilterItemJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasVersionPredictionRequestWebhookEventsFilterItemNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.ModelsCreateRequestVisibilityJsonConverter),
            typeof(global::Replicate.JsonConverters.ModelsCreateRequestVisibilityNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.ModelsListSortByJsonConverter),
            typeof(global::Replicate.JsonConverters.ModelsListSortByNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.ModelsListSortDirectionJsonConverter),
            typeof(global::Replicate.JsonConverters.ModelsListSortDirectionNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.AccountGetResponseTypeJsonConverter),
            typeof(global::Replicate.JsonConverters.AccountGetResponseTypeNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.OneOfJsonConverter<string, global::Replicate.SchemasPredictionResponseVersion?>),
            typeof(global::Replicate.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}