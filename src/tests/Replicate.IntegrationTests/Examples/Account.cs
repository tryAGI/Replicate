/*
order: 10
title: Account
slug: account
*/

namespace Replicate.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Account()
    {
        using var api = GetAuthorizedClient();
        
        var response = await api.AccountGetAsync();
        
        response.Should().NotBeNull();
        response.Type.Should().Be(AccountGetResponseType.User);
    }
}