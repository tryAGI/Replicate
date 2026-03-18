
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

            typeof(global::Replicate.JsonConverters.SchemasPredictionResponseSourceJsonConverter),

            typeof(global::Replicate.JsonConverters.SchemasPredictionResponseSourceNullableJsonConverter),

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

            typeof(global::Replicate.JsonConverters.PredictionsListSourceJsonConverter),

            typeof(global::Replicate.JsonConverters.PredictionsListSourceNullableJsonConverter),

            typeof(global::Replicate.JsonConverters.AccountGetResponseTypeJsonConverter),

            typeof(global::Replicate.JsonConverters.AccountGetResponseTypeNullableJsonConverter),

            typeof(global::Replicate.JsonConverters.OneOfJsonConverter<string, global::Replicate.SchemasPredictionResponseVersion?>),

            typeof(global::Replicate.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasCollectionListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Replicate.SchemasModelResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasModelResponseVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasDeploymentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasDeploymentResponseCurrentRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasDeploymentResponseCurrentReleaseConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasDeploymentResponseCurrentReleaseCreatedBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasDeploymentResponseCurrentReleaseCreatedByType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasFileResponseChecksums))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasFileResponseUrls))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasPageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasPaginatedCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Replicate.SchemasCollectionListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasPaginatedModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasPaginatedPredictionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Replicate.SchemasPredictionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasPredictionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasPredictionResponseMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasPredictionResponseSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasPredictionResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasPredictionResponseUrls))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.OneOf<string, global::Replicate.SchemasPredictionResponseVersion?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasPredictionResponseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasPaginatedVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Replicate.SchemasVersionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasPredictionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Replicate.SchemasPredictionRequestWebhookEventsFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasPredictionRequestWebhookEventsFilterItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasSearchCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasSearchModelMetadataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Replicate.SchemasSearchCollectionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Replicate.SchemasSearchResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasSearchResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Replicate.SchemasPageResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasTrainingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Replicate.SchemasTrainingRequestWebhookEventsFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasTrainingRequestWebhookEventsFilterItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasTrainingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasTrainingResponseMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasTrainingResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasTrainingResponseSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasTrainingResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasTrainingResponseUrls))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasVersionPredictionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Replicate.SchemasVersionPredictionRequestWebhookEventsFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SchemasVersionPredictionRequestWebhookEventsFilterItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.DeploymentsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.DeploymentsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.FilesCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.ModelsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.ModelsCreateRequestVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.ModelsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.ModelsListSortBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.ModelsListSortDirection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.PredictionsListSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.AccountGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.AccountGetResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.DeploymentsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Replicate.SchemasDeploymentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.FilesListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Replicate.SchemasFileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.FilesCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.FilesDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.FilesGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.FilesDownloadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Replicate.HardwareListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.HardwareListResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.PredictionsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.SearchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.TrainingsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Replicate.SchemasTrainingResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Replicate.WebhooksDefaultSecretGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Replicate.SchemasModelResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Replicate.SchemasCollectionListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Replicate.SchemasPredictionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Replicate.SchemasVersionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Replicate.SchemasPredictionRequestWebhookEventsFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Replicate.SchemasSearchCollectionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Replicate.SchemasSearchResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Replicate.SchemasPageResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Replicate.SchemasTrainingRequestWebhookEventsFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Replicate.SchemasVersionPredictionRequestWebhookEventsFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Replicate.SchemasDeploymentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Replicate.SchemasFileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Replicate.HardwareListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Replicate.SchemasTrainingResponse>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}