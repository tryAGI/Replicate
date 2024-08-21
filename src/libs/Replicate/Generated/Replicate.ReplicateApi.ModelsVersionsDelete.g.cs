
#nullable enable

namespace Replicate
{
    public partial class ReplicateApi
    {
        partial void PrepareModelsVersionsDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string modelOwner,
            ref string modelName,
            ref string versionId);
        partial void PrepareModelsVersionsDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string modelOwner,
            string modelName,
            string versionId);
        partial void ProcessModelsVersionsDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Delete a model version<br/>
        /// Delete a model version and all associated predictions, including all output files.<br/>
        /// Model version deletion has some restrictions:<br/>
        /// - You can only delete versions from models you own.<br/>
        /// - You can only delete versions from private models.<br/>
        /// - You cannot delete a version if someone other than you has run predictions with it.<br/>
        /// - You cannot delete a version if it is being used as the base model for a fine tune/training.<br/>
        /// - You cannot delete a version if it has an associated deployment.<br/>
        /// - You cannot delete a version if another model version is overridden to use it.<br/>
        /// Example cURL request:<br/>
        /// ```command<br/>
        /// curl -s -X DELETE \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa<br/>
        /// ```<br/>
        /// The response will be an empty 202, indicating the deletion request has been accepted. It might take a few minutes to be processed.
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ModelsVersionsDeleteAsync(
            string modelOwner,
            string modelName,
            string versionId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareModelsVersionsDeleteArguments(
                httpClient: _httpClient,
                modelOwner: ref modelOwner,
                modelName: ref modelName,
                versionId: ref versionId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/models/{modelOwner}/{modelName}/versions/{versionId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareModelsVersionsDeleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                modelOwner: modelOwner,
                modelName: modelName,
                versionId: versionId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessModelsVersionsDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}