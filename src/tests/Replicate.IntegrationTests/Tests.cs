namespace Replicate.IntegrationTests;

[TestClass]
public partial class Tests
{
    public static ReplicateApi GetAuthorizedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("REPLICATE_API_KEY") ??
            throw new AssertInconclusiveException("REPLICATE_API_KEY environment variable is not found.");

        var api = new ReplicateApi();
        api.AuthorizeUsingBearer(apiKey);
        
        return api;
    }
}