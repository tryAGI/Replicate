
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilesCreateRequest
    {
        /// <summary>
        /// The file content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Content { get; set; }

        /// <summary>
        /// The file content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Contentname { get; set; }

        /// <summary>
        /// The filename
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// User-provided metadata associated with the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The content / MIME type for the file<br/>
        /// Default Value: application/octet-stream
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesCreateRequest" /> class.
        /// </summary>
        /// <param name="content">
        /// The file content
        /// </param>
        /// <param name="contentname">
        /// The file content
        /// </param>
        /// <param name="filename">
        /// The filename
        /// </param>
        /// <param name="metadata">
        /// User-provided metadata associated with the file
        /// </param>
        /// <param name="type">
        /// The content / MIME type for the file<br/>
        /// Default Value: application/octet-stream
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilesCreateRequest(
            byte[] content,
            string contentname,
            string? filename,
            object? metadata,
            string? type)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Contentname = contentname ?? throw new global::System.ArgumentNullException(nameof(contentname));
            this.Filename = filename;
            this.Metadata = metadata;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesCreateRequest" /> class.
        /// </summary>
        public FilesCreateRequest()
        {
        }
    }
}