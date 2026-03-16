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

    [TestMethod]
    public async Task FilesList()
    {
        using var api = GetAuthorizedClient();

        var response = await api.FilesListAsync();

        response.Should().NotBeNull();
        response.Results.Should().NotBeNull();
    }

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
