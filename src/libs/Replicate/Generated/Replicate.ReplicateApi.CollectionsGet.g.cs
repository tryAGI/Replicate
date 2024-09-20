
#nullable enable

namespace Replicate
{
    public partial class ReplicateApi
    {
        partial void PrepareCollectionsGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string collectionSlug);
        partial void PrepareCollectionsGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string collectionSlug);
        partial void ProcessCollectionsGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Get a collection of models<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/collections/super-resolution<br/>
        /// ```<br/>
        /// The response will be a collection object with a nested list of the models in that collection:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "name": "Super resolution",<br/>
        ///   "slug": "super-resolution",<br/>
        ///   "description": "Upscaling models that create high-quality images from low-quality images.",<br/>
        ///   "models": [...]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="collectionSlug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CollectionsGetAsync(
            string collectionSlug,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareCollectionsGetArguments(
                httpClient: _httpClient,
                collectionSlug: ref collectionSlug);

            var __pathBuilder = new PathBuilder(
                path: $"/collections/{collectionSlug}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCollectionsGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                collectionSlug: collectionSlug);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCollectionsGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}