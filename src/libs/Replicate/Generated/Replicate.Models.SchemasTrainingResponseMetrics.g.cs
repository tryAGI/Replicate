
#nullable enable

namespace Replicate
{
    /// <summary>
    /// Metrics about the training process
    /// </summary>
    public sealed partial class SchemasTrainingResponseMetrics
    {
        /// <summary>
        /// The amount of CPU or GPU time, in seconds, that the training used while running
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predict_time")]
        public double? PredictTime { get; set; }

        /// <summary>
        /// The total time, in seconds, that the training took to complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_time")]
        public double? TotalTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasTrainingResponseMetrics" /> class.
        /// </summary>
        /// <param name="predictTime">
        /// The amount of CPU or GPU time, in seconds, that the training used while running
        /// </param>
        /// <param name="totalTime">
        /// The total time, in seconds, that the training took to complete
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemasTrainingResponseMetrics(
            double? predictTime,
            double? totalTime)
        {
            this.PredictTime = predictTime;
            this.TotalTime = totalTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasTrainingResponseMetrics" /> class.
        /// </summary>
        public SchemasTrainingResponseMetrics()
        {
        }
    }
}