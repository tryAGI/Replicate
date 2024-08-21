
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
            typeof(global::OpenApiGenerator.JsonConverters.PredictionRequestWebhookEventsFilterItemJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.PredictionRequestWebhookEventsFilterItemNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.TrainingRequestWebhookEventsFilterItemJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.TrainingRequestWebhookEventsFilterItemNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.VersionPredictionRequestWebhookEventsFilterItemJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.VersionPredictionRequestWebhookEventsFilterItemNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ModelsCreateRequestVisibilityJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ModelsCreateRequestVisibilityNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.AccountGetResponseTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.AccountGetResponseTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeploymentsListResponseResultCurrentReleaseCreatedByTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeploymentsListResponseResultCurrentReleaseCreatedByTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeploymentsCreateResponseCurrentReleaseCreatedByTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeploymentsCreateResponseCurrentReleaseCreatedByTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeploymentsGetResponseCurrentReleaseCreatedByTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeploymentsGetResponseCurrentReleaseCreatedByTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeploymentsUpdateResponseCurrentReleaseCreatedByTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeploymentsUpdateResponseCurrentReleaseCreatedByTypeNullableJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}