
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainingsListResponse
    {
        /// <summary>
        /// URL to the next page of results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// URL to the previous page of results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        public string? Previous { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Replicate.SchemasTrainingResponse>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingsListResponse" /> class.
        /// </summary>
        /// <param name="next">
        /// URL to the next page of results
        /// </param>
        /// <param name="previous">
        /// URL to the previous page of results
        /// </param>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingsListResponse(
            string? next,
            string? previous,
            global::System.Collections.Generic.IList<global::Replicate.SchemasTrainingResponse>? results)
        {
            this.Next = next;
            this.Previous = previous;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingsListResponse" /> class.
        /// </summary>
        public TrainingsListResponse()
        {
        }
    }
}