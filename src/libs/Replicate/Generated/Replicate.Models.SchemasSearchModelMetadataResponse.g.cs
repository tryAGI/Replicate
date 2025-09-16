
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SchemasSearchModelMetadataResponse
    {
        /// <summary>
        /// AI-generated detailed description of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_description")]
        public string? GeneratedDescription { get; set; }

        /// <summary>
        /// Search relevance score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Array of descriptive tags for the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasSearchModelMetadataResponse" /> class.
        /// </summary>
        /// <param name="generatedDescription">
        /// AI-generated detailed description of the model
        /// </param>
        /// <param name="score">
        /// Search relevance score
        /// </param>
        /// <param name="tags">
        /// Array of descriptive tags for the model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemasSearchModelMetadataResponse(
            string? generatedDescription,
            double? score,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.GeneratedDescription = generatedDescription;
            this.Score = score;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasSearchModelMetadataResponse" /> class.
        /// </summary>
        public SchemasSearchModelMetadataResponse()
        {
        }
    }
}