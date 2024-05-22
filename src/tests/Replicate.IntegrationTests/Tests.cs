namespace Replicate.IntegrationTests;

[TestClass]
public class GeneralTests
{
    [TestMethod]
    public async Task Generate()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("REPLICATE_API_KEY") ??
            throw new AssertInconclusiveException("REPLICATE_API_KEY environment variable is not found.");

        using var api = new ReplicateApi();
        api.AuthorizeUsingBearer(apiKey);
        
        await api.CreatePredictionsAsync(
            input: new
            {
                prompt = "I forgot how to kill a process in Linux, can you help?",
                assistant = "Sure! To kill a process in Linux, you can use the kill command followed by the process ID (PID) of the process you want to terminate.",
            },
            version: "b063023ee937f28e922982abdbf97b041ffe34ad3b35a53d33e1d74bb19b36c4");
    }
}