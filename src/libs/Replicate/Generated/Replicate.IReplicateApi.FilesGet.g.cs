#nullable enable

namespace Replicate
{
    public partial interface IReplicateApi
    {
        /// <summary>
        /// Get a file<br/>
        /// Get the details of a file.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Token $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/files/cneqzikepnug6xezperrr4z55o<br/>
        /// ```
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Replicate.SchemasFileResponse> FilesGetAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}