
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilesCreateResponse
    {
        /// <summary>
        /// Example: Files must be less than 100MB in size
        /// </summary>
        /// <example>Files must be less than 100MB in size</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesCreateResponse" /> class.
        /// </summary>
        /// <param name="detail">
        /// Example: Files must be less than 100MB in size
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilesCreateResponse(
            string? detail)
        {
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesCreateResponse" /> class.
        /// </summary>
        public FilesCreateResponse()
        {
        }
    }
}