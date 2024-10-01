
#nullable enable

namespace Replicate
{
    public sealed partial class ReplicateApi
    {
        /// <inheritdoc cref="ReplicateApi(global::System.Net.Http.HttpClient?, global::System.Uri?, global::Replicate.EndPointAuthorization?)"/>
        public ReplicateApi(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::Replicate.EndPointAuthorization? authorization = null) : this(httpClient, baseUri, authorization)
        {
            Authorizing(_httpClient, ref apiKey);

            AuthorizeUsingBearer(apiKey);

            Authorized(_httpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}