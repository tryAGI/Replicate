#nullable enable

namespace Replicate
{
    public partial interface IReplicateApi
    {
        /// <summary>
        /// Delete a file<br/>
        /// Delete a file. Once a file has been deleted, subsequent requests to the file resource return 404 Not found.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -X DELETE \<br/>
        ///   -H "Authorization: Token $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/files/cneqzikepnug6xezperrr4z55o<br/>
        /// ```
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        global::System.Threading.Tasks.Task FilesDeleteAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}