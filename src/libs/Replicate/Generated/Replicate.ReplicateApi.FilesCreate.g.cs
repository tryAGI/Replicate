
#nullable enable

namespace Replicate
{
    public partial class ReplicateApi
    {
        partial void PrepareFilesCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Replicate.FilesCreateRequest request);
        partial void PrepareFilesCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Replicate.FilesCreateRequest request);
        partial void ProcessFilesCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFilesCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a file<br/>
        /// Create a file by uploading its content and optional metadata.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -X POST https://api.replicate.com/v1/files \<br/>
        ///   -H "Authorization: Token $REPLICATE_API_TOKEN" \<br/>
        ///   -H 'Content-Type: multipart/form-data' \<br/>
        ///   -F 'content=@/path/to/archive.zip;type=application/zip;filename=example.zip' \<br/>
        ///   -F 'metadata={"customer_reference_id": 123};type=application/json'<br/>
        /// ```<br/>
        /// The request must include:<br/>
        /// - `content`: The file content (required)<br/>
        /// - `type`: The content / MIME type for the file (defaults to `application/octet-stream`)<br/>
        /// - `filename`: The filename (required, ≤ 255 bytes, valid UTF-8)<br/>
        /// - `metadata`: User-provided metadata associated with the file (defaults to `{}`, must be valid JSON)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Replicate.SchemasFileResponse> FilesCreateAsync(
            global::Replicate.FilesCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareFilesCreateArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Replicate.PathBuilder(
                path: "/files",
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
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.Content ?? global::System.Array.Empty<byte>()),
                name: "content",
                fileName: request.Contentname ?? string.Empty);
            if (request.Filename != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Filename}"),
                    name: "filename");
            } 
            if (request.Metadata != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Metadata}"),
                    name: "metadata");
            } 
            if (request.Type != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Type}"),
                    name: "type");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareFilesCreateRequest(
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
            ProcessFilesCreateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Content Too Large
            if ((int)__response.StatusCode == 413)
            {
                string? __content_413 = null;
                global::Replicate.FilesCreateResponse? __value_413 = null;
                if (ReadResponseAsString)
                {
                    __content_413 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_413 = global::Replicate.FilesCreateResponse.FromJson(__content_413, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_413 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_413 = await global::Replicate.FilesCreateResponse.FromJsonStreamAsync(__contentStream_413, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Replicate.ApiException<global::Replicate.FilesCreateResponse>(
                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_413,
                    ResponseObject = __value_413,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

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
                ProcessFilesCreateResponseContent(
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
                    global::Replicate.SchemasFileResponse.FromJson(__content, JsonSerializerContext) ??
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
                    await global::Replicate.SchemasFileResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Create a file<br/>
        /// Create a file by uploading its content and optional metadata.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -X POST https://api.replicate.com/v1/files \<br/>
        ///   -H "Authorization: Token $REPLICATE_API_TOKEN" \<br/>
        ///   -H 'Content-Type: multipart/form-data' \<br/>
        ///   -F 'content=@/path/to/archive.zip;type=application/zip;filename=example.zip' \<br/>
        ///   -F 'metadata={"customer_reference_id": 123};type=application/json'<br/>
        /// ```<br/>
        /// The request must include:<br/>
        /// - `content`: The file content (required)<br/>
        /// - `type`: The content / MIME type for the file (defaults to `application/octet-stream`)<br/>
        /// - `filename`: The filename (required, ≤ 255 bytes, valid UTF-8)<br/>
        /// - `metadata`: User-provided metadata associated with the file (defaults to `{}`, must be valid JSON)
        /// </summary>
        /// <param name="content">
        /// The file content
        /// </param>
        /// <param name="contentname">
        /// The file content
        /// </param>
        /// <param name="filename">
        /// The filename
        /// </param>
        /// <param name="metadata">
        /// User-provided metadata associated with the file
        /// </param>
        /// <param name="type">
        /// The content / MIME type for the file<br/>
        /// Default Value: application/octet-stream
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Replicate.SchemasFileResponse> FilesCreateAsync(
            byte[] content,
            string contentname,
            string? filename = default,
            object? metadata = default,
            string? type = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Replicate.FilesCreateRequest
            {
                Content = content,
                Contentname = contentname,
                Filename = filename,
                Metadata = metadata,
                Type = type,
            };

            return await FilesCreateAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}