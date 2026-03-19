/*
order: 60
title: Files List
slug: files-list
*/

namespace Replicate.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task FilesList()
    {
        using var api = GetAuthorizedClient();

        var response = await api.FilesListAsync();

        response.Should().NotBeNull();
        response.Results.Should().NotBeNull();
    }
}
