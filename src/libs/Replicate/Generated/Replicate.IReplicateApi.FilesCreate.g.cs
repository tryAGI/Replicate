#nullable enable

namespace Replicate
{
    public partial interface IReplicateApi
    {
        /// <summary>
        /// Create a file<br/>
        /// Create a file by uploading its content and optional metadata.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -X POST https://api.replicate.com/v1/files \<br/>
        ///   -H "Authorization: Token $REPLICATE_API_TOKEN" \<br/>
        ///   -H 'Content-Type: multipart/form-data' \<br/>
        ///   -F 'content=@/path/to/archive.zip;type=application/zip;filename=example.zip' \<br/>
        ///   -F 'metadata={"customer_reference_id": 123};type=application/json'<br/>
        /// ```<br/>
        /// The request must include:<br/>
        /// - `content`: The file content (required)<br/>
        /// - `type`: The content / MIME type for the file (defaults to `application/octet-stream`)<br/>
        /// - `filename`: The filename (required, ≤ 255 bytes, valid UTF-8)<br/>
        /// - `metadata`: User-provided metadata associated with the file (defaults to `{}`, must be valid JSON)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Replicate.SchemasFileResponse> FilesCreateAsync(
            global::Replicate.FilesCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a file<br/>
        /// Create a file by uploading its content and optional metadata.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -X POST https://api.replicate.com/v1/files \<br/>
        ///   -H "Authorization: Token $REPLICATE_API_TOKEN" \<br/>
        ///   -H 'Content-Type: multipart/form-data' \<br/>
        ///   -F 'content=@/path/to/archive.zip;type=application/zip;filename=example.zip' \<br/>
        ///   -F 'metadata={"customer_reference_id": 123};type=application/json'<br/>
        /// ```<br/>
        /// The request must include:<br/>
        /// - `content`: The file content (required)<br/>
        /// - `type`: The content / MIME type for the file (defaults to `application/octet-stream`)<br/>
        /// - `filename`: The filename (required, ≤ 255 bytes, valid UTF-8)<br/>
        /// - `metadata`: User-provided metadata associated with the file (defaults to `{}`, must be valid JSON)
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Replicate.SchemasFileResponse> FilesCreateAsync(
            byte[] content,
            string contentname,
            string? filename = default,
            object? metadata = default,
            string? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}