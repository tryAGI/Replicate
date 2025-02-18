
#nullable enable

namespace Replicate
{
    /// <summary>
    /// API endpoints for working with the prediction
    /// </summary>
    public sealed partial class SchemasPredictionResponseUrls
    {
        /// <summary>
        /// Cancel the prediction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cancel { get; set; }

        /// <summary>
        /// Retrieve the latest state of the prediction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("get")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Get { get; set; }

        /// <summary>
        /// An event source to stream the output of the prediction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public string? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasPredictionResponseUrls" /> class.
        /// </summary>
        /// <param name="cancel">
        /// Cancel the prediction
        /// </param>
        /// <param name="get">
        /// Retrieve the latest state of the prediction
        /// </param>
        /// <param name="stream">
        /// An event source to stream the output of the prediction
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemasPredictionResponseUrls(
            string cancel,
            string get,
            string? stream)
        {
            this.Cancel = cancel ?? throw new global::System.ArgumentNullException(nameof(cancel));
            this.Get = get ?? throw new global::System.ArgumentNullException(nameof(get));
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasPredictionResponseUrls" /> class.
        /// </summary>
        public SchemasPredictionResponseUrls()
        {
        }
    }
}