using Replicate;

namespace tryAGI.OpenAI.IntegrationTests;

[TestClass]
public class GeneralTests
{
    [TestMethod]
    public async Task Generate()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("REPLICATE_API_KEY") ??
            throw new AssertInconclusiveException("REPLICATE_API_KEY environment variable is not found.");

        using var client = new HttpClient();
        var api = new ReplicateApi(apiKey, client);
        await api.Predictions_createAsync(new Body2
        {
            Input = "",
            Stream = false
        });
    }
}