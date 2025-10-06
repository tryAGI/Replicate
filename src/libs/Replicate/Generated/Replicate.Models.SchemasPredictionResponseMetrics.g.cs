
#nullable enable

namespace Replicate
{
    /// <summary>
    /// Additional metrics associated with the prediction
    /// </summary>
    public sealed partial class SchemasPredictionResponseMetrics
    {
        /// <summary>
        /// The total time, in seconds, that the prediction took to complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_time")]
        public double? TotalTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasPredictionResponseMetrics" /> class.
        /// </summary>
        /// <param name="totalTime">
        /// The total time, in seconds, that the prediction took to complete
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemasPredictionResponseMetrics(
            double? totalTime)
        {
            this.TotalTime = totalTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasPredictionResponseMetrics" /> class.
        /// </summary>
        public SchemasPredictionResponseMetrics()
        {
        }
    }
}