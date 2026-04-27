
#nullable enable

namespace Replicate
{
    public partial class ReplicateClient
    {


        private static readonly global::Replicate.EndPointSecurityRequirement s_ModelsCreateSecurityRequirement0 =
            new global::Replicate.EndPointSecurityRequirement
            {
                Authorizations = new global::Replicate.EndPointAuthorizationRequirement[]
                {                    new global::Replicate.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "BearerAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Replicate.EndPointSecurityRequirement[] s_ModelsCreateSecurityRequirements =
            new global::Replicate.EndPointSecurityRequirement[]
            {                s_ModelsCreateSecurityRequirement0,
            };
        partial void PrepareModelsCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Replicate.ModelsCreateRequest request);
        partial void PrepareModelsCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Replicate.ModelsCreateRequest request);
        partial void ProcessModelsCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessModelsCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a model<br/>
        /// Create a model.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s -X POST \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{"owner": "alice", "name": "hot-dog-detector", "description": "Detect hot dogs in images", "visibility": "public", "hardware": "cpu"}' \<br/>
        ///   https://api.replicate.com/v1/models<br/>
        /// ```<br/>
        /// The response will be a model object in the following format:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "url": "https://replicate.com/alice/hot-dog-detector",<br/>
        ///   "owner": "alice",<br/>
        ///   "name": "hot-dog-detector",<br/>
        ///   "description": "Detect hot dogs in images",<br/>
        ///   "visibility": "public",<br/>
        ///   "github_url": null,<br/>
        ///   "paper_url": null,<br/>
        ///   "license_url": null,<br/>
        ///   "run_count": 0,<br/>
        ///   "cover_image_url": null,<br/>
        ///   "default_example": null,<br/>
        ///   "latest_version": null,<br/>
        /// }<br/>
        /// ```<br/>
        /// Note that there is a limit of 1,000 models per account. For most purposes, we recommend using a single model and pushing new [versions](https://replicate.com/docs/how-does-replicate-work#versions) of the model as you make changes to it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Replicate.SchemasModelResponse> ModelsCreateAsync(

            global::Replicate.ModelsCreateRequest request,
            global::Replicate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareModelsCreateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Replicate.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ModelsCreateSecurityRequirements,
                operationName: "ModelsCreateAsync");

            using var __timeoutCancellationTokenSource = global::Replicate.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Replicate.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Replicate.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Replicate.PathBuilder(
                                path: "/models",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Replicate.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::Replicate.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareModelsCreateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Replicate.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Replicate.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ModelsCreate",
                                methodName: "ModelsCreateAsync",
                                pathTemplate: "\"/models\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Replicate.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Replicate.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ModelsCreate",
                                methodName: "ModelsCreateAsync",
                                pathTemplate: "\"/models\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Replicate.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Replicate.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Replicate.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Replicate.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ModelsCreate",
                                methodName: "ModelsCreateAsync",
                                pathTemplate: "\"/models\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Replicate.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessModelsCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Replicate.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Replicate.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ModelsCreate",
                                methodName: "ModelsCreateAsync",
                                pathTemplate: "\"/models\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Replicate.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Replicate.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ModelsCreate",
                                methodName: "ModelsCreateAsync",
                                pathTemplate: "\"/models\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessModelsCreateResponseContent(
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::Replicate.SchemasModelResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

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

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Create a model<br/>
        /// Create a model.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s -X POST \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{"owner": "alice", "name": "hot-dog-detector", "description": "Detect hot dogs in images", "visibility": "public", "hardware": "cpu"}' \<br/>
        ///   https://api.replicate.com/v1/models<br/>
        /// ```<br/>
        /// The response will be a model object in the following format:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "url": "https://replicate.com/alice/hot-dog-detector",<br/>
        ///   "owner": "alice",<br/>
        ///   "name": "hot-dog-detector",<br/>
        ///   "description": "Detect hot dogs in images",<br/>
        ///   "visibility": "public",<br/>
        ///   "github_url": null,<br/>
        ///   "paper_url": null,<br/>
        ///   "license_url": null,<br/>
        ///   "run_count": 0,<br/>
        ///   "cover_image_url": null,<br/>
        ///   "default_example": null,<br/>
        ///   "latest_version": null,<br/>
        /// }<br/>
        /// ```<br/>
        /// Note that there is a limit of 1,000 models per account. For most purposes, we recommend using a single model and pushing new [versions](https://replicate.com/docs/how-does-replicate-work#versions) of the model as you make changes to it.
        /// </summary>
        /// <param name="coverImageUrl">
        /// A URL for the model's cover image. This should be an image file.
        /// </param>
        /// <param name="description">
        /// A description of the model.<br/>
        /// Example: Detect hot dogs in images
        /// </param>
        /// <param name="githubUrl">
        /// A URL for the model's source code on GitHub.<br/>
        /// Example: https://github.com/alice/hot-dog-detector
        /// </param>
        /// <param name="hardware">
        /// The SKU for the hardware used to run the model. Possible values can be retrieved from the `hardware.list` endpoint.<br/>
        /// Example: cpu
        /// </param>
        /// <param name="licenseUrl">
        /// A URL for the model's license.
        /// </param>
        /// <param name="name">
        /// The name of the model. This must be unique among all models owned by the user or organization.<br/>
        /// Example: hot-dog-detector
        /// </param>
        /// <param name="owner">
        /// The name of the user or organization that will own the model. This must be the same as the user or organization that is making the API request. In other words, the API token used in the request must belong to this user or organization.<br/>
        /// Example: alice
        /// </param>
        /// <param name="paperUrl">
        /// A URL for the model's paper.<br/>
        /// Example: https://arxiv.org/abs/2504.17639
        /// </param>
        /// <param name="visibility">
        /// Whether the model should be public or private. A public model can be viewed and run by anyone, whereas a private model can be viewed and run only by the user or organization members that own the model.<br/>
        /// Example: public
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Replicate.SchemasModelResponse> ModelsCreateAsync(
            string hardware,
            string name,
            string owner,
            global::Replicate.ModelsCreateRequestVisibility visibility,
            string? coverImageUrl = default,
            string? description = default,
            string? githubUrl = default,
            string? licenseUrl = default,
            string? paperUrl = default,
            global::Replicate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Replicate.ModelsCreateRequest
            {
                CoverImageUrl = coverImageUrl,
                Description = description,
                GithubUrl = githubUrl,
                Hardware = hardware,
                LicenseUrl = licenseUrl,
                Name = name,
                Owner = owner,
                PaperUrl = paperUrl,
                Visibility = visibility,
            };

            return await ModelsCreateAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}