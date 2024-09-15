#nullable enable

namespace Replicate
{
    public partial interface IReplicateApi
    {
        /// <summary>
        /// Get the authenticated account<br/>
        /// Returns information about the user or organization associated with the provided API token.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/account<br/>
        /// ```<br/>
        /// The response will be a JSON object describing the account:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "organization",<br/>
        ///   "username": "acme",<br/>
        ///   "name": "Acme Corp, Inc.",<br/>
        ///   "github_url": "https://github.com/acme",<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Replicate.AccountGetResponse> AccountGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}