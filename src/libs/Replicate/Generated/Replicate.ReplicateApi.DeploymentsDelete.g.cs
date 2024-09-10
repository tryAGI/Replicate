
#nullable enable

namespace Replicate
{
    public partial class ReplicateApi
    {
        partial void PrepareDeploymentsDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string deploymentOwner,
            ref string deploymentName);
        partial void PrepareDeploymentsDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string deploymentOwner,
            string deploymentName);
        partial void ProcessDeploymentsDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Delete a deployment<br/>
        /// Delete a deployment<br/>
        /// Deployment deletion has some restrictions:<br/>
        /// - You can only delete deployments that have been offline and unused for at least 15 minutes.<br/>
        /// Example cURL request:<br/>
        /// ```command<br/>
        /// curl -s -X DELETE \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/deployments/acme/my-app-image-generator<br/>
        /// ```<br/>
        /// The response will be an empty 204, indicating the deployment has been deleted.
        /// </summary>
        /// <param name="deploymentOwner"></param>
        /// <param name="deploymentName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task DeploymentsDeleteAsync(
            string deploymentOwner,
            string deploymentName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeploymentsDeleteArguments(
                httpClient: _httpClient,
                deploymentOwner: ref deploymentOwner,
                deploymentName: ref deploymentName);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/deployments/{deploymentOwner}/{deploymentName}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeploymentsDeleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                deploymentOwner: deploymentOwner,
                deploymentName: deploymentName);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeploymentsDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}