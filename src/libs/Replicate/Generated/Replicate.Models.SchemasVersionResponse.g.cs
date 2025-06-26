
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SchemasVersionResponse
    {
        /// <summary>
        /// The version of Cog used to create this version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cog_version")]
        public string? CogVersion { get; set; }

        /// <summary>
        /// The date and time the version was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The ID of the version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The OpenAPI schema for the model's inputs and outputs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openapi_schema")]
        public object? OpenapiSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasVersionResponse" /> class.
        /// </summary>
        /// <param name="cogVersion">
        /// The version of Cog used to create this version
        /// </param>
        /// <param name="createdAt">
        /// The date and time the version was created
        /// </param>
        /// <param name="id">
        /// The ID of the version
        /// </param>
        /// <param name="openapiSchema">
        /// The OpenAPI schema for the model's inputs and outputs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemasVersionResponse(
            string? cogVersion,
            global::System.DateTime? createdAt,
            string? id,
            object? openapiSchema)
        {
            this.CogVersion = cogVersion;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.OpenapiSchema = openapiSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasVersionResponse" /> class.
        /// </summary>
        public SchemasVersionResponse()
        {
        }
    }
}