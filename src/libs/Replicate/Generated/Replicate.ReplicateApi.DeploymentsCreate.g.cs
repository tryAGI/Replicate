
#nullable enable

namespace Replicate
{
    public partial class ReplicateApi
    {
        partial void PrepareDeploymentsCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Replicate.DeploymentsCreateRequest request);
        partial void PrepareDeploymentsCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Replicate.DeploymentsCreateRequest request);
        partial void ProcessDeploymentsCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeploymentsCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a deployment<br/>
        /// Create a new deployment:<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -X POST \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///         "name": "my-app-image-generator",<br/>
        ///         "model": "stability-ai/sdxl",<br/>
        ///         "version": "da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf",<br/>
        ///         "hardware": "gpu-t4",<br/>
        ///         "min_instances": 0,<br/>
        ///         "max_instances": 3<br/>
        ///       }' \<br/>
        ///   https://api.replicate.com/v1/deployments<br/>
        /// ```<br/>
        /// The response will be a JSON object describing the deployment:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "owner": "acme",<br/>
        ///   "name": "my-app-image-generator",<br/>
        ///   "current_release": {<br/>
        ///     "number": 1,<br/>
        ///     "model": "stability-ai/sdxl",<br/>
        ///     "version": "da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf",<br/>
        ///     "created_at": "2024-02-15T16:32:57.018467Z",<br/>
        ///     "created_by": {<br/>
        ///       "type": "organization",<br/>
        ///       "username": "acme",<br/>
        ///       "name": "Acme Corp, Inc.",<br/>
        ///       "github_url": "https://github.com/acme",<br/>
        ///     },<br/>
        ///     "configuration": {<br/>
        ///       "hardware": "gpu-t4",<br/>
        ///       "min_instances": 1,<br/>
        ///       "max_instances": 5<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Replicate.DeploymentsCreateResponse> DeploymentsCreateAsync(
            global::Replicate.DeploymentsCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareDeploymentsCreateArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/deployments",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDeploymentsCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDeploymentsCreateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessDeploymentsCreateResponseContent(
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
                    global::Replicate.DeploymentsCreateResponse.FromJson(__content, JsonSerializerContext) ??
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

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::Replicate.DeploymentsCreateResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Create a deployment<br/>
        /// Create a new deployment:<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -X POST \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///         "name": "my-app-image-generator",<br/>
        ///         "model": "stability-ai/sdxl",<br/>
        ///         "version": "da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf",<br/>
        ///         "hardware": "gpu-t4",<br/>
        ///         "min_instances": 0,<br/>
        ///         "max_instances": 3<br/>
        ///       }' \<br/>
        ///   https://api.replicate.com/v1/deployments<br/>
        /// ```<br/>
        /// The response will be a JSON object describing the deployment:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "owner": "acme",<br/>
        ///   "name": "my-app-image-generator",<br/>
        ///   "current_release": {<br/>
        ///     "number": 1,<br/>
        ///     "model": "stability-ai/sdxl",<br/>
        ///     "version": "da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf",<br/>
        ///     "created_at": "2024-02-15T16:32:57.018467Z",<br/>
        ///     "created_by": {<br/>
        ///       "type": "organization",<br/>
        ///       "username": "acme",<br/>
        ///       "name": "Acme Corp, Inc.",<br/>
        ///       "github_url": "https://github.com/acme",<br/>
        ///     },<br/>
        ///     "configuration": {<br/>
        ///       "hardware": "gpu-t4",<br/>
        ///       "min_instances": 1,<br/>
        ///       "max_instances": 5<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="hardware">
        /// The SKU for the hardware used to run the model. Possible values can be retrieved from the `hardware.list` endpoint.
        /// </param>
        /// <param name="maxInstances">
        /// The maximum number of instances for scaling.
        /// </param>
        /// <param name="minInstances">
        /// The minimum number of instances for scaling.
        /// </param>
        /// <param name="model">
        /// The full name of the model that you want to deploy e.g. stability-ai/sdxl.
        /// </param>
        /// <param name="name">
        /// The name of the deployment.
        /// </param>
        /// <param name="version">
        /// The 64-character string ID of the model version that you want to deploy.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Replicate.DeploymentsCreateResponse> DeploymentsCreateAsync(
            string hardware,
            int maxInstances,
            int minInstances,
            string model,
            string name,
            string version,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Replicate.DeploymentsCreateRequest
            {
                Hardware = hardware,
                MaxInstances = maxInstances,
                MinInstances = minInstances,
                Model = model,
                Name = name,
                Version = version,
            };

            return await DeploymentsCreateAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}