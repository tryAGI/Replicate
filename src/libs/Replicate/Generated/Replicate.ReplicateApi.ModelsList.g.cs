
#nullable enable

namespace Replicate
{
    public partial class ReplicateApi
    {
        partial void PrepareModelsListArguments(
            global::System.Net.Http.HttpClient httpClient);
        partial void PrepareModelsListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage);
        partial void ProcessModelsListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// List public models<br/>
        /// Get a paginated list of public models.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/models<br/>
        /// ```<br/>
        /// The response will be a paginated JSON array of model objects:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "next": null,<br/>
        ///   "previous": null,<br/>
        ///   "results": [<br/>
        ///     {<br/>
        ///       "url": "https://replicate.com/acme/hello-world",<br/>
        ///       "owner": "acme",<br/>
        ///       "name": "hello-world",<br/>
        ///       "description": "A tiny model that says hello",<br/>
        ///       "visibility": "public",<br/>
        ///       "github_url": "https://github.com/replicate/cog-examples",<br/>
        ///       "paper_url": null,<br/>
        ///       "license_url": null,<br/>
        ///       "run_count": 5681081,<br/>
        ///       "cover_image_url": "...",<br/>
        ///       "default_example": {...},<br/>
        ///       "latest_version": {...}<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// The `cover_image_url` string is an HTTPS URL for an image file. This can be:<br/>
        /// - An image uploaded by the model author.<br/>
        /// - The output file of the example prediction, if the model author has not set a cover image.<br/>
        /// - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file.<br/>
        /// - A generic fallback image.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ModelsListAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareModelsListArguments(
                httpClient: HttpClient);

            var __pathBuilder = new PathBuilder(
                path: "/models",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareModelsListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessModelsListResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::Replicate.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
        }
    }
}