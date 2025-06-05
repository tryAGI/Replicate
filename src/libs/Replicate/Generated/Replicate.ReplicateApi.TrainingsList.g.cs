
#nullable enable

namespace Replicate
{
    public partial class ReplicateApi
    {
        partial void PrepareTrainingsListArguments(
            global::System.Net.Http.HttpClient httpClient);
        partial void PrepareTrainingsListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage);
        partial void ProcessTrainingsListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTrainingsListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List trainings<br/>
        /// Get a paginated list of all trainings created by the user or organization associated with the provided API token.<br/>
        /// This will include trainings created from the API and the website. It will return 100 records per page.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/trainings<br/>
        /// ```<br/>
        /// The response will be a paginated JSON array of training objects, sorted with the most recent training first:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "next": null,<br/>
        ///   "previous": null,<br/>
        ///   "results": [<br/>
        ///     {<br/>
        ///       "completed_at": "2023-09-08T16:41:19.826523Z",<br/>
        ///       "created_at": "2023-09-08T16:32:57.018467Z",<br/>
        ///       "error": null,<br/>
        ///       "id": "zz4ibbonubfz7carwiefibzgga",<br/>
        ///       "input": {<br/>
        ///         "input_images": "https://example.com/my-input-images.zip"<br/>
        ///       },<br/>
        ///       "metrics": {<br/>
        ///         "predict_time": 502.713876<br/>
        ///       },<br/>
        ///       "output": {<br/>
        ///         "version": "...",<br/>
        ///         "weights": "..."<br/>
        ///       },<br/>
        ///       "started_at": "2023-09-08T16:32:57.112647Z",<br/>
        ///       "source": "api",<br/>
        ///       "status": "succeeded",<br/>
        ///       "urls": {<br/>
        ///         "web": "https://replicate.com/p/zz4ibbonubfz7carwiefibzgga",<br/>
        ///         "get": "https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga",<br/>
        ///         "cancel": "https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel"<br/>
        ///       },<br/>
        ///       "model": "stability-ai/sdxl",<br/>
        ///       "version": "da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf",<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// `id` will be the unique ID of the training.<br/>
        /// `source` will indicate how the training was created. Possible values are `web` or `api`.<br/>
        /// `status` will be the status of the training. Refer to [get a single training](#trainings.get) for possible values.<br/>
        /// `urls` will be a convenience object that can be used to construct new API requests for the given training.<br/>
        /// `version` will be the unique ID of model version used to create the training.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Replicate.TrainingsListResponse> TrainingsListAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareTrainingsListArguments(
                httpClient: HttpClient);

            var __pathBuilder = new global::Replicate.PathBuilder(
                path: "/trainings",
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
            PrepareTrainingsListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTrainingsListResponse(
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
                ProcessTrainingsListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
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

                return
                    global::Replicate.TrainingsListResponse.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                return
                    await global::Replicate.TrainingsListResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}