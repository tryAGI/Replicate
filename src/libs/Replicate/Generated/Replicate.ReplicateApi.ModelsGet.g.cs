
#nullable enable

namespace Replicate
{
    public partial class ReplicateApi
    {
        partial void PrepareModelsGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string modelOwner,
            ref string modelName);
        partial void PrepareModelsGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string modelOwner,
            string modelName);
        partial void ProcessModelsGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Get a model<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/models/replicate/hello-world<br/>
        /// ```<br/>
        /// The response will be a model object in the following format:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "url": "https://replicate.com/replicate/hello-world",<br/>
        ///   "owner": "replicate",<br/>
        ///   "name": "hello-world",<br/>
        ///   "description": "A tiny model that says hello",<br/>
        ///   "visibility": "public",<br/>
        ///   "github_url": "https://github.com/replicate/cog-examples",<br/>
        ///   "paper_url": null,<br/>
        ///   "license_url": null,<br/>
        ///   "run_count": 5681081,<br/>
        ///   "cover_image_url": "...",<br/>
        ///   "default_example": {...},<br/>
        ///   "latest_version": {...},<br/>
        /// }<br/>
        /// ```<br/>
        /// The model object includes the [input and output schema](https://replicate.com/docs/reference/openapi#model-schemas) for the latest version of the model.<br/>
        /// Here's an example showing how to fetch the model with cURL and display its input schema with [jq](https://stedolan.github.io/jq/):<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///     -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///     https://api.replicate.com/v1/models/replicate/hello-world \<br/>
        ///     | jq ".latest_version.openapi_schema.components.schemas.Input"<br/>
        /// ```<br/>
        /// This will return the following JSON object:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "object",<br/>
        ///   "title": "Input",<br/>
        ///   "required": [<br/>
        ///     "text"<br/>
        ///   ],<br/>
        ///   "properties": {<br/>
        ///     "text": {<br/>
        ///       "type": "string",<br/>
        ///       "title": "Text",<br/>
        ///       "x-order": 0,<br/>
        ///       "description": "Text to prefix with 'hello '"<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ``` <br/>
        /// The `cover_image_url` string is an HTTPS URL for an image file. This can be:<br/>
        /// - An image uploaded by the model author.<br/>
        /// - The output file of the example prediction, if the model author has not set a cover image.<br/>
        /// - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file.<br/>
        /// - A generic fallback image.<br/>
        /// The `default_example` object is a [prediction](#predictions.get) created with this model.<br/>
        /// The `latest_version` object is the model's most recently pushed [version](#models.versions.get).
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ModelsGetAsync(
            string modelOwner,
            string modelName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareModelsGetArguments(
                httpClient: HttpClient,
                modelOwner: ref modelOwner,
                modelName: ref modelName);

            var __pathBuilder = new global::Replicate.PathBuilder(
                path: $"/models/{modelOwner}/{modelName}",
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
            PrepareModelsGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                modelOwner: modelOwner,
                modelName: modelName);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessModelsGetResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Replicate.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

            }
            else
            {
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

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

            }
        }
    }
}