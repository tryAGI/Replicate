
#nullable enable

namespace Replicate
{
    public partial class ReplicateApi
    {
        partial void PrepareModelsUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string modelOwner,
            ref string modelName,
            global::Replicate.ModelsUpdateRequest request);
        partial void PrepareModelsUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string modelOwner,
            string modelName,
            global::Replicate.ModelsUpdateRequest request);
        partial void ProcessModelsUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessModelsUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::Replicate.SchemasModelResponse> ModelsUpdateAsync(
            string modelOwner,
            string modelName,
            global::Replicate.ModelsUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareModelsUpdateArguments(
                httpClient: HttpClient,
                modelOwner: ref modelOwner,
                modelName: ref modelName,
                request: request);

            var __pathBuilder = new global::Replicate.PathBuilder(
                path: $"/models/{modelOwner}/{modelName}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareModelsUpdateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                modelOwner: modelOwner,
                modelName: modelName,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessModelsUpdateResponse(
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
                ProcessModelsUpdateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Replicate.SchemasModelResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Replicate.SchemasModelResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        public async global::System.Threading.Tasks.Task<global::Replicate.SchemasModelResponse> ModelsUpdateAsync(
            string modelOwner,
            string modelName,
            string? description = default,
            string? githubUrl = default,
            string? licenseUrl = default,
            string? paperUrl = default,
            string? readme = default,
            string? weightsUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Replicate.ModelsUpdateRequest
            {
                Description = description,
                GithubUrl = githubUrl,
                LicenseUrl = licenseUrl,
                PaperUrl = paperUrl,
                Readme = readme,
                WeightsUrl = weightsUrl,
            };

            return await ModelsUpdateAsync(
                modelOwner: modelOwner,
                modelName: modelName,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}