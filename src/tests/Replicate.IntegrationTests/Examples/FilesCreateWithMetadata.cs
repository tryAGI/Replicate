/*
order: 50
title: Files Create With Metadata
slug: files-create-with-metadata
*/

namespace Replicate.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task FilesCreateWithMetadata()
    {
        using var api = GetAuthorizedClient();

        var content = System.Text.Encoding.UTF8.GetBytes("metadata test");
        var fileName = "test-metadata.txt";
        var metadata = "{\"test_key\": \"test_value\"}";

        var created = await api.FilesCreateAsync(
            content: content,
            contentname: fileName,
            filename: fileName,
            metadata: metadata);

        try
        {
            created.Should().NotBeNull();
            created.Id.Should().NotBeNullOrEmpty();
        }
        finally
        {
            await api.FilesDeleteAsync(created.Id);
        }
    }
}
