
#nullable enable

namespace Replicate
{
    /// <summary>
    /// A dictionary of checksums for the file keyed by the algorithm name
    /// </summary>
    public sealed partial class SchemasFileResponseChecksums
    {
        /// <summary>
        /// SHA256 checksum of the file<br/>
        /// Example: f047f8e745f9996c6e386064e06cb2007b8e6bc0a968a334fc0d2b2d64012066
        /// </summary>
        /// <example>f047f8e745f9996c6e386064e06cb2007b8e6bc0a968a334fc0d2b2d64012066</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha256")]
        public string? Sha256 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasFileResponseChecksums" /> class.
        /// </summary>
        /// <param name="sha256">
        /// SHA256 checksum of the file<br/>
        /// Example: f047f8e745f9996c6e386064e06cb2007b8e6bc0a968a334fc0d2b2d64012066
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemasFileResponseChecksums(
            string? sha256)
        {
            this.Sha256 = sha256;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasFileResponseChecksums" /> class.
        /// </summary>
        public SchemasFileResponseChecksums()
        {
        }
    }
}