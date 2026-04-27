#nullable enable

namespace Replicate
{
    public partial interface IReplicateClient
    {
        /// <summary>
        /// Download a file<br/>
        /// Download a file by providing the file owner, access expiry, and a valid signature.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -X GET "https://api.replicate.com/v1/files/cneqzikepnug6xezperrr4z55o/download?expiry=1708515345&amp;owner=mattt&amp;signature=zuoghqlrcnw8YHywkpaXQlHsVhWen%2FDZ4aal76dLiOo%3D"<br/>
        /// ```
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="owner"></param>
        /// <param name="expiry"></param>
        /// <param name="signature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> FilesDownloadAsync(
            string fileId,
            string owner,
            long expiry,
            string signature,
            global::Replicate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}