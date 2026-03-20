# Files Create With Metadata



This example assumes `using Replicate;` is in scope and `apiKey` contains your Replicate API key.

```csharp
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
}
finally
{
    await api.FilesDeleteAsync(created.Id);
}
```