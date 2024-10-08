
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

        /// <summary>
        /// List trainings<br/>
        /// Get a paginated list of trainings that you've created. This will include trainings created from the API and the website. It will return 100 records per page.<br/>
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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task TrainingsListAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareTrainingsListArguments(
                httpClient: _httpClient);

            var __pathBuilder = new PathBuilder(
                path: "/trainings",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTrainingsListRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTrainingsListResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}