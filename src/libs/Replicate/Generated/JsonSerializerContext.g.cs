
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
            typeof(global::Replicate.JsonConverters.SchemasPredictionRequestWebhookEventsFilterItemJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasPredictionRequestWebhookEventsFilterItemNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasPredictionResponseStatusJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasPredictionResponseStatusNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasPredictionResponseVersionJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasPredictionResponseVersionNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasTrainingRequestWebhookEventsFilterItemJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasTrainingRequestWebhookEventsFilterItemNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasVersionPredictionRequestWebhookEventsFilterItemJsonConverter),
            typeof(global::Replicate.JsonConverters.SchemasVersionPredictionRequestWebhookEventsFilterItemNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.ModelsCreateRequestVisibilityJsonConverter),
            typeof(global::Replicate.JsonConverters.ModelsCreateRequestVisibilityNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.AccountGetResponseTypeJsonConverter),
            typeof(global::Replicate.JsonConverters.AccountGetResponseTypeNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.DeploymentsListResponseResultCurrentReleaseCreatedByTypeJsonConverter),
            typeof(global::Replicate.JsonConverters.DeploymentsListResponseResultCurrentReleaseCreatedByTypeNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.DeploymentsCreateResponseCurrentReleaseCreatedByTypeJsonConverter),
            typeof(global::Replicate.JsonConverters.DeploymentsCreateResponseCurrentReleaseCreatedByTypeNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.DeploymentsGetResponseCurrentReleaseCreatedByTypeJsonConverter),
            typeof(global::Replicate.JsonConverters.DeploymentsGetResponseCurrentReleaseCreatedByTypeNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.DeploymentsUpdateResponseCurrentReleaseCreatedByTypeJsonConverter),
            typeof(global::Replicate.JsonConverters.DeploymentsUpdateResponseCurrentReleaseCreatedByTypeNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.OneOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>),
            typeof(global::Replicate.JsonConverters.OneOfJsonConverter<string, global::Replicate.SchemasPredictionResponseVersion?>),
            typeof(global::Replicate.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}