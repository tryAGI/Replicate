
#nullable enable

namespace Replicate
{
    /// <summary>
    /// The output of the training process
    /// </summary>
    public sealed partial class SchemasTrainingResponseOutput
    {
        /// <summary>
        /// The version of the model created by the training
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// The weights of the trained model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weights")]
        public string? Weights { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasTrainingResponseOutput" /> class.
        /// </summary>
        /// <param name="version">
        /// The version of the model created by the training
        /// </param>
        /// <param name="weights">
        /// The weights of the trained model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemasTrainingResponseOutput(
            string? version,
            string? weights)
        {
            this.Version = version;
            this.Weights = weights;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasTrainingResponseOutput" /> class.
        /// </summary>
        public SchemasTrainingResponseOutput()
        {
        }
    }
}