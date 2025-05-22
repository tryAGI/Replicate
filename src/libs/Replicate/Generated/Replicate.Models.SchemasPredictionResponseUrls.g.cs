
#nullable enable

namespace Replicate
{
    /// <summary>
    /// URLs for working with the prediction
    /// </summary>
    public sealed partial class SchemasPredictionResponseUrls
    {
        /// <summary>
        /// Cancel the prediction via API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cancel { get; set; }

        /// <summary>
        /// Retrieve the latest state of the prediction via API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("get")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Get { get; set; }

        /// <summary>
        /// An event source to stream the output of the prediction via API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public string? Stream { get; set; }

        /// <summary>
        /// View the prediction in a browser
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Web { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasPredictionResponseUrls" /> class.
        /// </summary>
        /// <param name="cancel">
        /// Cancel the prediction via API
        /// </param>
        /// <param name="get">
        /// Retrieve the latest state of the prediction via API
        /// </param>
        /// <param name="stream">
        /// An event source to stream the output of the prediction via API
        /// </param>
        /// <param name="web">
        /// View the prediction in a browser
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemasPredictionResponseUrls(
            string cancel,
            string get,
            string web,
            string? stream)
        {
            this.Cancel = cancel ?? throw new global::System.ArgumentNullException(nameof(cancel));
            this.Get = get ?? throw new global::System.ArgumentNullException(nameof(get));
            this.Web = web ?? throw new global::System.ArgumentNullException(nameof(web));
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