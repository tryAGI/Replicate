
#nullable enable

namespace Replicate
{
    /// <summary>
    /// A file resource
    /// </summary>
    public sealed partial class SchemasFileResponse
    {
        /// <summary>
        /// A dictionary of checksums for the file keyed by the algorithm name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checksums")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Replicate.SchemasFileResponseChecksums Checksums { get; set; }

        /// <summary>
        /// The content / MIME type of the file<br/>
        /// Example: application/zip
        /// </summary>
        /// <example>application/zip</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// When the file was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the file expires
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// A unique, randomly-generated identifier for the file resource<br/>
        /// Example: cneqzikepnug6xezperrr4z55o
        /// </summary>
        /// <example>cneqzikepnug6xezperrr4z55o</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Metadata provided by user when the file was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// The length of the file in bytes<br/>
        /// Example: 69420
        /// </summary>
        /// <example>69420</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// A dictionary of URLs associated with the file resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Replicate.SchemasFileResponseUrls Urls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasFileResponse" /> class.
        /// </summary>
        /// <param name="checksums">
        /// A dictionary of checksums for the file keyed by the algorithm name
        /// </param>
        /// <param name="contentType">
        /// The content / MIME type of the file<br/>
        /// Example: application/zip
        /// </param>
        /// <param name="createdAt">
        /// When the file was created
        /// </param>
        /// <param name="expiresAt">
        /// When the file expires
        /// </param>
        /// <param name="id">
        /// A unique, randomly-generated identifier for the file resource<br/>
        /// Example: cneqzikepnug6xezperrr4z55o
        /// </param>
        /// <param name="metadata">
        /// Metadata provided by user when the file was created
        /// </param>
        /// <param name="size">
        /// The length of the file in bytes<br/>
        /// Example: 69420
        /// </param>
        /// <param name="urls">
        /// A dictionary of URLs associated with the file resource
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemasFileResponse(
            global::Replicate.SchemasFileResponseChecksums checksums,
            string contentType,
            global::System.DateTime createdAt,
            global::System.DateTime expiresAt,
            string id,
            object metadata,
            int size,
            global::Replicate.SchemasFileResponseUrls urls)
        {
            this.Checksums = checksums ?? throw new global::System.ArgumentNullException(nameof(checksums));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Size = size;
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasFileResponse" /> class.
        /// </summary>
        public SchemasFileResponse()
        {
        }
    }
}