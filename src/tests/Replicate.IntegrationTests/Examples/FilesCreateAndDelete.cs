/*
order: 30
title: Files Create And Delete
slug: files-create-and-delete
*/

namespace Replicate.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task FilesCreateAndDelete()
    {
        using var api = GetAuthorizedClient();

        var content = System.Text.Encoding.UTF8.GetBytes("Hello, Replicate!");
        var fileName = "test-file.txt";

        var created = await api.FilesCreateAsync(
            content: content,
            contentname: fileName,
            filename: fileName);

        try
        {
            created.Should().NotBeNull();
            created.Id.Should().NotBeNullOrEmpty();
            created.ContentType.Should().NotBeNull();
            created.Size.Should().Be(content.Length);
            created.Checksums.Should().NotBeNull();
            created.Urls.Should().NotBeNull();

            var fetched = await api.FilesGetAsync(created.Id);
            fetched.Should().NotBeNull();
            fetched.Id.Should().Be(created.Id);
        }
        finally
        {
            await api.FilesDeleteAsync(created.Id);
        }
    }
}
