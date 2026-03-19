/*
order: 40
title: Files Create With Content Type
slug: files-create-with-content-type
*/

namespace Replicate.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task FilesCreateWithContentType()
    {
        using var api = GetAuthorizedClient();

        var content = System.Text.Encoding.UTF8.GetBytes("{\"key\": \"value\"}");
        var fileName = "test-file.json";

        var created = await api.FilesCreateAsync(
            content: content,
            contentname: fileName,
            filename: fileName,
            type: "application/json");

        try
        {
            created.Should().NotBeNull();
            created.Should().NotBeNull();
            created.Id.Should().NotBeNullOrEmpty();
        }
        finally
        {
            await api.FilesDeleteAsync(created.Id);
        }
    }
}
