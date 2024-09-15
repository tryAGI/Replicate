
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
            typeof(global::Replicate.JsonConverters.PredictionRequestWebhookEventsFilterItemJsonConverter),
            typeof(global::Replicate.JsonConverters.PredictionRequestWebhookEventsFilterItemNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.TrainingRequestWebhookEventsFilterItemJsonConverter),
            typeof(global::Replicate.JsonConverters.TrainingRequestWebhookEventsFilterItemNullableJsonConverter),
            typeof(global::Replicate.JsonConverters.VersionPredictionRequestWebhookEventsFilterItemJsonConverter),
            typeof(global::Replicate.JsonConverters.VersionPredictionRequestWebhookEventsFilterItemNullableJsonConverter),
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
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}