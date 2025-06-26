
#nullable enable

namespace Replicate
{
    public partial class ReplicateApi
    {
        partial void PrepareModelsExamplesListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string modelOwner,
            ref string modelName);
        partial void PrepareModelsExamplesListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string modelOwner,
            string modelName);
        partial void ProcessModelsExamplesListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessModelsExamplesListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List examples for a model<br/>
        /// List [example predictions](https://replicate.com/docs/topics/models/publish-a-model#what-are-examples) made using the model.<br/>
        /// These are predictions that were saved by the model author as illustrative examples of the model's capabilities.<br/>
        /// If you want all the examples for a model, use this operation.<br/>
        /// If you just want the model's default example, you can use the [`models.get`](#models.get) operation instead, which includes a `default_example` object.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/models/replicate/hello-world/examples<br/>
        /// ```<br/>
        /// The response will be a pagination object containing a list of example predictions:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "next": "https://api.replicate.com/v1/models/replicate/hello-world/examples?cursor=...",<br/>
        ///   "previous": "https://api.replicate.com/v1/models/replicate/hello-world/examples?cursor=...",<br/>
        ///   "results": [...]<br/>
        /// }<br/>
        /// ```<br/>
        /// Each item in the `results` list is a [prediction object](#predictions.get).
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Replicate.SchemasPaginatedPredictionResponse> ModelsExamplesListAsync(
            string modelOwner,
            string modelName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareModelsExamplesListArguments(
                httpClient: HttpClient,
                modelOwner: ref modelOwner,
                modelName: ref modelName);

            var __pathBuilder = new global::Replicate.PathBuilder(
                path: $"/models/{modelOwner}/{modelName}/examples",
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
            PrepareModelsExamplesListRequest(
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
            ProcessModelsExamplesListResponse(
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
                ProcessModelsExamplesListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Replicate.SchemasPaginatedPredictionResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
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

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Replicate.SchemasPaginatedPredictionResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
}