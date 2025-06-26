
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SchemasPaginatedPredictionResponse
    {
        /// <summary>
        /// A URL pointing to the next page of prediction objects, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// A URL pointing to the previous page of prediction objects, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        public string? Previous { get; set; }

        /// <summary>
        /// An array of prediction objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Replicate.SchemasPredictionResponse>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasPaginatedPredictionResponse" /> class.
        /// </summary>
        /// <param name="next">
        /// A URL pointing to the next page of prediction objects, if any
        /// </param>
        /// <param name="previous">
        /// A URL pointing to the previous page of prediction objects, if any
        /// </param>
        /// <param name="results">
        /// An array of prediction objects
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemasPaginatedPredictionResponse(
            string? next,
            string? previous,
            global::System.Collections.Generic.IList<global::Replicate.SchemasPredictionResponse>? results)
        {
            this.Next = next;
            this.Previous = previous;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasPaginatedPredictionResponse" /> class.
        /// </summary>
        public SchemasPaginatedPredictionResponse()
        {
        }
    }
}