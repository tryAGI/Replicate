#nullable enable

namespace Replicate
{
    public partial interface IReplicateApi
    {
        /// <summary>
        /// Update metadata for a model<br/>
        /// Update select properties of an existing model.<br/>
        /// You can update the following properties:<br/>
        ///   - `description` - Model description<br/>
        ///   - `readme` - Model README content<br/>
        ///   - `github_url` - GitHub repository URL<br/>
        ///   - `paper_url` - Research paper URL<br/>
        ///   - `weights_url` - Model weights URL<br/>
        ///   - `license_url` - License URL<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -X PATCH \<br/>
        ///   https://api.replicate.com/v1/models/your-username/your-model-name \<br/>
        ///   -H "Authorization: Token $REPLICATE_API_TOKEN" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "description": "Detect hot dogs in images",<br/>
        ///     "readme": "# Hot Dog Detector\n\n🌭 Ketchup, mustard, and onions...",<br/>
        ///     "github_url": "https://github.com/alice/hot-dog-detector",<br/>
        ///     "paper_url": "https://arxiv.org/abs/2504.17639",<br/>
        ///     "weights_url": "https://huggingface.co/alice/hot-dog-detector",<br/>
        ///     "license_url": "https://choosealicense.com/licenses/mit/"<br/>
        ///   }'<br/>
        /// ```<br/>
        /// The response will be the updated model object with all of its properties.
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Replicate.SchemasModelResponse> ModelsUpdateAsync(
            string modelOwner,
            string modelName,
            global::Replicate.ModelsUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update metadata for a model<br/>
        /// Update select properties of an existing model.<br/>
        /// You can update the following properties:<br/>
        ///   - `description` - Model description<br/>
        ///   - `readme` - Model README content<br/>
        ///   - `github_url` - GitHub repository URL<br/>
        ///   - `paper_url` - Research paper URL<br/>
        ///   - `weights_url` - Model weights URL<br/>
        ///   - `license_url` - License URL<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -X PATCH \<br/>
        ///   https://api.replicate.com/v1/models/your-username/your-model-name \<br/>
        ///   -H "Authorization: Token $REPLICATE_API_TOKEN" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "description": "Detect hot dogs in images",<br/>
        ///     "readme": "# Hot Dog Detector\n\n🌭 Ketchup, mustard, and onions...",<br/>
        ///     "github_url": "https://github.com/alice/hot-dog-detector",<br/>
        ///     "paper_url": "https://arxiv.org/abs/2504.17639",<br/>
        ///     "weights_url": "https://huggingface.co/alice/hot-dog-detector",<br/>
        ///     "license_url": "https://choosealicense.com/licenses/mit/"<br/>
        ///   }'<br/>
        /// ```<br/>
        /// The response will be the updated model object with all of its properties.
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="description">
        /// A description of the model.<br/>
        /// Example: Detect hot dogs in images
        /// </param>
        /// <param name="githubUrl">
        /// A URL for the model's source code on GitHub.<br/>
        /// Example: https://github.com/alice/hot-dog-detector
        /// </param>
        /// <param name="licenseUrl">
        /// A URL for the model's license.
        /// </param>
        /// <param name="paperUrl">
        /// A URL for the model's paper.<br/>
        /// Example: https://arxiv.org/abs/2504.17639
        /// </param>
        /// <param name="readme">
        /// The README content of the model.<br/>
        /// Example: # Updated README<br/>
        /// New content here
        /// </param>
        /// <param name="weightsUrl">
        /// A URL for the model's weights.<br/>
        /// Example: https://huggingface.co/alice/hot-dog-detector
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Replicate.SchemasModelResponse> ModelsUpdateAsync(
            string modelOwner,
            string modelName,
            string? description = default,
            string? githubUrl = default,
            string? licenseUrl = default,
            string? paperUrl = default,
            string? readme = default,
            string? weightsUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}