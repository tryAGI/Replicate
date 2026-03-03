using System.Net.Http;
using System.Net.Http.Headers;

namespace Replicate;

public partial class ReplicateApi
{
#pragma warning disable CA1822 // Partial methods cannot be static
#pragma warning disable CA2000 // Content parts are owned by MultipartFormDataContent
    partial void PrepareFilesCreateRequest(
        HttpClient httpClient,
        HttpRequestMessage httpRequestMessage,
        FilesCreateRequest request)
    {
        // Rebuild the multipart content to work around .NET 6+ Content-Disposition
        // formatting changes. Modern .NET no longer quotes name/filename values
        // (e.g. name=content instead of name="content"), but Replicate's API
        // requires quoted values and returns HTTP 500 without them.
        // Also removes the filename* (RFC 5987) extended parameter which
        // Replicate does not support.

        var fileName = request.Contentname ?? request.Filename ?? "upload";
        var contentType = request.Type ?? "application/octet-stream";

        var boundary = Guid.NewGuid().ToString("N");
        var multipart = new MultipartFormDataContent(boundary);

        // Ensure boundary is not quoted in the Content-Type header
        multipart.Headers.Remove("Content-Type");
        multipart.Headers.TryAddWithoutValidation("Content-Type",
            $"multipart/form-data; boundary={boundary}");

        var fileContent = new ByteArrayContent(request.Content ?? []);
        fileContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);
        fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
        {
            Name = $"\"{EscapeQuotes("content")}\"",
            FileName = $"\"{EscapeQuotes(fileName)}\"",
        };
        multipart.Add(fileContent);

        if (request.Metadata != null)
        {
            var metadataContent = new StringContent($"{request.Metadata}");
            metadataContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "\"metadata\"",
            };
            metadataContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            multipart.Add(metadataContent);
        }

        httpRequestMessage.Content = multipart;
    }

#pragma warning disable CA1307 // Ordinal is implied for char/string Replace
    private static string EscapeQuotes(string value) =>
        value.Replace("\\", "\\\\").Replace("\"", "\\\"");
}
