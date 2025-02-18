namespace Replicate.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Account()
    {
        using var api = GetAuthorizedApi();
        
        var response = await api.AccountGetAsync();
        
        response.Should().NotBeNull();
        response.Type.Should().Be(AccountGetResponseType.User);
    }
}