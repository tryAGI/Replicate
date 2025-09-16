#nullable enable

namespace Replicate
{
    public partial interface IReplicateApi
    {
        /// <summary>
        /// Search models, collections, and docs (beta)<br/>
        /// Search for public models, collections, and docs using a text query.<br/>
        /// For models, the response includes all model data, plus a new `metadata` object with the following fields:<br/>
        /// - `generated_description`: A longer and more detailed AI-generated description of the model<br/>
        /// - `tags`: An array of tags for the model<br/>
        /// - `score`: A score for the model's relevance to the search query<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   "https://api.replicate.com/v1/search?query=nano+banana"<br/>
        /// ```<br/>
        /// Note: This search API is currently in beta and may change in future versions.
        /// </summary>
        /// <param name="query">
        /// Example: nano banana
        /// </param>
        /// <param name="limit">
        /// Default Value: 20<br/>
        /// Example: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Replicate.SchemasSearchResponse> SearchAsync(
            string query,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}