#nullable enable

namespace Replicate
{
    public partial interface IReplicateClient
    {
        /// <summary>
        /// List files<br/>
        /// Get a paginated list of all files created by the user or organization associated with the provided API token.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Token $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/files<br/>
        /// ```<br/>
        /// The response will be a paginated JSON array of file objects, sorted with the most recent file first.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Replicate.FilesListResponse> FilesListAsync(
            global::Replicate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}