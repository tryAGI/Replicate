
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilesDeleteResponse
    {
        /// <summary>
        /// Example: File not found
        /// </summary>
        /// <example>File not found</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesDeleteResponse" /> class.
        /// </summary>
        /// <param name="detail">
        /// Example: File not found
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilesDeleteResponse(
            string? detail)
        {
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesDeleteResponse" /> class.
        /// </summary>
        public FilesDeleteResponse()
        {
        }
    }
}