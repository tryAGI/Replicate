
#nullable enable

namespace Replicate
{
    /// <summary>
    /// A dictionary of URLs associated with the file resource
    /// </summary>
    public sealed partial class SchemasFileResponseUrls
    {
        /// <summary>
        /// A URL to the file resource<br/>
        /// Example: https://api.replicate.com/v1/files/cneqzikepnug6xezperrr4z55o
        /// </summary>
        /// <example>https://api.replicate.com/v1/files/cneqzikepnug6xezperrr4z55o</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("get")]
        public string? Get { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasFileResponseUrls" /> class.
        /// </summary>
        /// <param name="get">
        /// A URL to the file resource<br/>
        /// Example: https://api.replicate.com/v1/files/cneqzikepnug6xezperrr4z55o
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemasFileResponseUrls(
            string? get)
        {
            this.Get = get;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasFileResponseUrls" /> class.
        /// </summary>
        public SchemasFileResponseUrls()
        {
        }
    }
}