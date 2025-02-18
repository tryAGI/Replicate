
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionsListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        public string? Previous { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Replicate.SchemasPredictionResponse>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionsListResponse" /> class.
        /// </summary>
        /// <param name="next"></param>
        /// <param name="previous"></param>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PredictionsListResponse(
            string? next,
            string? previous,
            global::System.Collections.Generic.IList<global::Replicate.SchemasPredictionResponse>? results)
        {
            this.Next = next;
            this.Previous = previous;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionsListResponse" /> class.
        /// </summary>
        public PredictionsListResponse()
        {
        }
    }
}