
#nullable enable

namespace Replicate
{
    /// <summary>
    /// URLs for interacting with the training
    /// </summary>
    public sealed partial class SchemasTrainingResponseUrls
    {
        /// <summary>
        /// URL to cancel the training
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel")]
        public string? Cancel { get; set; }

        /// <summary>
        /// URL to get the training details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("get")]
        public string? Get { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasTrainingResponseUrls" /> class.
        /// </summary>
        /// <param name="cancel">
        /// URL to cancel the training
        /// </param>
        /// <param name="get">
        /// URL to get the training details
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemasTrainingResponseUrls(
            string? cancel,
            string? get)
        {
            this.Cancel = cancel;
            this.Get = get;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasTrainingResponseUrls" /> class.
        /// </summary>
        public SchemasTrainingResponseUrls()
        {
        }
    }
}