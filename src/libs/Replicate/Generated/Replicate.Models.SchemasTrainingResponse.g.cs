
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SchemasTrainingResponse
    {
        /// <summary>
        /// The time when the training completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// The time when the training was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Error message if the training failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The unique ID of the training
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The input parameters used for the training
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// The logs from the training process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        public string? Logs { get; set; }

        /// <summary>
        /// Metrics about the training process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::Replicate.SchemasTrainingResponseMetrics? Metrics { get; set; }

        /// <summary>
        /// The name of the model in the format owner/name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The output of the training process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Replicate.SchemasTrainingResponseOutput? Output { get; set; }

        /// <summary>
        /// How the training was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Replicate.JsonConverters.SchemasTrainingResponseSourceJsonConverter))]
        public global::Replicate.SchemasTrainingResponseSource? Source { get; set; }

        /// <summary>
        /// The time when the training started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// The current status of the training
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Replicate.JsonConverters.SchemasTrainingResponseStatusJsonConverter))]
        public global::Replicate.SchemasTrainingResponseStatus? Status { get; set; }

        /// <summary>
        /// URLs for interacting with the training
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::Replicate.SchemasTrainingResponseUrls? Urls { get; set; }

        /// <summary>
        /// The ID of the model version used for training
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasTrainingResponse" /> class.
        /// </summary>
        /// <param name="completedAt">
        /// The time when the training completed
        /// </param>
        /// <param name="createdAt">
        /// The time when the training was created
        /// </param>
        /// <param name="error">
        /// Error message if the training failed
        /// </param>
        /// <param name="id">
        /// The unique ID of the training
        /// </param>
        /// <param name="input">
        /// The input parameters used for the training
        /// </param>
        /// <param name="logs">
        /// The logs from the training process
        /// </param>
        /// <param name="metrics">
        /// Metrics about the training process
        /// </param>
        /// <param name="model">
        /// The name of the model in the format owner/name
        /// </param>
        /// <param name="output">
        /// The output of the training process
        /// </param>
        /// <param name="source">
        /// How the training was created
        /// </param>
        /// <param name="startedAt">
        /// The time when the training started
        /// </param>
        /// <param name="status">
        /// The current status of the training
        /// </param>
        /// <param name="urls">
        /// URLs for interacting with the training
        /// </param>
        /// <param name="version">
        /// The ID of the model version used for training
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemasTrainingResponse(
            global::System.DateTime? completedAt,
            global::System.DateTime? createdAt,
            string? error,
            string? id,
            object? input,
            string? logs,
            global::Replicate.SchemasTrainingResponseMetrics? metrics,
            string? model,
            global::Replicate.SchemasTrainingResponseOutput? output,
            global::Replicate.SchemasTrainingResponseSource? source,
            global::System.DateTime? startedAt,
            global::Replicate.SchemasTrainingResponseStatus? status,
            global::Replicate.SchemasTrainingResponseUrls? urls,
            string? version)
        {
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.Error = error;
            this.Id = id;
            this.Input = input;
            this.Logs = logs;
            this.Metrics = metrics;
            this.Model = model;
            this.Output = output;
            this.Source = source;
            this.StartedAt = startedAt;
            this.Status = status;
            this.Urls = urls;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasTrainingResponse" /> class.
        /// </summary>
        public SchemasTrainingResponse()
        {
        }
    }
}