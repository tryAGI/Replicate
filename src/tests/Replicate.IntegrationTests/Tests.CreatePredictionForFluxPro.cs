namespace Replicate.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreatePredictionForFluxPro()
    {
        using var api = GetAuthorizedApi();
        
        var response = await api.ModelsPredictionsCreateAsync(
            input: new Dictionary<string, object>
            {
                ["seed"] = Random.Shared.Next(0, 1000000),
                ["steps"] = 25,
                ["prompt"] = "a female, european, young adult, fit body, wavy acid orange hair, wearing open swimsuit, sea in the background.",
                ["guidance"] = 3.5,
                ["interval"] = 3,
                ["aspect_ratio"] = "16:9",
                ["safety_tolerance"] = 5,
            },
            modelOwner: "black-forest-labs",
            modelName: "flux-pro",
            stream: false,
            webhook: "https://hook.eu2.make.com/h6tawmpxsmxb7ut4edfmje4g3xw8y8rf",
            webhookEventsFilter: null);
        response.Should().NotBeNull();
        response.Id.Should().NotBeNull();
        
        var endResponse = await response.WaitUntilSuccessfulAsync(api);
        
        Console.WriteLine($"Seed: {endResponse.Input?.Seed}.");
        Console.WriteLine("Image available at:");
        Console.WriteLine(endResponse.Output);
        
        //// ![output](https://raw.githubusercontent.com/tryAGI/Replicate/dd1e5c2cbebc53e9b343f1372e5a660159e79ef3/assets/output.webp)
    }
}