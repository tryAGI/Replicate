
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SchemasPredictionResponse
    {
        /// <summary>
        /// The time that the model completed the prediction and all outputs were uploaded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// The time that the prediction was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Whether the prediction output has been deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_removed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DataRemoved { get; set; }

        /// <summary>
        /// The name of the deployment that created the prediction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        /// <summary>
        /// An error string if the model status is `"failed"`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The prediction input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// The log output from the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        public string? Logs { get; set; }

        /// <summary>
        /// Additional metrics associated with the prediction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::Replicate.SchemasPredictionResponseMetrics? Metrics { get; set; }

        /// <summary>
        /// The name of the model that created the prediction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The prediction output, which can be any JSON-serializable value, depending on the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Output { get; set; }

        /// <summary>
        /// The time that the model began the prediction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Replicate.JsonConverters.SchemasPredictionResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Replicate.SchemasPredictionResponseStatus Status { get; set; }

        /// <summary>
        /// URLs for working with the prediction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Replicate.SchemasPredictionResponseUrls Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Replicate.JsonConverters.OneOfJsonConverter<string, global::Replicate.SchemasPredictionResponseVersion?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Replicate.OneOf<string, global::Replicate.SchemasPredictionResponseVersion?> Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasPredictionResponse" /> class.
        /// </summary>
        /// <param name="completedAt">
        /// The time that the model completed the prediction and all outputs were uploaded
        /// </param>
        /// <param name="createdAt">
        /// The time that the prediction was created
        /// </param>
        /// <param name="dataRemoved">
        /// Whether the prediction output has been deleted
        /// </param>
        /// <param name="deployment">
        /// The name of the deployment that created the prediction
        /// </param>
        /// <param name="error">
        /// An error string if the model status is `"failed"`
        /// </param>
        /// <param name="id"></param>
        /// <param name="input">
        /// The prediction input
        /// </param>
        /// <param name="logs">
        /// The log output from the model
        /// </param>
        /// <param name="metrics">
        /// Additional metrics associated with the prediction
        /// </param>
        /// <param name="model">
        /// The name of the model that created the prediction
        /// </param>
        /// <param name="output">
        /// The prediction output, which can be any JSON-serializable value, depending on the model
        /// </param>
        /// <param name="startedAt">
        /// The time that the model began the prediction
        /// </param>
        /// <param name="status"></param>
        /// <param name="urls">
        /// URLs for working with the prediction
        /// </param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemasPredictionResponse(
            global::System.DateTime createdAt,
            bool dataRemoved,
            string? error,
            string id,
            object input,
            string model,
            object output,
            global::Replicate.SchemasPredictionResponseStatus status,
            global::Replicate.SchemasPredictionResponseUrls urls,
            global::Replicate.OneOf<string, global::Replicate.SchemasPredictionResponseVersion?> version,
            global::System.DateTime? completedAt,
            string? deployment,
            string? logs,
            global::Replicate.SchemasPredictionResponseMetrics? metrics,
            global::System.DateTime? startedAt)
        {
            this.CreatedAt = createdAt;
            this.DataRemoved = dataRemoved;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Status = status;
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
            this.Version = version;
            this.CompletedAt = completedAt;
            this.Deployment = deployment;
            this.Logs = logs;
            this.Metrics = metrics;
            this.StartedAt = startedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasPredictionResponse" /> class.
        /// </summary>
        public SchemasPredictionResponse()
        {
        }
    }
}