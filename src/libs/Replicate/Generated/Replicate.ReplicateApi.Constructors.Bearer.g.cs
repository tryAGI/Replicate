
#nullable enable

namespace Replicate
{
    public sealed partial class ReplicateApi
    {
        /// <inheritdoc cref="ReplicateApi(global::System.Net.Http.HttpClient?, global::System.Uri?)"/>
        public ReplicateApi(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null) : this(httpClient, baseUri)
        {
            AuthorizeUsingBearer(apiKey);
        }
    }
}