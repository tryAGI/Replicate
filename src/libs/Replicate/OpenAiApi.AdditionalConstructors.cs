using System.Net.Http;

namespace Replicate;

public partial class ReplicateApi
{
    /// <inheritdoc cref="ReplicateApi(HttpClient?, Uri?)"/>
    public ReplicateApi(
        string apiKey, 
        HttpClient? httpClient = null,
        Uri? baseUri = null) : this(httpClient, baseUri)
    {
        AuthorizeUsingBearer(apiKey);
    }
}