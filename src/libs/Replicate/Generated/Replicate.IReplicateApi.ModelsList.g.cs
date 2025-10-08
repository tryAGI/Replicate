#nullable enable

namespace Replicate
{
    public partial interface IReplicateApi
    {
        /// <summary>
        /// List public models<br/>
        /// Get a paginated list of public models.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/models<br/>
        /// ```<br/>
        /// The response will be a pagination object containing a list of model objects.<br/>
        /// See the [`models.get`](#models.get) docs for more details about the model object.<br/>
        /// ## Sorting<br/>
        /// You can sort the results using the `sort_by` and `sort_direction` query parameters.<br/>
        /// For example, to get the most recently created models:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   "https://api.replicate.com/v1/models?sort_by=model_created_at&amp;sort_direction=desc"<br/>
        /// ```<br/>
        /// Available sorting options:<br/>
        /// - `model_created_at`: Sort by when the model was first created<br/>
        /// - `latest_version_created_at`: Sort by when the model's latest version was created (default)<br/>
        /// Sort direction can be `asc` (ascending) or `desc` (descending, default).
        /// </summary>
        /// <param name="sortBy">
        /// Default Value: latest_version_created_at
        /// </param>
        /// <param name="sortDirection">
        /// Default Value: desc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Replicate.SchemasPaginatedModelResponse> ModelsListAsync(
            global::Replicate.ModelsListSortBy? sortBy = default,
            global::Replicate.ModelsListSortDirection? sortDirection = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}